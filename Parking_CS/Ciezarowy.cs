using System;
using System.Drawing;

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
            // modyfikujemy czcionke przy wczytywaniu okna
            zaladunekTB.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        protected virtual void ZapiszDane()
        {
            base.ZapiszDane();
            Zaladunek = Convert.ToInt32(zaladunekTB.Text);
        }
    }
}
