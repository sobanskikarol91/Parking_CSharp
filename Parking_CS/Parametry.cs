using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_CS
{
    class Parametry
    {
        public int Masa { get; }
        public int Konie_mechaniczne { get; }
        public int Predkosc { get; }
        public int Zuzycie_benzyny { get; }

        public Parametry() { Masa = 0; Konie_mechaniczne = 0; Predkosc = 0; Zuzycie_benzyny = 0;} // ustawiamy wszystko na 0
        public Parametry(int masa, int predkosc, int zurzycie_benzyny, int konie_mechaniczne)
        { Masa = masa; Predkosc = predkosc; Zuzycie_benzyny = zurzycie_benzyny; Konie_mechaniczne = konie_mechaniczne; }

        // przeciazenie operatora
        public static Parametry operator +(Parametry a, Parametry b)
        {
            return new Parametry(a.Masa + b.Masa, a.Predkosc + b.Predkosc,
                a.Zuzycie_benzyny + b.Zuzycie_benzyny, a.Konie_mechaniczne + b.Konie_mechaniczne);
        }

        // przeciazenie operatora dzielenia przez skalar
        public static Parametry operator /(Parametry p, int s)
        {
            // w przypadku dzielenia przez zero
            if (s == 0) return new Parametry(0, 0, 0, 0);

            return new Parametry(p.Masa / s, p.Predkosc / s, p.Zuzycie_benzyny / s, p.Konie_mechaniczne / s);
        }
    }
}
