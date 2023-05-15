using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikkiElainluokat
{
    public class Kissa
    {

        public int ika;
        public String nimi;

        public Kissa(int ika = 0, string nimi = "Miuku")
        {
            if (ika < 0)
            {
                this.ika = 0;
            }
            else
            {
                this.ika = ika;
            }
            nimi = "Miuku";
        }

        public bool asetaKissanIka(int ika)
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

        public int kissanIka()
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


        public bool asetaKissanNimi(string kisNimi)
        {
            if (string.Equals(kisNimi, "Hilda", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Kissan nimi ei voi olla Hilda.");
                return false;
            }
            else
            {
                this.nimi = kisNimi;
                return true;
            }
        }



        public string kissanNimi()
        {
            if (string.Equals(this.nimi, "Hilda", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Katin nimi ei voi olla Hilda.");
                return "Miuku";
            }
            if (string.IsNullOrEmpty(nimi))
            {
                return "Miuku";
            }
            else
            {
                return this.nimi;
            }
        }

        public override string ToString()
        {
            if (!string.IsNullOrEmpty(this.nimi))
            {
                return "Kissa: " + this.nimi + ". Ikä: " + this.ika;
            }
            else
            {
                this.nimi = "Miuku";
                return "Kissa: " + this.nimi + ". Ikä: " + this.ika;
            }
        }
    }
}
