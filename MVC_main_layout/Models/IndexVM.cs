using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_main_layout.Models
{
    public class IndexVM
    {
        public IndexVM()
        {
            this.Clientes = new List<Cliente>()
            {
                new Cliente(){Id= 1, Nombre="Juan", Apellido="Estevez", TieneDeuda=false},
                new Cliente(){Id= 2, Nombre="Maria", Apellido="Zorragrieta", TieneDeuda=true},
                new Cliente(){Id= 3, Nombre="Marcelo", Apellido="Gallardo", TieneDeuda=false},
            };

        }

        public Cliente ClienteSeleccionado{ get; set; }
        public List<Cliente> Clientes { get; set; }

        //Campos del Form
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        //Metodos privados
        private static int GenerarId()
        {
            Random rnd = new Random();
            int id = rnd.Next(1, 100);

            return id;
        }
    }
}