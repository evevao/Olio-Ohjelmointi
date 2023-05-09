using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elainluokat;

namespace Elainluokat
{
    class Program
    {
        static void Main(string[] args)
        {
            Hevonen hevonen = new Hevonen();
            hevonen.Nimi = "Histamiini";
            hevonen.Paino = 89;

            Console.WriteLine("Hevonen\nNimi: " + hevonen.Nimi + "\nPaino: " + hevonen.Paino + "kg");

            Kissa kissa1 = new Kissa(9, "Helmi");
            kissa1.nimi = "Helmi";
            Console.WriteLine("Kissa 1: " + kissa1.nimi);

            Kissa kissa2 = new Kissa(2, "Brutus");
            kissa2.nimi = "Brutus";
            Console.WriteLine("Kissa 2: " + kissa2.nimi);

            Console.WriteLine("\n");

            Console.WriteLine("Kissa " + kissa1.kissanNimi() + " on " + kissa1.kissanIka() + " vuotta.");
            Console.WriteLine("Kissa " + kissa2.kissanNimi() + " on " + kissa2.kissanIka() + " vuotta.");

            Console.WriteLine("\n");

            Kissa kissa3 = new Kissa();
            bool totta = kissa3.asetaKissanNimi("Anneli");
            Console.WriteLine("Kissa 3: " + kissa3.kissanNimi());
            bool eiTotta = kissa3.asetaKissanNimi("Hilda");

            Console.WriteLine("\n");

            Kissa katti = new Kissa();
            Console.WriteLine("Anna katille nimi: ");
            katti.nimi = Console.ReadLine();
            Console.WriteLine("Katin nimi: " + katti.kissanNimi());

            Console.WriteLine("\n");

            Console.WriteLine("Anna katille ikä: ");
            try
            {
                string kattiIka = Console.ReadLine();
                if (kattiIka != "")
                {
                    katti.ika = int.Parse(kattiIka);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Katin ikä on: " + 0);
            }

            Console.WriteLine("Katin ikä: " + katti.kissanIka() + " vuotta");

            Console.WriteLine("\n");

            Console.WriteLine(katti.ToString());

            Console.WriteLine("\n");


            Koira koira = new Koira();
            koira.nimi = "Max";
            Console.WriteLine("Koira: " + koira.nimi);

            Console.WriteLine("\n");

            Console.Write("Anna koiralle nimi: ");
            koira.nimi = Console.ReadLine();
            Console.WriteLine("Koira: " + koira.koiraNimi());

            Console.Read();
        }
    }
}