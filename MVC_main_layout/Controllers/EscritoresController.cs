using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_main_layout.Models;

namespace MVC_main_layout.Controllers
{
    public class EscritoresController : Controller
    {
        [HttpGet]
        public ActionResult MostrarEscritores()
        {
            EscritoresVM model = new EscritoresVM();
            return View(model);
        }
    }
}