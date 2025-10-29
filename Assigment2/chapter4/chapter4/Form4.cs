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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }



        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnMix_Click(object sender, EventArgs e)
        {
            string color1 = "";
            string color2 = "";

            // Get first color selection
            if (Red1.Checked) color1 = "red";
            else if (Blue1.Checked) color1 = "blue";
            else if (yellow1.Checked) color1 = "yellow";

            // Get second color selection
            if (Red2.Checked) color2 = "red";
            else if (Blue2.Checked) color2 = "blue";
            else if (yellow2.Checked) color2 = "yellow";

            // Validate selection
            if (string.IsNullOrEmpty(color1) || string.IsNullOrEmpty(color2))
            {
                MessageBox.Show("Please select two colors.");
                return;
            }

            // Same color
            if (color1 == color2)
            {
                this.BackColor = GetColor(color1);
                lblresult.Text = "Result: " + color1;
                return;
            }

            // Mix colors
            if ((color1 == "red" && color2 == "blue") || (color1 == "blue" && color2 == "red"))
            {
                this.BackColor = Color.Purple;
                lblresult.Text = "Result: Purple";
            }
            else if ((color1 == "red" && color2 == "yellow") || (color1 == "yellow" && color2 == "red"))
            {
                this.BackColor = Color.Orange;
                lblresult.Text = "Result: Orange";
            }
            else if ((color1 == "blue" && color2 == "yellow") || (color1 == "yellow" && color2 == "blue"))
            {
                this.BackColor = Color.Green;
                lblresult.Text = "Result: Green";
            }
        }

        private Color GetColor(string name)
        {
            switch (name)
            {
                case "red":
                    return Color.Red;
                case "blue":
                    return Color.Blue;
                case "yellow":
                    return Color.Yellow;
                default:
                    return this.BackColor;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}




