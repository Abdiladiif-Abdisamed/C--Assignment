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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1: Read input from user
                double seconds = double.Parse(textBox1.Text);

                if (seconds < 0)
                {
                    MessageBox.Show("Please enter a positive number of seconds.", "Input Error");
                    return;
                }

                // Step 2: Calculate minutes, hours, and days
                double minutes = seconds / 60;
                double hours = seconds / 3600;
                double days = seconds / 86400;

                // Step 3: Display results
                label3.Text = $"Minutes: {minutes:0.##}";
                label4.Text = $"Hours: {hours:0.##}";
                label5.Text = $"Days: {days:0.##}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric value for seconds.", "Error");
            }
        }
    }
}
    

