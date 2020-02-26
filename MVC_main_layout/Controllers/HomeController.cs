using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_main_layout.DAL;
using MVC_main_layout.Models;

namespace MVC_main_layout.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            //Random rnd = Math.Floor(Math.Sqrt(((Object)new Random(10))));
            int i = 0;

            IndexVM model = new IndexVM();

            model.Empresa = new Empresa();
            model.Empresa.Clientes = new List<Cliente>()
            {
                new Cliente(){Id=++i, Apellido = "Leloir", TieneDeuda = true},
                new Cliente(){Id=++i, Apellido = "Sadosky", TieneDeuda = false},
                new Cliente(){Id=++i, Apellido = "Balseiro", TieneDeuda = false},
                new Cliente(){Id=++i, Apellido = "Messi", TieneDeuda = true}
            };


            model.Empresa.Nombre = "Abrigos Que Frio";
            model.Empresa.FechaDeApertura = new DateTime(1994, 06, 15);

            return View(model);
        }
    }
}