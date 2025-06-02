using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButVali_Click(object sender, EventArgs e)
        {
            string NumSec = tNum.Text;
            string Clé = TClé.Text;
            // Supprimer les espaces du numéro de Sécurité sociale
            NumSec = NumSec.Replace(" ", "");
            // Vérifier si le numéro de Sécurité sociale est valide (13 chiffres)
            if (NumSec.Length != 13)
            {
                Laberr.Text = "Le numéro de Sécurité sociale doit contenir 13 chiffres.";
                return;
            }
            // Vérifier que chaque caractère du numéro de sécurité sociale est un chiffre
            foreach (char c in NumSec)
            {
                if (!char.IsDigit(c))
                {
                    Laberr.Text = "Le numéro de Sécurité sociale doit contenir uniquement des chiffres.";
                    return;
                }
            }
            // Convertir la chaîne de caractères en entier
            long numSec = long.Parse(NumSec);
            // Calculer la clé de contrôle
            int divisor = 97;
            long quotient = numSec / divisor;
            long remainder = numSec % divisor;
            long clé = 97 - remainder;
            // Vérifier si la clé est correcte
            if (clé != int.Parse(Clé))
            {
                Laberr.Text = $"La clé est incorrecte. La clé correcte est {clé}.";
            }
            else
            {
                Laberr.Text = "";
            }
        }
    }
}
