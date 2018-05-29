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
    public partial class GlowneOkno : Form
    {
        int wiersze = 4, kolumny = 4,
            kolumnyOdstep = 20, wierszeOdstep = 20;

        List<Slot> sloty = new List<Slot>();
        Slot wybranySlot; // zapamietujemy jaki przycisk wybral uzytkownik
        int ileZaparkowanych;

        public GlowneOkno()
        {
            InitializeComponent();
            UtworzSloty();
            PokazPanelSamochodow(false);
            UstawNapisy();
            UaktualnijStatystyki();
        }

        void UstawNapisy()
        {
            napisStatystyki.Font = new Font("Arial", 14, FontStyle.Bold);
            ileZaparkowanychTxt.Font = new Font("Arial", 10, FontStyle.Bold);
            masaTxt.Font = new Font("Arial", 10, FontStyle.Bold);
            konieMechTxt.Font = new Font("Arial", 10, FontStyle.Bold);
            zuzBenTxt.Font = new Font("Arial", 10, FontStyle.Bold);
            predkoscTxt.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        void PokazPanelSamochodow(bool pokaz) // panel wyboru samochodow
        {
            panelSamochodow.Visible = pokaz;
        }

        private void Sportowy_Click(object sender, EventArgs e)
        {
            wybranySlot.Przycisk.Image = ((Button)sender).Image;
            Form s = new SportowyOkno();
            s.ShowDialog();
            wybranySlot.ZajmijSlot(new Sportowy());
            PokazPanelSamochodow(false);
            wybranySlot.Przycisk.ForeColor = Color.Black;
        }

        private void Ciezarowy_Click(object sender, EventArgs e)
        {

        }

        private void Osobowy_Click(object sender, EventArgs e)
        {

        }

        void Zaparkuj(Button wybranyRodzajSamochodu)
        {
            // zmiania koloru obwodki
            PokazPanelSamochodow(true);
            ileZaparkowanych++;
        }

        private void GlowneOkno_Load(object sender, EventArgs e)
        {

        }

        void Wyparkuj(Button wybranyRodzajSamochodu)
        {
            wybranySlot.Przycisk.Image = null;
            wybranySlot.ZwolnijSlot();
            ileZaparkowanych--;
        }

        void UtworzSloty()
        {
            for (int w = 0; w < wiersze; w++)
            {
                for (int k = 0; k < kolumny; k++)
                {
                    int nr = w * kolumny + k;
                    Button przycisk = new Button();
                    przycisk.FlatStyle = FlatStyle.Flat; // flat aby nie bylo ramki dookola przycisku
                    przycisk.BackColor = Color.Black;
                    przycisk.Size = new Size(50, 100);
                    przycisk.Location = new Point(wierszeOdstep + w * 100, kolumnyOdstep + k * 120);
                    przycisk.Click += new EventHandler(this.KlikniecieSlotu);
                    przycisk.BringToFront();
                    przycisk.Tag = nr;  // zapamietujemy nr aby pozniej szybko znalezc przycisk na liscie slotow
                    sloty.Add(new Slot(przycisk));
                    Controls.Add(przycisk);
                }
            }
        }

        void KlikniecieSlotu(object sender, EventArgs e)
        {
            // zapamietaj klikniety slot
            Button przycisk = (Button)sender;
            int nrSlotu = Convert.ToInt32(przycisk.Tag);
            wybranySlot = sloty[nrSlotu];

            // zmiania koloru obwodki
            przycisk.ForeColor = Color.Red;
            // parkowanie czy wypoarkowanie
            if (wybranySlot.CzySlotWolny()) Zaparkuj((Button)sender);
            else Wyparkuj((Button)sender);
        }

        void UaktualnijStatystyki()
        {
            Parametry statystyki = new Parametry();

            // dodajemy wszystkie parametry samochodow do siebie
            for (int i = 0; i < sloty.Count; i++)
                if (!sloty[i].CzySlotWolny()) // jezeli jest zajetyp rzez samochod do dodajemy parametry
                    statystyki += sloty[i].Samochod.Parametry;

            if (ileZaparkowanych > 0)
                statystyki /= ileZaparkowanych;

            ileZaparkowanychTxt.Text = "zaparkowane samochody: " + ileZaparkowanych + "/" + sloty.Count;
            masaTxt.Text = "Sr. masa: " + statystyki.Masa;
            predkoscTxt.Text = "Sr. predkosc: " + statystyki.Predkosc;
            konieMechTxt.Text = "Sr. km: " + statystyki.Konie_mechaniczne;
            zuzBenTxt.Text = "Sr. zuz. benz.: " + statystyki.Zuzycie_benzyny;
        }
    }
}
