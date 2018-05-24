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

        Parametry() { }
        Parametry(int masa, int predkosc, int zurzycie_benzyny, int konie_mechaniczne)
        { Masa = masa; Predkosc = predkosc; Zuzycie_benzyny = zurzycie_benzyny; Konie_mechaniczne = konie_mechaniczne; }
    }
}
