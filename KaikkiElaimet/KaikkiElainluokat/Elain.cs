using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikkiElainluokat
{
    public class Elain
    {
        public int ika;
        public string nimi;
        private bool lihansyoja;

        public Elain()
        { }

        public bool asetaElaimenIka(int ika)
        {
            if (ika < 0)
            {
                Console.WriteLine("Ikä ei voi olla pienempi kuin 0 vuotta");
                return false;
            }
            else
            {
                this.ika = ika;
                return true;
            }
        }

        public int palautaElaimenIka()
        {
            if (ika < 0)
            {
                Console.WriteLine("Ikä ei voi olla pienempi kuin 0 vuotta");
                return 0;
            }
            else
            {
                return this.ika;
            }
        }

        public bool asetaElaimenNimi(string nimi)
        {
            this.nimi = nimi;
            return true;
        }

        public string palautaElaimenNimi()
        {
            return this.nimi;
        }
        public void AsetaOnLihansyoja(bool lihansyoja)
        {
            Console.WriteLine("On lihansyöjä: " + lihansyoja);
            this.lihansyoja = lihansyoja;
        }
        public bool palautaOnLihansyoja()
        {
            return this.lihansyoja;
        }
    }
}
