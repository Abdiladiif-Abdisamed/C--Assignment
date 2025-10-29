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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int pennies = int.Parse(textBox1.Text);
                int nickels = int.Parse(textBox2.Text);
                int dimes = int.Parse(textBox3.Text);
                int quarters = int.Parse(textBox4.Text);

                if (pennies < 0 || nickels < 0 || dimes < 0 || quarters < 0)
                {
                    MessageBox.Show("Please enter positive numbers only.");
                    return;
                }

                double total = pennies * 0.01 + nickels * 0.05 + dimes * 0.10 + quarters * 0.25;

                if (Math.Abs(total - 1.0) < 0.001)
                {
                    label3.Text = "Congratulations! You made exactly $1.00!";
                }
                else if (total < 1.0)
                {
                    label3.Text = $"The total is ${total:F2}. You entered less than $1.00.";
                }
                else
                {
                    label3.Text = $"The total is ${total:F2}. You entered more than $1.00.";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for all coins.");
            }
        }
    }
}
    

