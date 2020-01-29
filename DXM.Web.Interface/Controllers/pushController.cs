using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DXM.Web.Interface.Models;
using Microsoft.AspNetCore.Mvc;
using DXM.OEE;

namespace DXM.Web.Interface.Controllers
{
    public class pushController : Controller
    {
        public IActionResult Index()
        {
            Linha linha = Program.oee.Linhas[0];
            return View(linha);
        }
    }
}