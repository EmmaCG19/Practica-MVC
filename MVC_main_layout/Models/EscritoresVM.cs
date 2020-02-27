using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_main_layout.Models
{
    public class EscritoresVM
    {
        static int contador_instancias = 0;

        public List<Escritor> Escritores { get; set; }
        public EscritoresVM()
        {
            this.Escritores = new List<Escritor>()
            {
                new Escritor(){Nombre="Escritor Uno", EscribeAMaquina=true },
                new Escritor(){Nombre="Escritor Dos", EscribeAMaquina=false },
                new Escritor(){Nombre="Escritor Tres", EscribeAMaquina=false },
                new Escritor(){Nombre="Escritor Cuatro", EscribeAMaquina=true }
            };

        }

        //TEST
        ~EscritoresVM()
        {
            contador_instancias++;
        }
    }
}