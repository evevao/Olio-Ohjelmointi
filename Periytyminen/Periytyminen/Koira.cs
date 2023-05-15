using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Elainluokat;


namespace Periytyminen
{
    public class Koira : Nisakkaat
    {
        public string haukku;

        public Koira(int ika, string nimi, bool lihansyoja, string haukku) : base(ika, nimi, lihansyoja)
        {
            this.haukku = haukku;
        }

        public string palautaHaukku()
        {
            Console.WriteLine("Koira sanoo: Hau hau");
            return haukku;
        }

        public override void Aantele()
        {
            Console.WriteLine("Wuh!");
        }
    }
}