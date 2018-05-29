using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_CS
{
    class Sportowy : Samochod
    {
        int nitro;
        public Sportowy() { }
        public Sportowy(string marka, Parametry parametry) { }
        public override void StworzSamochod()
        {
            SportowyOkno  s = new SportowyOkno();
            s.ShowDialog();
        }
    }
}
