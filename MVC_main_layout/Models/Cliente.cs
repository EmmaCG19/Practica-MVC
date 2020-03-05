using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_main_layout.Models
{
    public class Cliente
    {
        public int Id{ get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool TieneDeuda { get; set; }
    }
}