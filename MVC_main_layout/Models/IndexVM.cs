using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_main_layout.DAL;

namespace MVC_main_layout.Models
{
    public class IndexVM
    {
        public List<Escritor> Escritores
        {
            get
            {
                return
                    new List<Escritor>()
                {
                    new Escritor(){Nombre = "Sabato"},
                    new Escritor(){Nombre= "Sadosky" },
                    new Escritor(){Nombre= "Poe" },
                    new Escritor(){Nombre= "Neruda" }
                };
            }
        }

    }
}