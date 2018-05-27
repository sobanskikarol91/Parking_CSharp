﻿using System;
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
        List<Button> buttons = new List<Button>();



        public GlowneOkno()
        { 
            InitializeComponent();
            UtworzPrzyciski();
            UkryjPanelSamochodow();
        }

        void UkryjPanelSamochodow() // panel wyboru samochodow
        {
            panelSamochodow.Visible = false;
        }

        void UtworzPrzyciski()
        {
            for (int w = 0; w < wiersze; w++)
            {
                for (int k = 0; k < kolumny; k++)
                {
                    int nr = w * kolumny + k;
                    Button przycisk = new Button();
                  //  przycisk.FlatStyle = FlatStyle.Flat; // flat aby nie bylo ramki dookola przycisku
                    przycisk.BackColor = Color.Black;
                    przycisk.Size = new Size(50, 100);
                    przycisk.Location = new Point(wierszeOdstep+ w * 100, kolumnyOdstep+  k * 120);
                    przycisk.Click += new EventHandler(this.KlikniecieSlotu);
                    buttons.Add(przycisk);
                    Controls.Add(przycisk);
                    buttons[nr].BringToFront();
                }
            }
        }

        void KlikniecieSlotu(object sender, EventArgs e)
        {
            panelSamochodow.Visible = true;
        }

        private void GlowneOkno_Load(object sender, EventArgs e)
        {

        }
    }
}