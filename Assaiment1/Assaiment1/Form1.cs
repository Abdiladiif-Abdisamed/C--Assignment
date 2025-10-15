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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String title, mnane, lname, fname;
            title = txttitle.Text;
            fname = txtfname.Text;
            mnane = txtmname.Text;
            lname = txtlname.Text;

            fname = title + " " + fname + " " + mnane + " " + lname;
            txtresult.Text = fname;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String fname, mnane, lname;
            fname = txtfname.Text;
            mnane = txtmname.Text;
            lname = txtlname.Text;

            fname =  fname + " " + mnane + " " + lname;
            txtresult.Text = fname;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String fname, mnane;
            fname = txtfname.Text;
            mnane = txtmname.Text;


            fname = fname + " " + mnane;
            txtresult.Text = fname;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String fname, mnane, lname,title;
            fname = txtfname.Text;
            mnane = txtmname.Text;
            lname = txtlname.Text;
            title = txttitle.Text;

            fname = fname + " " + mnane + " " + lname + " " + title;
            txtresult.Text = fname;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String lname, fname, mnane;
            lname = txtlname.Text;
            fname = txtfname.Text;
            mnane = txtmname.Text;
            

            fname = lname + " " + fname + " " + mnane;
            txtresult.Text = fname;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            String lname, fname;
            lname = txtlname.Text;
            fname = txtfname.Text;



            fname = lname + " " + fname;
            txtresult.Text = fname;

        }
    }
}
