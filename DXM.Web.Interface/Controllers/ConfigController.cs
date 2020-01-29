using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EasyModbus;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DXM.Web.Interface.Controllers
{
    public class ConfigController : Controller
    {
        public IActionResult Index()
        {
           
            if (!Program.registrado) { return RedirectToAction("index", "licenca"); }
            return View(Program.oee);
        }

        public string setLinhaNome(int id, string valor)
        {
            if (!Program.registrado) { return "falha"; }
            try { 
            Program.oee.Linhas[id].nome = valor;
            Program.banco.set_fabrica(JsonConvert.SerializeObject(Program.oee));
            return "ok";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public string zerarLinha(int id)
        {
            if (!Program.registrado) { return "falha"; }
            try
            {
                if (!Program.dxm.Connected)
                {
                    if (Program.oee.DXM_Tcp) { Program.dxm = new ModbusClient(Program.oee.DXM_Endress, 502); }
                    else { Program.dxm = new ModbusClient((Program.oee.DXM_Endress)); }
                    Program.dxm.ConnectionTimeout = 3000;
                    Program.dxm.Connect();
                }
                int[] wri = new int[1];
                wri[0] = 1;
                if (id < 90)
                {
                    Program.dxm.WriteMultipleRegisters(300 + (id * 4), wri);
                    Program.dxm.WriteMultipleRegisters(301 + (id * 4), wri);
                    Program.dxm.WriteMultipleRegisters(302 + (id * 4), wri);
                    Program.dxm.WriteMultipleRegisters(303 + (id * 4), wri);
                }
                else
                {
                    Program.zerarAsc = true;
                }


                Program.banco.set_fabrica(JsonConvert.SerializeObject(Program.oee));
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string setIp(string ip)
        {
            if (!Program.registrado) { return "falha"; }
            try
            {
                Program.oee.DXM_Endress = ip;
                Program.banco.set_fabrica(JsonConvert.SerializeObject(Program.oee));
                Program.dxm.Disconnect();
                Thread.Sleep(5000);
                Program.oee.flush();
                Program.banco.set_fabrica(JsonConvert.SerializeObject(Program.oee));
                return "ok";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            
        }

        [HttpGet]
        public string emula(int valor)
        {
            if (!Program.registrado) { return "falha"; }
            string ret = "";
            int[] reg = new int[1];
            reg[0] = valor;
            try
            {
                if (!Program.dxm.Connected)
                {
                    if (Program.oee.DXM_Tcp) { Program.dxm = new ModbusClient(Program.oee.DXM_Endress, 502); }
                    else { Program.dxm = new ModbusClient((Program.oee.DXM_Endress)); }
                    Program.dxm.ConnectionTimeout = 3000;
                    Program.dxm.Connect();
                }
                Program.dxm.WriteMultipleRegisters(48, reg);
                Program.oee.emulador = valor;
                Program.oee.flush();
                Program.banco.set_fabrica(JsonConvert.SerializeObject(Program.oee));
                ret = "ok";
            }
            catch (Exception ex)
            {
                ret = ex.Message;
            }
            Thread.Sleep(1000);           
            return ret;
        }
        [HttpGet]
        public string setLinhas(int valor)
        {
            if (!Program.registrado) { return "falha"; }
            string ret = "";
            int[] reg = new int[1];
            reg[0] = valor;
            try
            {
                if (!Program.dxm.Connected)
                {
                    if (Program.oee.DXM_Tcp) { Program.dxm = new ModbusClient(Program.oee.DXM_Endress, 502); }
                    else { Program.dxm = new ModbusClient((Program.oee.DXM_Endress)); }
                    Program.dxm.ConnectionTimeout = 3000;
                    Program.dxm.Connect();
                }
                Program.dxm.WriteMultipleRegisters(89, reg);
                Program.oee.quantidade = valor;
                Program.oee.flush();
                Program.banco.set_fabrica(JsonConvert.SerializeObject(Program.oee));
                ret = "ok";
            }
            catch (Exception ex)
            {
                ret = ex.Message;
            }
            Thread.Sleep(1000);           
            return ret;
        }

        [HttpGet]
        public string setTimeOut(int valor)
        {
            if (!Program.registrado) { return "falha"; }
            string ret = "";           
            try
            {
                Program.oee.timeOut = valor;
                ret = "ok";
            }
            catch (Exception ex)
            {
                ret = ex.Message;
            }
            Thread.Sleep(1000);
            return ret;
        }

        [HttpGet]
        public string setTickLog(int valor)
        {
            if (!Program.registrado) { return "falha"; }
            string ret = "";
            int[] reg = new int[1];
            reg[0] = valor;
            try
            {
               
                Program.oee.tickLog = valor;               
                Program.banco.set_fabrica(JsonConvert.SerializeObject(Program.oee));
                ret = "ok";
            }
            catch (Exception ex)
            {
                ret = ex.Message;
            }           
           
            return ret;
        }

        [HttpGet]
        public FileResult download(string arquivo)
        {
            if (!Program.registrado) { return File(new byte[2], "", ""); }
            byte[] bite = new byte[1];
            string arq = "";
            string n = "";
            switch (arquivo)
            {
                case "xml":
                    arq = string.Format("{0}\\wwwroot\\script\\{1}", Program._pathContentRoot, "DXM_OEE.xml");
                    n = "DXM_OEE.xml";
                    break;
                case "sb":
                    arq = string.Format("{0}\\wwwroot\\script\\{1}", Program._pathContentRoot, "OEE.sb");
                    n = "OEE.sb";
                    break;
            }
            
            try
            {
                StreamReader rd = new StreamReader(arq);
                bite = Encoding.UTF8.GetBytes(rd.ReadToEnd());
                rd.Close();               
            }
            catch (Exception ex) {
                bite = Encoding.UTF8.GetBytes(ex.Message);
                n = "falha.txt";
            }

            DateTime d = DateTime.Now.Date;
            return File(bite, "text/txt",n);
        }

    }
}