using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elainluokat;
using Periytyminen;

namespace Periytyminen
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa kissa = new Kissa(0, "", true , "");
            kissa.asetaElaimenIka(3);
            kissa.asetaElaimenNimi("Jorma");
            kissa.AsetaOnLihansyoja(true);

            Console.WriteLine($"Kissa, {kissa.palautaElaimenNimi()}, on {kissa.palautaElaimenIka()} vuotta vanha. \n{kissa.palautaElaimenNimi()} on lihansyoja : {kissa.palautaOnLihansyoja()}");

            Console.WriteLine(kissa.palautaKehraa());

            Koira koira = new Koira(0, "", false, "");
            koira.asetaElaimenIka(12);
            koira.asetaElaimenNimi("Maija");
            koira.AsetaOnLihansyoja(false);

            Console.WriteLine($"Koira, {koira.palautaElaimenNimi()}, on {koira.palautaElaimenIka()} vuotta vanha. \n{koira.palautaElaimenNimi()} on lihansyoja : {koira.palautaOnLihansyoja()}");

            Console.WriteLine(koira.palautaHaukku());

            koira.Aantele();
            kissa.Aantele();

            //Testin vuoksi. Tulostaa UMPH!

            Papukaija kaija = new Papukaija(0, "", false);
            kaija.Aantele();

            Console.WriteLine("\n");

            // Nisäkäs/Lintu ominaisuudet

            Koira koira2 = new Koira(0, "", false, "");
            koira2.asetaElaimenNimi("Nalle");
            koira2.PalautaNelijalka();

            Papukaija lintu = new Papukaija(0, "", false);
            lintu.asetaElaimenNimi("Kaija");
            lintu.asetaElaimenIka(12);
            Console.WriteLine($"Lintu, {lintu.palautaElaimenNimi()}, on {lintu.palautaElaimenIka()} vuotta vanha.\nOsaako {lintu.palautaElaimenNimi()} lentää?");
            lintu.PalautaLentoLintu();

            Console.WriteLine("\n");

            Console.WriteLine($"{koira2.palautaElaimenNimi()} on koira. Onko {koira2.palautaElaimenNimi()} nelijalkainen? ");
            koira.PalautaNelijalka();

            Console.Read();
        }
    }
}