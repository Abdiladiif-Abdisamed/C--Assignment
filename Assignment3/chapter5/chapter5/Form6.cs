using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter5
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            double risePerYear;

            // Hubi in textbox-ka uu sax yahay
            if (!double.TryParse(textBox1.Text, out risePerYear))
            {
                MessageBox.Show("Please enter a valid number for ocean rise per year.");
                return;
            }

            // Loop 1-10 sano
            for (int year = 1; year <= 10; year++)
            {
                double totalRise = year * risePerYear;
                listBox1.Items.Add($"Year {year}: {totalRise} mm");
            }
        }
    }
    }

