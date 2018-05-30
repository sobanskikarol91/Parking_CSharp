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
    public partial class Ciezarowy : Samochod
    {
        public int Zaladunek { get; private set; }
        public Ciezarowy()
        {
            InitializeComponent();
        }

        private void Ciezarowy_Load(object sender, EventArgs e)
        {
            zaladunekTB.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
        }

        protected virtual void ZapiszDane()
        {
            base.ZapiszDane();
            Zaladunek = Convert.ToInt32(zaladunekTB.Text);
        }
    }
}
