using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace U1_W3_D3_Homework_Backend
{
    public class Auto
    {
        public string Nome { get; set; }
        public double Prezzo { get; set;}
        public double CostoOptional { get; set; }
        public double CostoGaranzia = 120;
        public double AnniGaranzia { get; set; }    

        public double TotaleGaranzia()
        {
            return CostoGaranzia * AnniGaranzia;
        }

        public double CostoAuto () 
        {
            return Prezzo + CostoOptional + TotaleGaranzia();
        }
    }
}