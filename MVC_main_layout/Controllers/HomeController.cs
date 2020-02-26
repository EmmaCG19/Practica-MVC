using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_main_layout.Models;

namespace MVC_main_layout.Controllers
{
    public class HomeController : Controller
    {
        //Mostrar el mismo ViewModel de dos maneras diferentes

        UsuarioVM model = new UsuarioVM();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(model);
        }

        [HttpGet]
        public ActionResult ListarDistinto()
        {
            return View(model);
        }
    }
}