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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void BMI_Click(object sender, EventArgs e)
        {
            try
            {
                // Hel xogta user-ka
                double weight = Convert.ToDouble(txtweight.Text);
                double height = Convert.ToDouble(txtheihgt.Text);

                // Xisaab BMI
                double bmi = weight * 703 / (height * height);

                // Soo bandhig natiijada
                txtres.Text = "Your BMI is: " + bmi.ToString("F2");

                // Fariin dheeri ah oo tilmaamaysa xaaladda jirka
                if (bmi < 18.5)
                    txtres.Text += " (Underweight)";
                else if (bmi >= 18.5 && bmi < 25)
                    txtres.Text += " (Normal weight)";
                else if (bmi >= 25 && bmi < 30)
                    txtres.Text += " (Overweight)";
                else
                    txtres.Text += " (Obese)";
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers!", "Error");
            }
        }
    }
}