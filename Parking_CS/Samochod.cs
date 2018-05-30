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
            ShowDialog();
        }

        private void okBTN_Click(object sender, EventArgs e)
        {
            ZapiszDane();
            Close();
        }

        // zapisujemy dane wprowadzone w oknie tworzenia samochodu
        protected virtual void ZapiszDane()
        {
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
