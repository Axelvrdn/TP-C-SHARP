using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace eval01B2
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void calculDindemnitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIndemnites uneFeuilleIndem = new frmIndemnites();
            MesFonctionsEtProceduresGenerales.OUVRE_UNE_MDI_FILLE(uneFeuilleIndem, this);
        }

        private void calculToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAVCacuIIndemRepas uneFeuilleIndem = new frmAVCacuIIndemRepas();
            MesFonctionsEtProceduresGenerales.OUVRE_UNE_MDI_FILLE(uneFeuilleIndem, this);
        }
    }
}
//Question1 :
//public static void AUTORISE_CHIFFRE_BACK(KeyPressEventArgs e)
//{
//    if (Char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)Keys.Back)
//        //si ce n'est pas un caractère accepté, on annule la saisie
//        e.Handled = true;
//}
// il verifie lorsque l'on appuie sur le clavier si c'est un chiffre, si oui il change la variable e.Handled sur true pour autoriser la saisie

//Question 2 :
//Si les chiffres sont trop long il y aurra une exception System.OverflowException 

//Partie 2

//Question 1 :
//
//try
//{
//    int leNbDeKilo;
//    Byte leNbDeRepas;
//    Double leMontantDesIndemnites;
//    leNbDeKilo = int.Parse(this.txtNbKilometres.Text);
//    leNbDeRepas = Byte.Parse(this.txtNbRepas.Text);
//    leMontantDesIndemnites = MesFPmetier.calculIndemKilo(leNbDeKilo) + MesFPmetier.calculIndemRepas(leNbDeRepas);
//    this.txtIndemnites.Text = leMontantDesIndemnites.ToString();
//}
//catch (OverflowException exc)
//{
//    MessageBox.Show(exc.Message, "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//}
//        }