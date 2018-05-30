using System;
using System.Drawing;
using System.Windows.Forms;

namespace Parking_CS
{
    public partial class Samochod : Form
    {
        public Parametry Parametry { get; private set; }

        public Samochod()
        {
            Parametry = new Parametry();
            InitializeComponent();
        }

        public void StworzSamochod()
        {
            // wyswietlenie okna wprowadzania danych
            ShowDialog();
        }

        private void okBTN_Click(object sender, EventArgs e)
        {
            // zpisanie danych przy kliknieciu przycisku ok
            ZapiszDane();
            // zamkniecie okna
            Close();
        }

        // zapisujemy dane wprowadzone w oknie tworzenia samochodu, 
        // metoda jest virtualna poniewaz inne klasy beda implementowac ja inaczej.
        protected virtual void ZapiszDane()
        {
            // konwertujemy dane przechowywane w text boxach i za pomoca konstruktora Parametry przypisujemy nowy obiekt
            Parametry = new Parametry(
                Convert.ToInt32(masaTB.Text),
                Convert.ToInt32(predkoscTB.Text),
                Convert.ToInt32(kmTB.Text),
                Convert.ToInt32(zuzBenzTB.Text));
        }

        private void Samochod_Load(object sender, EventArgs e)
        {
            this.masaTxt.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            this.predkoscTxt.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            this.zuzBenzTxt.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            this.kmTxt.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
        }
    }
}
