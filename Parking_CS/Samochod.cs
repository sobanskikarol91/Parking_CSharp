using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_CS
{
    // klasa abstrakcyjna
    abstract class Samochod
    {
        public Samochod() { Parametry = new Parametry(); }  // domyslny konstruktor z lista inicjalizacyjna
        public Samochod(string marka, Parametry parametry) { Parametry = new Parametry(); }
        public Parametry Parametry { get; set; }
        public abstract void StworzSamochod();
    }
}
