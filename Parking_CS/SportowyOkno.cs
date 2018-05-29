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
    public partial class SportowyOkno : SamochodOkno
    {
        public SportowyOkno()
        {
            InitializeComponent();
        }

        public SportowyOkno(Parametry a)
        {

        }

        private void SportowyOkno_Load(object sender, EventArgs e)
        {
            nitro.Font = new Font("Arial", 10, FontStyle.Bold);
        }
    }
}
