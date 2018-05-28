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
        public Slot(Button przycisk) { this.przycisk = przycisk; przycisk = new Button(); }
        public Samochod Samochod { get; set; }

        Button przycisk;
    }
}
