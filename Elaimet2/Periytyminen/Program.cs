using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elainluokat;

namespace Periytyminen
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa kissa = new Kissa(3, "Jorma", true);
            kissa.palautaKehraa();

            Console.Read();
        }
    }
}