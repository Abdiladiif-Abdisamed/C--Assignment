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
    public partial class Form14 : Form
    {
        // Variables
        int classA, classB, classC;
        double incomeA, incomeB, incomeC, totalRevenue;

        // Class prices
        const double PRICE_A = 15.0;
        const double PRICE_B = 12.0;
        const double PRICE_C = 9.0;
        public Form14()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtclassA.Text, out classA) &&
        int.TryParse(txtclassB.Text, out classB) &&
        int.TryParse(txtclassC.Text, out classC))
    {
        // Xisaabinta revenue
        incomeA = classA * PRICE_A;
        incomeB = classB * PRICE_B;
        incomeC = classC * PRICE_C;

        totalRevenue = incomeA + incomeB + incomeC;

        // Soo bandhig natiijada
        txtIncomeA.Text = incomeA.ToString("C2");
        txtIncomeB.Text = incomeB.ToString("C2");
        txtIncomeC.Text = incomeC.ToString("C2");
        txtTotal.Text = totalRevenue.ToString("C2");
    }
    else
    {
        MessageBox.Show("Please enter valid ticket numbers.");
    }
}

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtclassA.Clear();
            txtclassB.Clear();
            txtclassC.Clear();
            txtIncomeA.Clear();
            txtIncomeB.Clear();
            txtIncomeC.Clear();
            txtTotal.Clear();
            txtclassA.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        }
    }

