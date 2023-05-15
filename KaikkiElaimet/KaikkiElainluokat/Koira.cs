using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KaikkiElainluokat
{
    public class Koira
    {

        public int ika;
        public String nimi;

        public Koira(int ika = 0, string nimi = "Haukkuli")
        {
            if (ika < 0)
            {
                this.ika = 0;
            }
            else
            {
                this.ika = ika;
            }
            nimi = "Haukkuli";
        }

        public bool asetaKoiranIka(int ika)
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

        public int koiraIka()
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


        public bool asetaKoiranNimi(string vuhNimi)
        {
            if (string.Equals(vuhNimi, "Musti", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Koiran nimi ei voi olla Musti.");
                return false;
            }
            else
            {
                this.nimi = vuhNimi;
                return true;
            }
        }



        public string koiraNimi()
        {
            if (string.Equals(this.nimi, "Musti", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Koiran nimi ei voi olla Musti.");
                return "Haukkuli";
            }
            if (string.IsNullOrEmpty(nimi))
            {
                return "Haukkuli";
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
                return "Koira: " + this.nimi + ". Ikä: " + this.ika;
            }
            else
            {
                this.nimi = "Haukkuli";
                return "Koira: " + this.nimi + ". Ikä: " + this.ika;
            }
        }
    }
}