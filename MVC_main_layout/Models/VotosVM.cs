using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_main_layout.Models
{
    public class VotosVM
    {
        public VotosVM()
        {
            this.CandidatoA = 10;
            this.CandidatoB = 30;
            this.CandidatoC = 60;
        }

        public VotosVM(int candidatoA, int candidatoB, int candidatoC)
        {

            //Regla de negocio
            if (candidatoA + candidatoB + candidatoC <= 100)
            {
                this.CandidatoA = candidatoA;
                this.CandidatoB = candidatoB;
                this.CandidatoC = candidatoC;
            }
            else
                throw new Exception("Los valores ingresadores no pueden superar el 100%");
            
        }

        public int CandidatoA { get; set; }
        public int CandidatoB { get; set; }
        public int CandidatoC { get; set; }

    }
}