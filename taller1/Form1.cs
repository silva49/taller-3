using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            double area;
            area = Math.PI * (double.Parse(txtradio.Text)*double.Parse(txtradio.Text));
            lbltotal.Text = area.ToString();
        }
    }
}
