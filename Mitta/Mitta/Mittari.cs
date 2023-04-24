using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitta
{
    public class Mittari
    {
        private int _mitta;

        public Mittari()
        {
            _mitta = 0;
        }

        public void Lisaa()
        {
            if (_mitta < 5) 
            {
                _mitta++;
            }
        }

        public void Vahenna()
        {
            if (_mitta > 0) 
            {
                _mitta--;
            }
        }

        public int Mitta()
        { return _mitta; }

        public bool Taynna()
        { return _mitta == 5; }
    }
}
