using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soitin
{
    public class Pilli
    {
        private string _aani;

        public Pilli(string pillinAani)
        {
            _aani = pillinAani;
        }

        public void Soi()
        {
            Console.WriteLine(_aani);
        }
    }

}
