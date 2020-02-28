using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_main_layout.DAL;

namespace MVC_main_layout.Models
{
    public class UsuarioVM
    {
        UsuariosDBEntities context = new UsuariosDBEntities();
        public UsuarioVM()
        {
            this.Usuarios = context.Usuarios.ToList();

        }

        public string Nombre { get; set; }
        public string Password { get; set; }
        public List<Usuario> Usuarios { get; set; }


    }
}