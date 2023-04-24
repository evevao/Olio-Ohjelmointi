using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LounasMaksu
{
    class Program
    {
        static void Main(string[] args)
        {
            Maksukortti pekkaKortti = new Maksukortti("Pekka", 20);
            Console.WriteLine(pekkaKortti);

            Maksukortti mattiKortti = new Maksukortti("Matti", 30);
            Console.WriteLine(mattiKortti);

            pekkaKortti.syoMaukkaasti();
            mattiKortti.syoEdullisesti();

            Console.WriteLine(pekkaKortti);
            Console.WriteLine(mattiKortti);

            pekkaKortti.lataaKortti(20);

            mattiKortti.syoMaukkaasti();

            Console.WriteLine(pekkaKortti);
            Console.WriteLine(mattiKortti);

            pekkaKortti.syoEdullisesti();
            pekkaKortti.syoEdullisesti();

            mattiKortti.lataaKortti(50);

            Console.WriteLine(pekkaKortti);
            Console.WriteLine(mattiKortti);

            Console.Read();
        }
    }
}