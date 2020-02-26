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
            VotosVM model = new VotosVM();
            return View(model);
        }
    }
}