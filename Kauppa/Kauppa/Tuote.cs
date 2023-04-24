using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kauppa
{
    public class Tuote
    {
        private String tuote_nimi;
        private double hinta;
        private int kappale;

        public Tuote()
        {
            tuote_nimi = "";
            hinta = 0d;
            kappale = 0;

        }

        public String Nimi
        {
            get { return tuote_nimi; }
            set { tuote_nimi = value; }  
        }

        public double Hinta
        { 
            get { return hinta; } 
            set {  hinta = value; } 
        }

        public int Kappale
        { 
            get { return kappale; } 
            set { kappale = value; } 
        }

        public void TulostaTuote()
        {
            Console.WriteLine("Tuote: " + Nimi + "\nHinta: " + Hinta + "e" + "\nKappale määrä: " + Kappale + "kpl");
        }
        
    }
}
