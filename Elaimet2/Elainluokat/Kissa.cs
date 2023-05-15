using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Elainluokat;

namespace Elainluokat
{
    public class Kissa : Elain
    {
        public string kehraa;
        public Kissa(int ika, string nimi, bool lihansyoja) : base(ika, nimi, lihansyoja)
        {

        }

        public void Kehraa()
        {
            Console.WriteLine("Kissa sanoo: hrrrrr");
        }
    }
}