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
    public partial class CiezarowyOkno : SamochodOkno
    {
        public CiezarowyOkno()
        {
            InitializeComponent();
        }

        private void CiezarowyOkno_Load(object sender, EventArgs e)
        {
            zaladunek.Font = new Font("Arial", 10, FontStyle.Bold);
        }
    }
}
