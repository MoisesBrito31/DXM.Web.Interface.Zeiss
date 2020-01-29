using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using EasyModbus;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.WindowsServices;

namespace DXM.Web.Interface
{
    public class CustomwebHostService : WebHostService
    {
        public CustomwebHostService(IWebHost host) : base(host) { }

        protected override void OnStarting(string[] args)
        {
            Program.banco = new Store.Store();
            JavaScriptSerializer ser = new JavaScriptSerializer();
            OEE.OEE foo = ser.Deserialize<OEE.OEE>(Program.banco.Fabrica);

            Program.oee = new OEE.OEE(foo.quantidade, foo.Linhas, foo.DXM_Endress, foo.emulador, foo.tickLog, foo.zerou_turno);
            Program.oee.timeOut = foo.timeOut;
            if (Program.oee.DXM_Tcp) { Program.dxm = new ModbusClient(Program.oee.DXM_Endress, 502); }
            else { Program.dxm = new ModbusClient(Program.oee.DXM_Endress); }

            ThreadStart start = new ThreadStart(Program.leituraDXM);
            Thread acao = new Thread(start);
            acao.Start();

            ThreadStart log = new ThreadStart(Program.DXMLog);
            Thread acao2 = new Thread(log);
            acao2.Start();

            ThreadStart log2 = new ThreadStart(Program.poolRegistro);
            Thread acao3 = new Thread(log2);
            acao3.Start();
        }

        protected override void OnStarted()
        {
            base.OnStarted();
        }

        protected override void OnStopping()
        {
            base.OnStopping();
        }

    }
}
