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
    public partial class SamochodOkno : Form
    {
        public SamochodOkno()
        {
            InitializeComponent();
        }

        private void SamochodOkno_Load(object sender, EventArgs e)
        {
            masa.Font = new Font("Arial", 10, FontStyle.Bold);
            konieMech.Font = new Font("Arial", 10, FontStyle.Bold);
            zuzucieBenzyny.Font = new Font("Arial", 10, FontStyle.Bold);
            predkosc.Font = new Font("Arial", 10, FontStyle.Bold);
        }
    }
}
