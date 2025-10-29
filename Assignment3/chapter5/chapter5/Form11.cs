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
    public partial class Form11 : Form
    {
        private int randomNumber; // Random number-ka la abuurayo
        private int guessCount;   // Tirada isku dayada
        private Random rand = new Random();

        public Form11()
        {
            InitializeComponent();
            StartNewGame();
        }

        // Function si loo bilaabo game cusub
        private void StartNewGame()
        {
            randomNumber = rand.Next(1, 101); // 1 ilaa 100
            guessCount = 0;
            label2.Text = "Result";
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int userGuess))
            {
                guessCount++;

                if (userGuess > 10)
                {
                    label2.Text = "Too high, try again.";
                }
                else if (userGuess < 10)
                {
                    label2.Text = "Too low, try again.";
                }
                else // userGuess == 10
                {
                    label2.Text = $"Congratulations! You guessed it in {guessCount} tries!";
                    guessCount = 0; // Reset tirada isku dayga
                }

                textBox1.Clear();
                textBox1.Focus();
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