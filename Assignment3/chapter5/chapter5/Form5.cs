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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            button1.Click += button1_Click; // Ku dar event handler
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Nadiifi listbox-ka
            try
            {
                int days = int.Parse(textBox1.Text); // Tirada maalmaha
                if (days <= 0)
                {
                    MessageBox.Show("Fadlan gali tiro maalin ah oo sax ah.");
                    return;
                }

                long pay = 1; // Penny-ka maalinta 1
                long totalPay = 0;

                for (int i = 1; i <= days; i++)
                {
                    listBox1.Items.Add($"Day {i}: {pay} pennies");
                    totalPay += pay;
                    pay *= 2; // Ku labanlaab maalinta xigta
                }

                listBox1.Items.Add($"Total pay: {totalPay} pennies (${totalPay / 100.0:F2})");
            }
            catch (FormatException)
            {
                MessageBox.Show("Fadlan gali tiro sax ah.");
            }
        }
    }
    }

