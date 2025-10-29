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
    public partial class Form12 : Form
    {
        Dictionary<string, int> workshopDays = new Dictionary<string, int>()
        {
            {"Handling Stress", 3 },
            {"Time Management", 3 },
            {"Supervision Skills", 3 },
            {"Negotiation", 5 },
            {"How to Interview", 1 }
        };

        Dictionary<string, double> workshopFee = new Dictionary<string, double>()
        {
            {"Handling Stress", 1000 },
            {"Time Management", 800 },
            {"Supervision Skills", 1500 },
            {"Negotiation", 1300 },
            {"How to Interview", 500 }
        };

        Dictionary<string, double> locationFee = new Dictionary<string, double>()
        {
            {"Austin", 150 },
            {"Chicago", 225 },
            {"Dallas", 175 },
            {"Orlando", 300 },
            {"Phoenix", 175 },
            {"Raleigh", 150 }
        };
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null || listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a workshop and a location.");
                return;
            }

            string workshop = listBox2.SelectedItem.ToString().Trim();
            string location = listBox1.SelectedItem.ToString().Trim();

            int days = workshopDays[workshop];
            double regFee = workshopFee[workshop];
            double lodFeePerDay = locationFee[location];

            double lodging = days * lodFeePerDay;
            double total = regFee + lodging;

            label4.Text = "Registration: $" + regFee;
            label5.Text = "Lodging: $" + lodging;
            label3.Text = "Total: $" + total;
        }
    }

}
    

