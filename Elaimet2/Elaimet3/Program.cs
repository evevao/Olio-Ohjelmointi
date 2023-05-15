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
            Kissa kissa = new Kissa("hrrr");
            kissa.Kehraa();

            Console.Read();
        }
    }
}