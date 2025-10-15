using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assaiment1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
             try
            {
                // ⿡ Akhri lacagta cuntada uu user-ku galay
                double foodCharge = double.Parse(txtfood.Text);

                // ⿢ Xisaabi Tip (15%) iyo Tax (7%)
                double tip = foodCharge * 0.15;
                double tex = foodCharge * 0.07;

                // ⿣ Xisaabi Total
                double total = foodCharge + tip + tex;

                // ⿤ Soo bandhig natiijooyinka
                txttip.Text = tip.ToString("C");   // "C" waa currency format, tusaale $15.00
                txttex.Text = tex.ToString("C");
                txttotal.Text = total.ToString("C");
            }
            catch
            {
                MessageBox.Show("Please enter a valid number for the food charge!");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }

        }
    

