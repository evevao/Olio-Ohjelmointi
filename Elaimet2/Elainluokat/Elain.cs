﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elainluokat
{
    public class Elain
    {
        private int ika;
        private string nimi;
        private bool lihansyoja;

        public Elain(int ika, string nimi, bool lihansyoja)
        { }

        public bool asetaElaimenIka(int ika)
        {
            if (ika < 0)
            {
                return false;
            }
            else
            {
                this.ika = ika;
                return true;
            }
        }

        public int palautaElaimenIka()
        {
            if (ika < 0)
            {
                return 0;
            }
            else
            {
                return this.ika;
            }
        }

        public bool asetaElaimenNimi(string nimi) 
        {
            this.nimi = nimi;
            return true;
        }

        public string palautaElaimenNimi()
        { 
            return this.nimi; 
        }
        public void AsetaOnLihansyoja(bool lihansyoja)
        {
            Console.WriteLine("Eläin on lihansyöjä: " + lihansyoja);
            this.lihansyoja = lihansyoja;
        }
        public bool palautaOnLihansyoja()
        {
            return this.lihansyoja;
        }
    }
}
