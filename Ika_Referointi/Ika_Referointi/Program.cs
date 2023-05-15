using Elainluokat;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ika_Referointi
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++) // Toimii, mutta tulostaessa tarvitsee painaa Enter-painiketta, jotta kaikki 10 tulee.
            {
                Kissa kissa = new Kissa();
                int kissanIka = new Random().Next(1, 11);
                kissa.asetaKissanIka(kissanIka);

                Koira koira = new Koira();
                int koiranIka = new Random().Next(1, 16);
                koira.asetaKoiranIka(koiranIka);


                Console.WriteLine($"Kissa on {kissa.kissanIka()} vuotta vanha. \nKoira on {koira.koiraIka()} vuotta vanha.");


                if (kissa.kissanIka() > koira.koiraIka())
                {
                    Console.WriteLine("Koira on vanhempi");
                }
                else if (koira.koiraIka() > kissa.kissanIka())
                    {
                    Console.WriteLine("Kissa on vanhempi");
                    }
                else
                {
                    Console.WriteLine("Kissa ja koira ovat yhtä vanhoja");
                }

                Console.Read();
            }
        }
    }
}