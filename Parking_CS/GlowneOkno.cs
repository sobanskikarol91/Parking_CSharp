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
        List<Button> buttons = new List<Button>();

        public GlowneOkno()
        {
            InitializeComponent();
            CreateButtons();
        }

        void CreateButtons()
        {
            for (int r = 0; r < wiersze; r++)
            {
                for (int c = 0; c < kolumny; c++)
                {
                    int nr = r * kolumny + c;
                    Button newButton = new Button();
                    buttons.Add(newButton);
                    buttons[nr].BackColor = Color.Aqua;
                    buttons[nr].Size = new Size(50, 100);
                    buttons[nr].Location = new Point(wierszeOdstep+ r * 100, kolumnyOdstep+  c * 120);
                    Controls.Add(newButton);
                    buttons[nr].BringToFront();
                }
            }
        }

        private void GlowneOkno_Load(object sender, EventArgs e)
        {

        }
    }
}
