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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double speed = double.Parse(textBox1.Text);
                int hours = int.Parse(textBox2.Text);

                if (speed <= 0 || hours <= 0)
                {
                    MessageBox.Show("Please enter positive values for speed and hours.");
                    return;
                }

                listBox1.Items.Clear(); // Nadiifi listbox-ka kahor xisaabinta

                // Loop - xisaabi distance-ka saacad kasta
                for (int hour = 1; hour <= hours; hour++)
                {
                    double distance = speed * hour;
                    listBox1.Items.Add($"After hour {hour}, the vehicle has traveled {distance} miles.");
                }

                label2.Text = $"Total distance after {hours} hours: {speed * hours} miles";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for both fields.");
            }
        }
    }
}
    

