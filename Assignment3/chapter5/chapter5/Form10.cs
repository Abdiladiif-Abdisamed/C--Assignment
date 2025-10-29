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
    public partial class Form10 : Form
    {
        // Variables global ah si loo keydiyo laba number
        private int number1;
        private int number2;
        private Random rand = new Random();

        public Form10()
        {
            InitializeComponent();
            GenerateProblem(); // Abuuro problem kii ugu horeeyay marka form-ka la furo
        }

        // Function-ka abuura laba number cusub oo random ah
        private void GenerateProblem()
        {
            number1 = rand.Next(100, 501); // 100 ilaa 500
            number2 = rand.Next(100, 501);

            label1.Text = $"{number1} + {number2} = ?";
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int userAnswer))
            {
                if (userAnswer == number1 + number2)
                {
                    label2.Text = "Correct!";
                }
                else
                {
                    label2.Text = $"Incorrect! Correct answer: {number1 + number2}";
                }

                GenerateProblem(); // Abuuro problem cusub
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