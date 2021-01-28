using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThrowDice
{
    public partial class frmMain : Form
    {
        int sideSelect;
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbD6.Checked) {
                sideSelect = 7;
            }
            else if (rbD10.Checked) {
                sideSelect = 11;
            }
            else //D20 is selected
            {
                sideSelect = 21;
            }
            Random resultThrow = new Random();
            lblResult.Text = Convert.ToString(resultThrow.Next(1, sideSelect));
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Bernard, just for fun.");
        }
    }
}
