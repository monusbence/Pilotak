using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilotak
{
    internal class Versenyzők
    {
        string nev;
        string születési_dátum;
        string nemzetiség;
        int rajtszám;

        public Versenyzők(string nev, string születési_dátum, string nemzetiség, int rajtszám)
        {
            this.nev = nev;
            this.születési_dátum = születési_dátum;
            this.nemzetiség = nemzetiség;
            this.rajtszám = rajtszám;
        }

        public string Nev { get => nev;}
        public string Születési_dátum { get => születési_dátum;}
        public string Nemzetiség { get => nemzetiség; }
        public int Rajtszám { get => rajtszám; }
    }
}
