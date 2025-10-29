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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();

            // Ku dar click event button-ka
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Hel height (meters) iyo weight (kg)
                double height = double.Parse(textBox1.Text);
                double weight = double.Parse(textBox2.Text);

                if (height <= 0 || weight <= 0)
                {
                    MessageBox.Show("Height and weight must be positive numbers.");
                    return;
                }

                // Xisaabi BMI (metric)
                double bmi = weight / (height * height);

                // Go'aami status-ka BMI
                string status;
                if (bmi < 18.5)
                {
                    status = "Underweight";
                }
                else if (bmi <= 25)
                {
                    status = "Optimal weight";
                }
                else
                {
                    status = "Overweight";
                }

                // Muujiyo natiijada
                label3.Text = $"BMI: {bmi:F2} - {status}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for height and weight.");
            }
        }
    }
    }

