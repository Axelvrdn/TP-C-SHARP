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
    public partial class frmIndemnites : Form
    {
        public frmIndemnites()
        {
            InitializeComponent();
        }


        /// <summary>
        /// calcule le montant de l'indemnité et la stocke dans la zone de de texte
        /// </summary>
        /// <param name="sender">controle sur lequel s'est déclenché l'événement, ici btnCalcul</param>
        /// <param name="e">événement qui a déclenché l'évenment, ici click sur le bouton</param>
        private void btnCalcul_Click(object sender, EventArgs e)
        {
            try
            {
                int leNbDeKilo;
                Byte leNbDeRepas;
                Double leMontantDesIndemnites;
                leNbDeKilo = int.Parse(this.txtNbKilometres.Text);
                leNbDeRepas = Byte.Parse(this.txtNbRepas.Text);
                leMontantDesIndemnites = MesFPmetier.calculIndemKilo(leNbDeKilo) + MesFPmetier.calculIndemRepas(leNbDeRepas);
                this.txtIndemnites.Text = leMontantDesIndemnites.ToString();
            }
            catch (OverflowException exc)
            {
                MessageBox.Show(exc.Message, "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// empêche la saisie d'autres caractères que les chiffres et le backspace :
        /// appel de AUTORISE_CHIFFRE_BACK
        /// </summary>
        /// <param name="sender">controle sur lequel s'est déclenché l'événement, ici txtNbKilometres</param>
        /// <param name="e">événement qui a déclenché l'évenment, ici l'appui sur une touche</param>
        private void txtNbKilometres_KeyPress(object sender, KeyPressEventArgs e)
        {
            MesFonctionsEtProceduresGenerales.AUTORISE_CHIFFRE_BACK(e);
        }

        /// <summary>
        /// empêche la saisie d'autres caractères que les chiffres et le backspace :
        /// appel de AUTORISE_CHIFFRE_BACK
        /// </summary>
        /// <param name="sender">controle sur lequel s'est déclenché l'événement, ici txtNbRepas</param>
        /// <param name="e">événement qui a déclenché l'évenment, ici l'appui sur une touche</param>
        private void txtNbRepas_KeyPress(object sender, KeyPressEventArgs e)
        {
            MesFonctionsEtProceduresGenerales.AUTORISE_CHIFFRE_BACK(e);
        }
    }
}
