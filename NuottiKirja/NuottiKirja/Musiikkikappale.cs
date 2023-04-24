using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NuottiKirja
{
    public class Musiikkikappale
    {
        private string nimi;
        private int pituus;

        public Musiikkikappale(string kappaleenNimi, int kappaleenPituus)
        {
            nimi = kappaleenNimi;
            pituus = kappaleenPituus;
        }
        public String Nimi()
        {
            return nimi;
        }

        public int Pituus()
        { 
            return pituus;
        }

    }
}