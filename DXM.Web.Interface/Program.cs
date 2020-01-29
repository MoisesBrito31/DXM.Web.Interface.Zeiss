using System.Threading;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using EasyModbus;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
using Microsoft.AspNetCore.Hosting.WindowsServices;
using System;
using DXM.Web.Interface.Models;

namespace DXM.Web.Interface
{
    public class Program
    {
        
        public static string user = "indefinido";
        public static string regTipo = "Não Registrado";
        public static string chave = "P3DI43NF4SV8D4FA";
        public static string chaveVetor = "E94NFGU4N5M47NA3";
        public static string sInf = crypt.Encriptar(Program.chave, Program.chaveVetor, "infinito");      
        public static string sdataAtual = crypt.Encriptar(Program.chave, Program.chaveVetor, "dataAtual");
        public static string sdataLim = crypt.Encriptar(Program.chave, Program.chaveVetor, "dataLimite");
        public static bool registrado = false;
        public static OEE.OEE oee;
        public static ModbusClient dxm;
        public static Store.Store banco;
        public static bool dxmChange = false;
        public static bool dxmINIcia = true;
        public static string _pathContentRoot;
        public static bool zerar = false;
        public static bool zerarAsc = false;

        public static void Main(string[] args)
        {

            ///*
             banco = new Store.Store();            
             JavaScriptSerializer ser = new JavaScriptSerializer();
             OEE.OEE foo = ser.Deserialize<OEE.OEE>(banco.Fabrica);

             oee = new OEE.OEE(foo.quantidade,foo.Linhas,foo.DXM_Endress,foo.emulador,foo.tickLog,foo.zerou_turno);
             oee.timeOut = foo.timeOut;
             if (oee.DXM_Tcp) { dxm = new ModbusClient(oee.DXM_Endress, 502); }
             else { dxm = new ModbusClient(oee.DXM_Endress); }                  

             ThreadStart start = new ThreadStart(leituraDXM);
             Thread acao = new Thread(start);
             acao.Start();

             ThreadStart log = new ThreadStart(DXMLog);
             Thread acao2 = new Thread(log);
             acao2.Start();

             ThreadStart log2 = new ThreadStart(poolRegistro);
             Thread acao3 = new Thread(log2);
             acao3.Start();

             //*/

            var pathToExec = Process.GetCurrentProcess().MainModule.FileName;
            _pathContentRoot = Path.GetDirectoryName(pathToExec);

            //CreateWebHostBuilder(args).Build().RunAsCustomService();
            CreateWebHostBuilder(args).Build().Run();


        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseUrls("http://*:5000;http://localhost:5000")
            //.UseContentRoot(_pathContentRoot)
            .UseSockets()            
                .UseStartup<Startup>();       
           
        

        public static void leituraDXM()
        {
            int linhas = oee.quantidade;
            bool falha = false;
            int tempoM = 0;
            int turno1 = 6 * 60 + 0;
            int turno2 = 19 * 60 + 0;
            //int turno3 = 22 * 60 + 0;
            zerar = false;
            


            while (!falha)
            {
               linhas = oee.quantidade;

                tempoM = (int)DateTime.Now.TimeOfDay.TotalMinutes;

                if (zerarAsc) { zerar = true; }

                //verifica se iniciou o dia
                if (tempoM < 5 || zerarAsc)
                {
                    oee.zerou_turno[0] = false;
                    oee.zerou_turno[1] = false;
                    oee.zerou_turno[2] = false;
                    banco.set_fabrica(JsonConvert.SerializeObject(oee));
                    

                }

                if (tempoM >= turno1 && !oee.zerou_turno[0])
                {
                    oee.zerou_turno[0] = true;
                    zerar = true;
                    banco.set_fabrica(JsonConvert.SerializeObject(oee));

                }

                if (tempoM >= turno2 && !oee.zerou_turno[1])
                {
                    oee.zerou_turno[1] = true;
                    zerar = true;
                    banco.set_fabrica(JsonConvert.SerializeObject(oee));

                }

                /*
                if (tempoM >= turno3 && !oee.zerou_turno[2])
                {
                    oee.zerou_turno[2] = true;
                    zerar = true;
                    banco.set_fabrica(JsonConvert.SerializeObject(oee));

                }*/

                bool dxm_ok = false;
                try
                {
                    
                    if (dxmINIcia) {
                        if (!dxm.Connected)
                        {
                            if (oee.DXM_Tcp) { dxm = new ModbusClient(oee.DXM_Endress, 502); }
                            else { dxm = new ModbusClient(oee.DXM_Endress); }
                            dxm.ConnectionTimeout = oee.timeOut;
                            dxm.Connect();
                        }
                        //int[] emu =new int[1];
                        int[] li =new int[1];                       
                       // for (int x = 0; x < oee.quantidade; x++)
                        //{
                          //  if (x == 0) {
                           //     emu[0] = oee.emulador;
                                li[0] = oee.quantidade;
                             //   dxm.WriteMultipleRegisters(88, emu);
                                dxm.WriteMultipleRegisters(89, li);
                            //}
                            //vel[0] = oee.Linhas[x].vel_esp;
                            //dxm.WriteMultipleRegisters(57+(x*13), vel);
                      //  }
                        dxmINIcia = false;
                        Thread.Sleep(oee.timeOut);
                        
                    }
                    else { 
                    
                    for (int x = 0; x < linhas; x++)
                    {
                        if (!dxm.Connected)
                        {
                            if (oee.DXM_Tcp) { dxm = new ModbusClient(oee.DXM_Endress, 502); }
                            else { dxm = new ModbusClient(oee.DXM_Endress); }                            
                            dxm.ConnectionTimeout = oee.timeOut;
                            dxm.Connect();
                        }
                            int[] con = dxm.ReadHoldingRegisters(88, 2);
                            oee.emulador = con[0];
                            oee.alteraLinhas(con[1]);
                            oee.Linhas[x].leituraStatus(dxm.ReadHoldingRegisters(0 + x * 4, 4));
                            oee.Linhas[x].leituratimes(dxm.ReadHoldingRegisters(100 + x * 4, 4));
                            oee.Linhas[x].leituraPercent(dxm.ReadHoldingRegisters(200 + x * 4, 4));

                            //força zerar:
                            if (zerar)
                            {
                                int[] wri = new int[1];
                                wri[0] = 1;
                                dxm.WriteMultipleRegisters(300 +  (x*4 ), wri);
                                dxm.WriteMultipleRegisters(301 + (x * 4), wri);
                                dxm.WriteMultipleRegisters(302 + (x * 4), wri);
                                dxm.WriteMultipleRegisters(303 + (x * 4), wri);
                               

                            }

                            dxm_ok = true;
                            
                    }

                        if (zerar)
                        {
                            zerar = false;
                            if (zerarAsc) { zerarAsc = false; }
                            banco.set_fabrica(JsonConvert.SerializeObject(oee));
                        }
                    }
                }
                catch {
                  
                    if (oee.DXM_Tcp) { dxm = new ModbusClient(oee.DXM_Endress, 502); }
                    else { dxm = new ModbusClient(oee.DXM_Endress); }
                    dxmINIcia = true;
                    Thread.Sleep(oee.timeOut);                   
                    
                }
               
                if (dxm_ok) { oee.DXM_insertOnLine(); }
                else { oee.DXM_insertFalha(); }
                Thread.Sleep(1000);
            }

        }

        public static void DXMLog()
        {
            int contador = 0;
            while (true) {
                long hora = DateTime.Now.ToFileTime();
                int linhas = oee.quantidade;
                contador++;
                
                if (contador >= oee.tickLog)
                {                    
                    contador = 0;
                    for (int z = 0; z < linhas; z++)
                    {
                        try
                        {
                            //if (!oee.Linhas[z].Estado.Contains("DXM")) {
                                oee.flush();
                                banco.exec_log(oee.Linhas[z]);
                            //}
                        }
                        catch { }
                    }
                    banco.set_fabrica(JsonConvert.SerializeObject(oee));
                }
                Thread.Sleep(1000);
                  
                }
            }

        public static void registro()
        {
            try
            {
                //verifica integrigade do reistro
                string atual = crypt.Encriptar(Program.chave, Program.chaveVetor, DateTime.Now.Date.ToShortDateString());
                string dataIni = (string)Registry.GetValue("HKEY_CURRENT_USER\\DXM_Web", sdataAtual, "not exist.");
                string datafim = (string)Registry.GetValue("HKEY_CURRENT_USER\\DXM_Web", sdataLim, "not exist.");
                string indefinido = (string)Registry.GetValue("HKEY_CURRENT_USER\\DXM_Web", sInf, "not exist.");

                DateTime d_ini = Convert.ToDateTime(crypt.Decriptar(chave, chaveVetor, dataIni));
                DateTime d_fim = Convert.ToDateTime(crypt.Decriptar(chave, chaveVetor, datafim));
                bool inf = Convert.ToBoolean(crypt.Decriptar(chave, chaveVetor, indefinido));

                user = (string)Registry.GetValue("HKEY_CURRENT_USER\\DXM_Web", "usuario", "indefinido");

                if (d_ini.Date > DateTime.Now.Date)
                {
                    registrado = false;
                    regTipo = "Não Registrado";
                    Registry.SetValue("HKEY_CURRENT_USER\\DXM_Web", sdataAtual,"falha");
                    Registry.SetValue("HKEY_CURRENT_USER\\DXM_Web", sdataLim, "falha");
                    Registry.SetValue("HKEY_CURRENT_USER\\DXM_Web",sInf, "falha");
                }
                else if (DateTime.Now.Date > d_fim.Date)
                {
                    registrado = false;
                    regTipo = "Não Registrado";
                    Registry.SetValue("HKEY_CURRENT_USER\\DXM_Web", sdataAtual, "falha");
                    Registry.SetValue("HKEY_CURRENT_USER\\DXM_Web", sdataLim, "falha");
                    Registry.SetValue("HKEY_CURRENT_USER\\DXM_Web", sInf, "falha");
                }
                else if (inf)
                {
                    registrado = true;
                    regTipo = "Permanente";
                }
                else
                {
                    Registry.SetValue("HKEY_CURRENT_USER\\DXM_Web", sdataAtual, atual);
                    registrado = true;
                    regTipo = "vencimento " + d_fim.Date.ToShortDateString();
                    
                }

            }
            catch
            { registrado = false; }
            
        }

        public static void poolRegistro()
        {
            while (true)
            {
                registro();
                Thread.Sleep(300000);
            }
        }

        }

     
    
}

