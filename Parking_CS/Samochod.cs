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
        string marka;
        Parametry parametry;
        //Texture tekstura;
        //Sprite sprite;

        public Samochod() { }  // domyslny konstruktor z lista inicjalizacyjna
        public Samochod(string marka, Parametry parametry) { }
        public abstract void StworzSamochod();
    }
}
