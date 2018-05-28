using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking_CS
{
    class Slot : Form
    {
        bool wolny = true;
        public Samochod Samochod { get; private set; }
        public Slot(Button przycisk) { this.Przycisk = przycisk; przycisk = new Button(); }

        public Button Przycisk { get; }
        public void ZwolnijSlot() { Samochod = null; wolny = true; }
        public bool CzySlotWolny() { return wolny; }
        public void ZajmijSlot(Samochod samochod) { this.Samochod = samochod; wolny = false; }
    }
}
