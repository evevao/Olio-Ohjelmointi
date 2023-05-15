using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elainluokat;

namespace Elaimet2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa kissa = new Kissa();
            kissa.Kehraa();

            Console.Read();
        }
    }
}