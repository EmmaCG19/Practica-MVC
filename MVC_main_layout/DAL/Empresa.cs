using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_main_layout.DAL
{
    public class Empresa
    {
        public string Nombre { get; set; }
        public DateTime FechaDeApertura { get; set; }
        public List<Cliente> Clientes { get; set; }
        //public int Antiguedad { get { return DateTime.Now.Year - FechaDeApertura.Year; } }

        public Empresa()
        {
            //No agregar nada nuevo
        }

    }
}