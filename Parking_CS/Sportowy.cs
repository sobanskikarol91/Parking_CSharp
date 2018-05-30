using System;
using System.Drawing;

namespace Parking_CS
{
    public partial class Sportowy : Samochod
    {
        public int Nitro { get; private set; }

        public Sportowy() : base()
        {
            Nitro = 0;
            InitializeComponent();
        }

        private void Sportowy_Load(object sender, EventArgs e)
        {
            this.nitroTxt.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
        }

        protected virtual void ZapiszDane()
        {
            base.ZapiszDane();
            Nitro = Convert.ToInt32(nitroTB.Text);
        }
    }
}
