using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliDiététique
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
            numIMC.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numIMC.Value = IMC();
            txtMB.Text = MB() + " kcal";
            txtDEJ.Text = DEJ() + " kcal";
        }
        public decimal IMC()
        {
            decimal taille = decimal.Parse(txtTaille.Text);
            int poids = int.Parse(txtPoids.Text);
            decimal IMC = (poids / (taille * taille));
            return IMC;
        }

        public string MB()
        {
            double cBase;
            double taille = double.Parse(txtTaille.Text);
            double tailleC = Math.Pow(taille, 0.5);
            double poids = double.Parse(txtPoids.Text);
            double poidsC = Math.Pow(poids, 0.48);
            double age = double.Parse(txtAge.Text);
            double ageC = Math.Pow(age, -0.13);

            if (radio_sexeH.Checked){
                cBase = 1.083;
            }
            else
            {
                cBase = 0.963;
            }

            double MB = (cBase * poidsC * tailleC * ageC) * (1000/4.1855);
            MB = Math.Round(MB, 0);
            string MB2 = Convert.ToString(MB);

            return MB2;
        }

        public string DEJ()
        {
            double indice;
            if (rdo_1.Checked)
            {
                indice = 1.37;
            }
            else if (rdo_2.Checked)
            {
                indice = 1.55;
            }
            else if (rdo_3.Checked)
            {
                indice = 1.8;
            }
            else
            {
                indice = 2;
            }

            int MB2 = Convert.ToInt32(MB());

            string DEJ = Convert.ToString(MB2 * indice);

            return DEJ;
        }
    }
}
