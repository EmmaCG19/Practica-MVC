using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_main_layout.Models;
using MVC_main_layout.DAL;

namespace MVC_main_layout.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            //IndexVM model = new IndexVM();
            //return View(model);

            IndexVM model = new IndexVM();
            List<Escritor> escritores = model.Escritores;
            ViewData["Escritores"] = escritores;

            return View();
        }
       
    }
}