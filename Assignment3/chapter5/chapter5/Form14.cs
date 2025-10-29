using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter5
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open file dialog
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.Title = "Select Random Numbers File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;

                try
                {
                    // Clear previous items
                    listBox1.Items.Clear();

                    // Read all lines from file
                    string[] lines = File.ReadAllLines(filePath);
                    List<int> numbers = new List<int>();

                    foreach (string line in lines)
                    {
                        if (int.TryParse(line, out int num))
                        {
                            numbers.Add(num);
                            listBox1.Items.Add(num);
                        }
                    }

                    // Calculate total and count
                    int total = 0;
                    foreach (int n in numbers)
                        total += n;

                    int count = numbers.Count;

                    // Display results
                    totalnumbers.Text = $"Total: {total}  |  Count: {count}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message, "Error");
                }
            }
        }
    }
}
