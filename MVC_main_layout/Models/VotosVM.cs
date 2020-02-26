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
            this.CandidatoA = 30;
            this.CandidatoB = 40;
            this.CandidatoC = 30;
        }

        public int CandidatoA { get; set; }
        public int CandidatoB { get; set; }
        public int CandidatoC { get; set; }

    }
}