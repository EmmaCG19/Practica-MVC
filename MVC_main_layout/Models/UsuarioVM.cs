using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_main_layout.DAL;

namespace MVC_main_layout.Models
{
    public class UsuarioVM
    {
        public List<Usuario> Usuarios { get; set; }
        public UsuarioVM()
        {
            this.Usuarios = new List<Usuario>(){
            new Usuario(){Id= 1, Nombre="Cesar", Apellido="Milstein" },
            new Usuario(){Id=2, Nombre="Mister", Apellido="X" },
            new Usuario(){Id=3, Nombre="Tu", Apellido="Vieja" }
            };
        }

    }
}