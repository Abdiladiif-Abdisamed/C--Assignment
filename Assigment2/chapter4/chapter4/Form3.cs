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
    public partial class Form3 : Form
    {
        public Form3()
        {
           
            InitializeComponent();
            button1.Click += button1_Click; // ku xidhi button-ka event-ka
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Qaado qiimaha laga geliyay textbox-yada
                int month = int.Parse(textBox1.Text);
                int day = int.Parse(textBox3.Text);
                int year = int.Parse(textBox2.Text);

                // Xisaabi haddii ay "magic" tahay
                if (month * day == year)
                {
                    lblResult.Text = $"The date {month}/{day}/{year} is a MAGIC DATE!";
                    lblResult.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblResult.Text = $"The date {month}/{day}/{year} is NOT magic.";
                    lblResult.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch
            {
                MessageBox.Show("Please enter valid numeric values for Month, Day, and Year.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

