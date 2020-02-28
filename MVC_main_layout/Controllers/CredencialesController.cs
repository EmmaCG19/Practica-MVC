using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_main_layout.Models;
using MVC_main_layout.DAL;

namespace MVC_main_layout.Controllers
{
    public class CredencialesController : Controller
    {
        UsuariosDBEntities context = new UsuariosDBEntities();

        //Es la vista que genera el controlador cuando el usuario solicita la pantalla del login 
        [HttpGet]
        public ActionResult Usuario()
        {
            UsuarioVM model = new UsuarioVM();
            return View(model);
        }

        //Es la vista que genera el controlador luego de que el usuario haya enviado su solicitud de ingreso  
        [HttpPost]
        public ActionResult Usuario(UsuarioVM model, string btnIngresar)
        {
            Usuario userAVerificar = null;

            if (ModelState.IsValid)
            {
                if (btnIngresar != null)
                {
                    //Verificar que las credenciales sean válidas
                    try
                    {
                        //Verifico si el nombre y el pass coincide con alguno de los usuarios registrados.
                        //Tengamos en cuenta que el nombre de un USUARIO TIENE QUE SER UNICO Y NO PUEDE REPETIRSE

                        userAVerificar = model.Usuarios.Where(u => u.Nombre.Equals(model.Nombre) && u.Clave.Equals(model.Password)).First();

                        //Si hubo coincidencia, emitir un mensaje de que el login fue exitoso
                        if (userAVerificar != null)
                        {
                            ViewBag.LoginOK = true;
                            ViewBag.Color = "green";
                            ViewBag.Msg = "Las credenciales son válidas";
                        }

                    }
                    catch (Exception e)
                    {
                        ViewBag.LoginOK = false;
                        ViewBag.Color = "red";
                        ViewBag.Msg = String.Format("Las credenciales son inválidas.{0}",e.Message);
                    }
                }
            }

            return View(model);
        }
    }
}