using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_CS
{
    class Parametry
    {
        int Masa { get; }
        int Konie_mechaniczne { get; }
        int Predkosc { get; }
        int Zuzycie_benzyny { get; }

        public Parametry() { }
        public Parametry(int masa, int predkosc, int zurzycie_benzyny, int konie_mechaniczne)
        { Masa = masa; Predkosc = predkosc; Zuzycie_benzyny = zurzycie_benzyny; Konie_mechaniczne = konie_mechaniczne; }

        // przeciazenie operatora
        public static Parametry operator +(Parametry a, Parametry b)
        {
            return new Parametry(a.Masa + b.Masa, a.Predkosc + b.Predkosc,
                a.Zuzycie_benzyny + b.Zuzycie_benzyny, a.Konie_mechaniczne + b.Konie_mechaniczne);
        }
    }
}
