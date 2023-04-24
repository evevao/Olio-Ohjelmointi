using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kauppa
{
    class Program
    {
        static void Main(string[] args) 
        { 
            Tuote tuote = new Tuote();
            tuote.Nimi = "Banaani";
            tuote.Hinta = 4.5;
            tuote.Kappale = 15;

            tuote.TulostaTuote();

            Console.Read();
        }
    }
}