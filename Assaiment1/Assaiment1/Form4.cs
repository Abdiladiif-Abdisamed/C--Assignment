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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Hel lacagta uu user-ku qoray
                double amount = double.Parse(txtamount.Text);

                // 2. Xisaabi canshuuraha
                double stateTax = amount * 0.04;   // 4% state tax
                double countyTax = amount * 0.02;  // 2% county tax
                double totalTax = stateTax + countyTax;
                double totalSale = amount + totalTax;

                // 3. Ku muuji natiijooyinka labels-ka
                txtstate.Text = "State Tax: $" + stateTax.ToString("0.00");
                txtcon.Text = "County Tax: $" + countyTax.ToString("0.00");
                txttotltax.Text = "Total Tax: $" + totalTax.ToString("0.00");
                txttotalsale.Text = "Total Sale: $" + totalSale.ToString("0.00");
            }
            catch
            {
                MessageBox.Show("Please enter a valid number.", "Input Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtamount.Clear();
            

            txtstate.Text = "State Tax:";
            txtcon.Text = "County Tax:";
            txttotltax.Text = "Total Tax:";
            txttotalsale.Text = "Total Sale:";
        }
    }
}