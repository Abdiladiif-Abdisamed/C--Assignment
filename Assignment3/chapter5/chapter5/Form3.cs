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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            bntcalcolate.Click += bntcalcolate_Click;
        }

        private void bntcalcolate_Click(object sender, EventArgs e)
        {
            // Nadiifi listBox-ka hore
            txtdisplayresult.Items.Clear();

            // Ku dar cinwaanka miiska
            txtdisplayresult.Items.Add("Celsius\tFahrenheit");
            txtdisplayresult.Items.Add("---------------------");

            // Loop 0 ilaa 20 Celsius
            for (int c = 0; c <= 20; c++)
            {
                double f = (9.0 / 5.0) * c + 32;
                txtdisplayresult.Items.Add($"{c}°C\t{f:F1}°F");
            }
        }
    }
}
    

