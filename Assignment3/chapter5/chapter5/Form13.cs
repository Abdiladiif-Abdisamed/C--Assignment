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
    public partial class Form13 : Form
    {
        private Random rand = new Random();

        public Form13()
        {
            InitializeComponent();
            button1.Click += Button1_Click; // Event-ka button
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Hubi in user-ka tirada sax geliyey
            if (int.TryParse(textBox1.Text, out int count) && count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                    Title = "Save Random Numbers"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int randomNumber = rand.Next(1, 101); // 1 ilaa 100
                                writer.WriteLine(randomNumber);
                            }
                        }

                        MessageBox.Show($"File saved successfully at:\n{filePath}", "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving file: {ex.Message}", "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid positive number!", "Error");
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Haddii aad rabto wax khaas ah markii file la doorto, halkan geli
        }
    }
}