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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtloan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtinsurance_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtgas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtoil_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txttires_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtmain_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // Read monthly expenses from input textboxes
                    double loan = double.Parse(txtloan.Text);
                    double insurance = double.Parse(txtinsurance.Text);
                    double gas = double.Parse(txtgas.Text);
                    double oil = double.Parse(txtoil.Text);
                    double tires = double.Parse(txttires.Text);
                    double maintenance = double.Parse(txtmain.Text);

                    // Calculate totals
                    double totalMonthly = loan + insurance + gas + oil + tires + maintenance;
                    double totalAnnual = totalMonthly * 12;

                    // Display results in output textboxes
                    txtmonthly.Text = totalMonthly.ToString("F2");
                    txtanual.Text = totalAnnual.ToString("F2");
                }
                catch
                {
                    MessageBox.Show("Please enter valid numeric values for all fields.",
                                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

    }
}