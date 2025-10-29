using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }

        private void label1_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Please enter positive numbers for speed and hours.");
                    return;
                }

                string filePath = "DistanceReport.txt";

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Distance Report");
                    writer.WriteLine("----------------------");
                    writer.WriteLine($"Speed: {speed} miles/hour");
                    writer.WriteLine($"Hours: {hours}");
                    writer.WriteLine();

                    for (int hour = 1; hour <= hours; hour++)
                    {
                        double distance = speed * hour;
                        writer.WriteLine($"After hour {hour}, the vehicle has traveled {distance} miles.");
                    }

                    writer.WriteLine();
                    writer.WriteLine($"Total Distance: {speed * hours} miles");
                }

                label2.Text = $"✅ File saved: {Path.GetFullPath(filePath)}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
    }

