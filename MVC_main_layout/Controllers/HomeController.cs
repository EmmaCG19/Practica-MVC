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
        [HttpGet]
        public ActionResult Index()
        {
            IndexVM model = new IndexVM();
            model.CantNumeros = 20;
            model.ValoresPares = this.CalcularValoresPares(model.CantNumeros);

            return View(model);
        }

        private List<int> CalcularValoresPares(int cantidad)
        {
            //Los primeros {CantNumeros} valores pares
            List<int> valoresPares = new List<int>();

            for (int i = 0; valoresPares.Count < cantidad;)
            {
                if (i % 2 == 0)
                {
                    valoresPares.Add(i);
                }

                i++;
            }

            return valoresPares;
        }
    }
}