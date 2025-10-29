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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double totalCalories = double.Parse(textBox1.Text);
                double fatGrams = double.Parse(textBox2.Text);

                if (totalCalories <= 0 || fatGrams < 0)
                {
                    MessageBox.Show("Calories and fat grams must be greater than 0.");
                    return;
                }

                double caloriesFromFat = fatGrams * 9;

                if (caloriesFromFat > totalCalories)
                {
                    MessageBox.Show("Error: Calories from fat cannot be greater than total calories.");
                    return;
                }

                double percentageFromFat = (caloriesFromFat / totalCalories) * 100;

                label4.Text = "Calories from Fat: " + caloriesFromFat.ToString("0.##");
                label3.Text = "Percentage from Fat: " + percentageFromFat.ToString("0.##") + "%";

                // Haddii checkbox la xusho — muuji low/high fat status
                if (checkBox1.Checked)
                {
                    if (percentageFromFat < 30)
                    {
                        checkBox1.Text = "✅ This is a LOW-FAT food";
                        checkBox1.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        checkBox1.Text = "❌ This is a HIGH-FAT food";
                        checkBox1.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    // Haddii checkbox aan la hubin
                    checkBox1.Text = "Check if food is low-fat";
                    checkBox1.ForeColor = System.Drawing.Color.Black;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values.");
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Haddii aad rabto in wax dhacaan marka la hubiyo ama laga hubiyo
        }

    }
}

     

