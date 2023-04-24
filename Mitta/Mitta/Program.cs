using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitta
{
    class Program
    {
        static void Main(string[] args) 
        {
            Mittari mitta = new Mittari();
            while (!mitta.Taynna())
            {
                Console.WriteLine("Mitta: " + mitta.Mitta());
                mitta.Lisaa();
            }
            Console.WriteLine("Mitta: " + mitta.Mitta() + "\nTÄYNNÄ");

            Console.Read();
        }
    }
}