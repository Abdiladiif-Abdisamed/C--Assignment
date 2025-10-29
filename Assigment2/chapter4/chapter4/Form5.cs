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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            btnConvert.Click += btnConvert_Click;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double value))
            {
                MessageBox.Show("Please enter a valid number!");
                return;
            }

            if (Inches.SelectedItem == null || listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select both units (from and to).");
                return;
            }

            string from = Inches.SelectedItem.ToString();
            string to = listBox1.SelectedItem.ToString();
            double result = value;

            // Marka hore, value ka badal 'Inches'
            switch (from)
            {
                case "Feet":
                    result *= 12; // 1 foot = 12 inches
                    break;
                case "Yards":
                    result *= 36; // 1 yard = 36 inches
                    break;
            }

            // Kadib, u badal unit-ka la doonayo
            switch (to)
            {
                case "Feet":
                    result /= 12;
                    break;
                case "Yards":
                    result /= 36;
                    break;
            }

            // Natiijada
            lblResult.Text = $"{value} {from} = {Math.Round(result, 2)} {to}";
        }
    }
}
    

