using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelkaKirja
{
    class Program
    {

        static void Main(string[] args)
        {
            Velka laina = new Velka(1000,5);
            laina.TulosSaldo();
            laina.OdotaVuosi();
            laina.TulosSaldo();

            Console.Read();
        }
    }
}