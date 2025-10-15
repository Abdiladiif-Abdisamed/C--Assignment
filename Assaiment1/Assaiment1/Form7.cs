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
    public partial class Form7 : Form
        
    {
        String sentence = "";
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void btnspace_Click(object sender, EventArgs e)
        {
            sentence += " ";
            txtsentence.Text = sentence;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            sentence = "";
            txtsentence.Clear();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void btni_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            sentence += " " + btn.Text;
            txtsentence.Text = sentence.Trim();
        }

        private void btnlike_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            sentence += " " + btn.Text;
            txtsentence.Text = sentence.Trim();
        }

        private void btnto_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            sentence += " " + btn.Text;
            txtsentence.Text = sentence.Trim();
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            sentence += " " + btn.Text;
            txtsentence.Text = sentence.Trim();
        }

        private void btnfootball_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            sentence += " " + btn.Text;
            txtsentence.Text = sentence.Trim();
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            sentence += " " + btn.Text;
            txtsentence.Text = sentence.Trim();
        }
    }
}
