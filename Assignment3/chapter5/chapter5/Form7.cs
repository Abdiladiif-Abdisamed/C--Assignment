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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            button1.Click += button1_Click; // Event handler
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Nadiifi listbox-ka marka la click gareeyo

            double caloriesPerMinute = 3.9; // default
            double userInput;

            // Haddii user geliyo value textbox-ka, isticmaalkiisa
            if (double.TryParse(textBox1.Text, out userInput))
            {
                caloriesPerMinute = userInput;
            }

            int[] minutes = { 10, 15, 20, 25, 30 };

            foreach (int min in minutes)
            {
                double caloriesBurned = min * caloriesPerMinute;
                listBox1.Items.Add($"{min} minutes: {caloriesBurned:F2} calories");
            }
        }
    }
    }

