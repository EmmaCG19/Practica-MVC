using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_main_layout.Controllers
{
    public class EscritoresController : Controller
    {
        [HttpGet]
        public ActionResult MostrarVendedores()
        {



            return View();
        }
    }
}