using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assaiment1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // ⿡ Hel qiimaha uu user-ku geliyay (Replacement Cost)
                double replacementCost = double.Parse(txtresplace.Text);

                // ⿢ Xisaabi 80% (0.8) si loo helo minimum insurance
                double insurance = replacementCost * 0.8;

                // ⿣ Soo bandhig natiijada gudaha label-ka
                txtres.Text = "$" + insurance.ToString("N2");
            }
            catch
            {
                // ⿤ Haddii user-ku geliyo wax khaldan
                MessageBox.Show("Please enter a valid number for the replacement cost.");
            }
        }
    }
}