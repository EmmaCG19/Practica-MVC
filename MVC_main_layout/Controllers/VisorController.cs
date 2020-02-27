using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_main_layout.Models;

namespace MVC_main_layout.Controllers
{
    public class VisorController : Controller
    {
        [HttpGet]
        public ActionResult Histograma()
        {
            VotosVM model = null;

            try
            {
                //Intento crear el objeto con valores que superan el 100%
                model = new VotosVM(30, 20, 50);
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;

            }

            return View(model);
        }
    }
}