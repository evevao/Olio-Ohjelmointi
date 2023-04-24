using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelkaKirja
{
    public class Velka
    {
        private double _saldo;
        private double _korkoProsentti;

        public Velka(double saldoAlussa, double korkoProsentti) 
        {
            _saldo = saldoAlussa;
            _korkoProsentti = korkoProsentti;
        }

        public void TulosSaldo()
        { 
            Console.WriteLine("Saldo: " + _saldo);
        }

        public void OdotaVuosi() 
        { 
            _saldo = _saldo * (1 + (_korkoProsentti/100));
        }
    }
}