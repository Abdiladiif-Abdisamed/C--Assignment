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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Fahrenheit_Click(object sender, EventArgs e)
        {
            try
            {
                double fahrenheit = Convert.ToDouble(txttem.Text);
                double celsius = 5.0 / 9.0 * (fahrenheit - 32);
                txtresult.Text = celsius + " °C = " + fahrenheit.ToString("F2") + " °F";
            }
            catch
            {
                MessageBox.Show("Please enter a valid number!", "Error");
        }
        }

        private void Celsius_Click(object sender, EventArgs e)
        {
                 try
            {
                double celsius = Convert.ToDouble(txttem.Text);
                double fahrenheit = (9.0 / 5.0 * celsius) + 32;
                txtresult.Text = celsius + " °C = " + fahrenheit.ToString("F2") + " °F";
            }
            catch
            {
                MessageBox.Show("Please enter a valid number!", "Error");
            }
        }

        }
    }

