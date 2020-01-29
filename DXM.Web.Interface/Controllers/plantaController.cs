using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DXM.Web.Interface.Controllers
{
    public class plantaController : Controller
    {
        public IActionResult Index()
        {
            if (!Program.registrado) { return RedirectToAction("index", "licenca"); }
            if (Program.oee.DXM_Status.Contains("Online"))
            {
                return View(Program.oee);
            }
            else
            {
                return RedirectToAction("offline","oee");
            }
        }

        [HttpGet]
        public string conjunto_linhas_zeiss()
        {
            if (!Program.registrado) { return "falha"; }
            string ret = "";
            if (Program.oee.DXM_Status.Contains("OffLine")) { ret = "falha"; }
            else { ret = JsonConvert.SerializeObject(Program.oee.Linhas); }
            return ret;
        }
    }
}