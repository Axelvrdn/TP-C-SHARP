using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_devoir_Graphique
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenerateNumbers();
        }

        private void GenerateNumbers()
        {
            // Générer des nombres aléatoires entre 1 et 10
            Random rnd = new Random();
            int num1 = rnd.Next(minNum1, maxNum1 + 1);
            int num2 = rnd.Next(minNum2, maxNum2 + 1);
            // Afficher les nombres aléatoires dans les textboxes
            tNumb1.Text = num1.ToString();
            tNumb2.Text = num2.ToString();
        }

        private void radAdd_CheckedChanged(object sender, EventArgs e)
        {
            labPlusMoins.Text = "+";
        }

        private void radSous_CheckedChanged(object sender, EventArgs e)
        {
            labPlusMoins.Text = "-";
        }

        private int minNum1 = 1;
        private int maxNum1 = 10;
        private int minNum2 = 1;
        private int maxNum2 = 10;

        private void radNv1_CheckedChanged(object sender, EventArgs e)
        {
            if (radNv1.Checked)
            {
                minNum1 = 1;
                maxNum1 = 10;
                minNum2 = 1;
                maxNum2 = 10;
                GenerateNumbers();
            }
        }

        private void radNv2_CheckedChanged(object sender, EventArgs e)
        {
            if (radNv2.Checked)
            {
                minNum1 = 10;
                maxNum1 = 100;
                minNum2 = 10;
                maxNum2 = 100;
                GenerateNumbers();
            }
        }

        private void bverif_Click(object sender, EventArgs e)
        {
            // Get the entered number
            int enteredNumber = int.Parse(tresult.Text);

            // Get the random numbers and the selected operation
            int num1 = int.Parse(tNumb1.Text);
            int num2 = int.Parse(tNumb2.Text);
            string operation = labPlusMoins.Text;

            // Perform the calculation based on the selected operation
            int result = operation == "+" ? num1 + num2 : num1 - num2;

            // Check if the entered number matches the calculation result
            if (enteredNumber == result)
            {
                MessageBox.Show("Bravo! C'est la bonne réponse.");
                CountCor.Text = (int.Parse(CountCor.Text) + 1).ToString();
                GenerateNumbers(); // Generate new numbers
            }
            else
            {
                MessageBox.Show("Désolé, ce n'est pas la bonne réponse.");
                CountInco.Text = (int.Parse(CountInco.Text) + 1).ToString();
            }
        }
    }
}