using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LounasMaksu
{
    public class Maksukortti
    {
        private double saldo;
        private string nimi;
        public Maksukortti(string nimi, double saldo)
        {
            this.saldo = saldo;
            this.nimi = nimi;
        }

        public void syoEdullisesti()
        {
            if (saldo >= 2.60)
            {
                saldo -= 2.60;
                Console.WriteLine(this.nimi + ". Edullinen ruokamaksu on " + 2.60);
            }
            else
            {
                Console.WriteLine("Kortilla " + this.nimi + " ei ole riittävästi saldoa. Lataa kortillesi lisää saldoa.");
            }
        }

        public void syoMaukkaasti()
        {
            if (saldo >= 4.60)
            {
                saldo -= 4.60;
                Console.WriteLine(this.nimi + ". Maukas ruokamaksu on " + 4.60);
            }
            else
            {
                Console.WriteLine("\nKortilla " + this.nimi + " ei ole riittävästi saldoa ruokamaksuun. \nMaksu perutaan. \nOle hyvä ja lataa kortillesi lisää saldoa.\n");
            }
        }

        public void lataaKortti(double maara)
        {
            if (maara > 0)
            {
                saldo += maara;
                Console.WriteLine("\nKortille " + this.nimi + " lisätty " + maara + " euroa.\n");
            }
            else
            {
                Console.WriteLine(this.nimi + ". Antamasi määrä " + maara + " on virheellinen. Anna uusi määrä.");
            }
        }
        public override string ToString()
        {
            return "\nKortin " + this.nimi + " saldo on: " + this.saldo.ToString("F1") + " eroa.\n";
        }
    }
}