using Elainluokat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Periytyminen
{
    public abstract class Linnut : Elain
    {
        private bool lento;
        public Linnut(int ika, string nimi, bool lento) : base(ika, nimi, lento)
        {

        }

        public void AsetaLentoLintu(bool lento)
        {
            lento = true;
        }

        public bool PalautaLentoLintu()
        {
            Console.WriteLine("Eläin osaa lentää.");
            return true;
        }
    }
}
