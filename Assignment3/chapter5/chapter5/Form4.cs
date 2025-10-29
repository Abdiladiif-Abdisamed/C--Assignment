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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            try
            {
                // Akhri xogta laga soo galiyay textbox
                double startingNumber = double.Parse(textBox1.Text);
                double dailyIncreasePercent = double.Parse(textBox2.Text) / 100.0;
                int days = int.Parse(textBox3.Text);

                if (startingNumber < 0 || dailyIncreasePercent < 0 || days <= 0)
                {
                    MessageBox.Show("❌ Please enter positive values only.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double population = startingNumber;

                // Header
                listBox1.Items.Add("Day\tApproximate Population");
                listBox1.Items.Add("--------------------------------");

                // Xisaabinta tirada dadka maalmaha oo dhan
                for (int day = 1; day <= days; day++)
                {
                    listBox1.Items.Add($"{day}\t{population:F6}");
                    population += population * dailyIncreasePercent; // population growth
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("❌ Please enter valid numeric values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

