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

        //Cargar un form con los datos de un usuario y mostrar los mismos en un mensaje utilizando el HttpGet

        [HttpGet]
        public ActionResult Index(string Id)
        {
            IndexVM model = new IndexVM();
            ActionResult action = View(model);

             if (Id != null)
            {
                //Busco en los clientes que tengo aquel con ese id
                //model.ClienteSeleccionado = model.Clientes.Where(c => c.Nombre == nombre).First();
                try
                {
                    model.ClienteSeleccionado = model.Clientes.Where(c => c.Id == Convert.ToInt32(Id)).First();

                    model.Id = model.ClienteSeleccionado.Id;
                    model.Nombre = model.ClienteSeleccionado.Nombre;
                    model.Apellido = model.ClienteSeleccionado.Apellido;

                }
                catch (Exception e)
                {
                    action = Content(String.Format("No se pudo encontrar un cliente con esa Id.{0}", e.Message));

                }
            }

            return action;
        }
    }
}