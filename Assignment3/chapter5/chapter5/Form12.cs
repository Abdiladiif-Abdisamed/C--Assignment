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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hubi in user-ka uu geliyey number sax ah
            if (int.TryParse(textBox1.Text, out int n))
            {
                if (n < 0)
                {
                    MessageBox.Show("Please enter a nonnegative integer.", "Error");
                    textBox1.Clear();
                    textBox1.Focus();
                    return;
                }

                long factorial = 1;

                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }

                label2.Text = $"{n}! = {factorial}";
            }
            else
            {
                MessageBox.Show("Please enter a valid number!", "Error");
                textBox1.Clear();
                textBox1.Focus();
            }
        }
    }
}
    

