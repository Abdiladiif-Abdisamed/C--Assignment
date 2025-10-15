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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double propertyValue, tax;

            // Hubi in userka uu geliyay tiro sax ah
            if (double.TryParse(txtvalue.Text, out propertyValue))
            {
                // Xisaabinta Tax
                tax = (propertyValue / 100) * 0.64;

                // Soo bandhig natiijada
                txttax.Text = tax.ToString("C2"); // "C2" = Currency format
            }
            else
            {
                MessageBox.Show("Please enter a valid property value.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
              txtvalue.Clear();
            txttax.Clear();
            txtvalue.Focus();
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
                this.Close();
        
        }

        private void button2_Click()
        {

        }

        private void button3_Click()
        {

        }
   
    }
}
