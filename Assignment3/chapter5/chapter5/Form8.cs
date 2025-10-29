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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            button1.Click += button1_Click; // Event handler button
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Nadiifi listbox
            double tuition;

            // Hubi in user uu geliyey tiro sax ah
            if (!double.TryParse(textBox1.Text, out tuition))
            {
                MessageBox.Show("Please enter a valid tuition amount!");
                return;
            }

            double increaseRate = 0.02; // 2% sanadkiiba
            for (int year = 1; year <= 5; year++)
            {
                tuition += tuition * increaseRate; // Ku dar 2%
                listBox1.Items.Add($"Year {year}: ${tuition:F2}");
            }
        }
    }
}
    

