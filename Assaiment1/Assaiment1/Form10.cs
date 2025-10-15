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
    public partial class Form10 : Form
    {
        int totalCalories = 0;

        // Calories for each fruit
        int bananaCalories = 105;
        int appleCalories = 95;
        int orangeCalories = 62;
        int pearCalories = 100;


        public Form10()
        {
            InitializeComponent();
              UpdateTotal();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            totalCalories += orangeCalories;
            UpdateTotal();

        }

        private void txtres_TextChanged(object sender, EventArgs e)
        {
           // txtres.Text = totalCalories.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            totalCalories += bananaCalories;
            UpdateTotal();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            totalCalories += appleCalories;
            UpdateTotal();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            totalCalories += pearCalories;
            UpdateTotal();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            totalCalories = 0;
            UpdateTotal();

        }
        private void UpdateTotal()
        {
            txtresult.Text = "Total Calories:" + totalCalories;
        }

        private void lblresult_Click(object sender, EventArgs e)
        {
           

        }
    }
}
