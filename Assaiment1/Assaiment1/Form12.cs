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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Display_Click(object sender, EventArgs e)
        {
            try
            {
                // Get user input
                double squareFeet = double.Parse(txtsquare.Text);
                double pricePerGallon = double.Parse(txtprice.Text);

                // Constants
                const double SQ_FEET_PER_GALLON = 115.0;
                const double HOURS_PER_GALLON = 8.0;
                const double LABOR_RATE = 20.0;

                // Calculations
                double gallonsRequired = Math.Ceiling(squareFeet / SQ_FEET_PER_GALLON);
                double hoursRequired = gallonsRequired * HOURS_PER_GALLON;
                double paintCost = gallonsRequired * pricePerGallon;
                double laborCharges = hoursRequired * LABOR_RATE;
                double totalCost = paintCost + laborCharges;

                // Display results in TextBoxes
                txtgallons.Text = gallonsRequired.ToString("F0");
                txthours.Text = hoursRequired.ToString("F2");
                txtpaintcost.Text = paintCost.ToString("F2");
                txtlabor.Text = laborCharges.ToString("F2");
                txttotalcost.Text = totalCost.ToString("F2");
            }
            catch
            {
                MessageBox.Show("Please enter valid numeric values.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txttotalcost_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear input fields and labels
            txtsquare.Clear();
            txtpaintcost.Clear();
            txtgallons.Clear();
            txthours.Clear();
            txtpaintcost.Clear();
            txtlabor.Clear();
            txttotalcost.Clear();
            txtprice.Clear();
            
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            //Magacyada bilowga ah ee TextBox-yada natiijada
            txtgallons.Text = "Gallons Required";
            txthours.Text = "Hours Required";
            txtpaintcost.Text = "Paint Cost";
            txtlabor.Text = "Labor Charges";
            txttotalcost.Text = "Total Cost";
        }
    }
}