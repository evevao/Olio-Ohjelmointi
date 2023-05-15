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
    public class Kissa : Elain
    {
        public string kehraa;
        public Kissa(int ika, string nimi, bool lihansyoja) : base(ika, nimi, lihansyoja)
        {
            this.kehraa = kehraa;
        }

        public string palautaKehraa()
        {
            Console.WriteLine("Kissa sanoo: hrrrrr");
            return kehraa;
        }
    }
}