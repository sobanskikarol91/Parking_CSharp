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
        Button wybranyPrzycisk; // zapamietujemy jaku przycisk wybral uzytkownik

        public GlowneOkno()
        {
            InitializeComponent();
            UtworzSloty(); 
            UkryjPanelSamochodow();
            napisStatystyki.Font = new Font("Arial", 14, FontStyle.Bold);
            iloscSamochodow.Font = new Font("Arial", 10, FontStyle.Bold);
            sr_masa.Font = new Font("Arial", 10, FontStyle.Bold);
            sr_konie_mech.Font = new Font("Arial", 10, FontStyle.Bold);
            sr_zuz_ben.Font = new Font("Arial", 10, FontStyle.Bold);
            sr_predkosc.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        void UkryjPanelSamochodow() // panel wyboru samochodow
        {
            panelSamochodow.Visible = false;
        }

        private void Sportowy_Click(object sender, EventArgs e)
        {
            wybranyPrzycisk.Image = ((Button)sender).Image;
            Form s = new SportowyOkno();
            s.ShowDialog();
        }

        private void Ciezarowy_Click(object sender, EventArgs e)
        {
            wybranyPrzycisk.Image = ((Button)sender).Image;
        }

        private void Osobowy_Click(object sender, EventArgs e)
        {
            wybranyPrzycisk.Image = ((Button)sender).Image;
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
                   // sloty.Add( new Slot(przycisk));
                    Controls.Add(przycisk);
                }
            }
        }

        void KlikniecieSlotu(object sender, EventArgs e)
        {
            wybranyPrzycisk = (Button)sender;  //  zapamietujemy wybrany przycisk
            panelSamochodow.Visible = true;
        }
    }
}
