using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DXM.OEE;
using Newtonsoft.Json;
using System.Web.Script.Serialization;


namespace DXM.Store
{
    public class Store
    {
        public string pasta { get; set; } = string.Format("{0}store\\",AppContext.BaseDirectory);
        public string Fabrica { get; set; }
        public bool linhaDisp { get; set; } = true;
        public string servicePorta { get; set; } = "";
        public bool serviceStartUp { get; set; } = false;
        

        public Store()
        {
            Directory.CreateDirectory(pasta);
            bool existe = File.Exists(pasta + "fabrica.data");
            bool serviceCongi = File.Exists(pasta + "service.data");
            
            if (!existe){
                string json = "{\"Linhas\":[{\"id\":0,\"cont\":0,\"cont_in\":0,\"cont_out\":0,\"maq_sts\":false,\"h_ini\":-1,\"h_fim\":-1,\"oee\":0,\"per\":0,\"q\":0,\"dis\":0,\"cont_ini\":0,\"cont_fim\":0,\"vel_atu\":0,\"vel_esp\":300,\"buffer\":0,\"forma\":0,\"t_p_prog\":0,\"t_par\":0,\"t_prod\":7,\"historico\":[],\"histFiltro\":[],\"filtro_Ini\":\"0001-01-01T00:00:00\",\"filtro_fim\":\"0001-01-01T00:00:00\",\"nome\":\"Linha produtiva 1\",\"Estado\":\"Operando\"}],\"quantidade\":1,\"DXM_Status\":\"DXM Online\",\"DXM_Endress\":\"192.168.0.4\",\"DXM_Tcp\":true,\"emulador\":0}";
                StreamWriter wr = new StreamWriter(pasta + "fabrica.data");
                wr.WriteLine(json);
                wr.Close();
                Fabrica = json;
            }
            else{
                StreamReader rd = new StreamReader(pasta + "fabrica.data");
                Fabrica = rd.ReadLine();
                rd.Close();
            }

            if (!serviceCongi)
            {                
                StreamWriter wr = new StreamWriter(pasta + "service.data");
                wr.WriteLine("5000");
                wr.WriteLine("true");
                wr.Close();
                servicePorta = "5000";
                serviceStartUp = true;
            }
            else
            {
                StreamReader rd = new StreamReader(pasta + "service.data");
                servicePorta = rd.ReadLine();
                serviceStartUp = Convert.ToBoolean(rd.ReadLine());
                rd.Close();
            }
           
        }

        public void gravaService(string Porta,bool startup)
        {
            StreamWriter wr = new StreamWriter(pasta + "service.data");
            wr.WriteLine(Porta);
            wr.WriteLine(startup);
            wr.Close();
        }

        public bool set_fabrica(string dado)
        {
            bool ret= false;
            try
            {
                StreamWriter wr = new StreamWriter(pasta + "fabrica.data");
                wr.WriteLine(dado);
                wr.Close();
                ret = true;
                Fabrica = dado;
            }
            catch { }
            return ret;
        }

        public bool exec_log(Linha l)
        {
            bool ret = false;
            int cont = 0;
            List<Hist> hist = new List<Hist>();
            while (!linhaDisp) { if (cont > 100000) { return ret; } }
            linhaDisp = false;

            List<string> buffer = new List<string>();
            try
            {
                if (File.Exists(pasta + l.id + ".data"))
                {
                    StreamReader rd = new StreamReader(pasta + l.id + ".data");
                    while (!rd.EndOfStream)
                    {
                        buffer.Add(rd.ReadLine());
                    }
                    rd.Close();
                    rd.Dispose();
                }
                else {}
               
            }
            catch { }
                
            try
            {
               
                Hist h = new Hist(l.parado_t,l.rodando_t,l.espera_t,l.falha_t,l.parado_per,l.rodando_per,l.espera_per,l.falha_per);
                buffer.Add(JsonConvert.SerializeObject(h));
                StreamWriter wr = new StreamWriter(pasta + l.id + ".data");
                for (int x = 0; x < buffer.Count; x++)
                {
                    wr.WriteLine(buffer[x]);
                }
                wr.Close();
                wr.Dispose();
                ret = true;
            }
            catch(Exception ex) { string m=ex.Message; }

            linhaDisp = true;
            return ret;
        }

        public List<Hist> get_linha_hist(int id)
        {
            int cont = 0;
            List<Hist> hist = new List<Hist>();
            while (!linhaDisp) { if (cont > 100000) { return hist; } }
            linhaDisp = false;
            try
            {
                string jon = "";
                StreamReader rd = new StreamReader(pasta + id + ".data");
                while (!rd.EndOfStream)
                {
                    jon = rd.ReadLine();
                    JavaScriptSerializer ser = new JavaScriptSerializer();
                    hist.Add(ser.Deserialize<Hist>(jon));
                }
                rd.Close();
            }
            catch { }
            
            linhaDisp = true;
            return hist;
        }
        public List<Hist> get_linha_hist(int id, DateTime ini, DateTime fim)
        {
            int cont = 0;
            List<Hist> hist = new List<Hist>();
            while (!linhaDisp) { if (cont > 100000) { return hist; } }          
            linhaDisp = false;
            try
            {
                string jon = "";
                StreamReader rd = new StreamReader(pasta + id + ".data");
                while (!rd.EndOfStream)
                {
                    jon = rd.ReadLine();
                    JavaScriptSerializer ser = new JavaScriptSerializer();
                    Hist h = ser.Deserialize<Hist>(jon);
                    if(h.time>=ini && h.time <= fim) { hist.Add(h); }                    
                }
                rd.Close();
            }
            catch { }
            linhaDisp = true;
            return hist;
        }
    }
}
