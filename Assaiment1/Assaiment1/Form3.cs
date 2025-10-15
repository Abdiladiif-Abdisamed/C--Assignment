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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double speed = double.Parse(txtspeed.Text);
            double distance = speed * 5;
            txtdis.Text = distance.ToString("F2") + " miles";
        

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double speed = double.Parse(txtspeed.Text);
            double distance = speed * 8;
            txtdis.Text = distance.ToString("F2") + " miles";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double speed = double.Parse(txtspeed.Text);
            double distance = speed * 12;
            txtdis.Text = distance.ToString("F2") + " miles";
            
        }
    }
}
