using Elainluokat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periytyminen
{
    public abstract class Nisakkaat : Elain
    {
        private bool nelijalka;
        public Nisakkaat(int ika, string nimi, bool nelijalka) : base(ika, nimi, nelijalka)
        {
        }

        public void AsetaNelijalka(bool nelijalka)
        {
            nelijalka = true;
        }

        public bool PalautaNelijalka() 
        {
            Console.WriteLine("Eläin on nelijalkainen.");
            return true;
        }    
    }
}
