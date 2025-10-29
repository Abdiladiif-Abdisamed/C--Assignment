using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter4
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            btnCalculate.Click += btnCalculate_Click; // Event handler
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = int.Parse(textBox1.Text);
                double pricePerPackage = 99.0;
                double discountRate = 0.0;

                // Go'aami discount-ka ku saleysan tirada
                if (quantity >= 10 && quantity <= 19)
                    discountRate = 0.20;
                else if (quantity >= 20 && quantity <= 49)
                    discountRate = 0.30;
                else if (quantity >= 50 && quantity <= 99)
                    discountRate = 0.40;
                else if (quantity >= 100)
                    discountRate = 0.50;

                // Xisaabi total
                double subtotal = quantity * pricePerPackage;
                double discountAmount = subtotal * discountRate;
                double totalAfterDiscount = subtotal - discountAmount;

                // Soo bandhig natiijada
                lblResult.Text =
                    $"Subtotal: ${subtotal:F2}\n" +
                    $"Discount: {discountRate * 100}% (${discountAmount:F2})\n" +
                    $"Total After Discount: ${totalAfterDiscount:F2}";
            }
            catch
            {
                MessageBox.Show("Fadlan geli tiro sax ah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}