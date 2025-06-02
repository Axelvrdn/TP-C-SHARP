using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpCsharp01découverteGraphique
{
    public partial class frmimc : Form
    {
        public frmimc()
        {
            InitializeComponent();
        }

        private void frmimc_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Word !!","Message d'acceuile",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
        }

        private void button_Click(object sender, EventArgs e)
        {
            int poids;
            float taille, imc;
            poids = int.Parse(txtPoids.Text);
            taille = float.Parse(txttaille.Text);
            imc = (poids / (taille * taille));
            //MessageBox.Show("Votres imc est de" + imc);
            labelIMC.Text = "Votre IMC = " + imc;
        }

        private void txtPoids_Enter(object sender, EventArgs e)
        {
            txtPoids.Text = "";

        }

        private void txttaille_Enter(object sender, EventArgs e)
        {
            txttaille.Text = "";
        }
    }
}
