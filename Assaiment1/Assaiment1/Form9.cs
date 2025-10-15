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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                // Xogta joogtada ah
   int totalCookies = 40;           // Tirada buskudka oo dhan
    int servings = 10;               // Tirada servings-ka
    int caloriesPerServing = 300;    // Kalooriyada halkii serving

    // Xisaabi kalooriyada buskud kasta
    double caloriesPerCookie = (double)caloriesPerServing * servings / totalCookies;

    // Hel xogta user-ka
    int cookiesEaten;
    bool isValid = int.TryParse(txtcook.Text, out cookiesEaten);

    if (!isValid || cookiesEaten < 0)
    {
        txtcal.Text = "Fadlan gali tirada saxda ah ee buskudka.";
        return;
    }

    // Xisaabi kalooriyada guud
    double totalCalories = cookiesEaten * caloriesPerCookie;

    // Soo bandhig natiijada
    txtcal.Text = string.Format("You consumed {0} calories.", totalCalories);
}
    }
}
