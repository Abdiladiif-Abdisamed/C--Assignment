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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double mass, weight;

            // Hubi in user-ku galiyay tiro sax ah
            if (double.TryParse(txtMass.Text, out mass))
            {
                // Xisaabi miisaanka
                weight = mass * 9.8;

                // Qiimee miisaanka
                if (weight > 1000)
                {
                    lblResult.Text = $"Weight: {weight:F2} N — Too heavy!";
                }
                else if (weight < 10)
                {
                    lblResult.Text = $"Weight: {weight:F2} N — Too light!";
                }
                else
                {
                    lblResult.Text = $"Weight: {weight:F2} Newtons";
                }
            }
            else
            {
                // Haddii aan tiro sax ah la gelin
                MessageBox.Show("Please enter a valid number for mass.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

