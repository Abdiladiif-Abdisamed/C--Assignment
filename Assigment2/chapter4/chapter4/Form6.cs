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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            btnCalculate.Click += btnCalculate_Click; // event handler

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // hubi in la galiyo nambar sax ah
            if (!int.TryParse(textBox1.Text, out int books) || books < 0)
            {
                MessageBox.Show("Please enter a valid number of books.");
                return;
            }

            int points = 0;

            // go’aami dhibcaha
            if (books == 0)
                points = 0;
            else if (books == 1)
                points = 5;
            else if (books == 2)
                points = 15;
            else if (books == 3)
                points = 30;
            else if (books >= 4)
                points = 60;

            // soo bandhig natiijada
            lblResult.Text = $"You earned {points} points!";
        }
    }

    }
