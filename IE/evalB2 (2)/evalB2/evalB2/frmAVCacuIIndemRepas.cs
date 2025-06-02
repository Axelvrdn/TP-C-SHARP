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
    public partial class frmAVCacuIIndemRepas : Form
    {
        public frmAVCacuIIndemRepas()
        {
            InitializeComponent();
        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {
            try
            {
                string nbrepas = txtNbRepas.Text;
                string valAttendue = txtValAttendue.Text;
                int valAtt = int.Parse(valAttendue);
                int valCalcul;
                int nbRepas = int.Parse(nbrepas);
                valCalcul = MesFPmetier.calculIndemRepas(nbRepas);
                txtValObtenue.Text = $"{valCalcul}";

                if (valCalcul != valAtt)
                {
                    txtresult.Text = "échec";
                }
                else
                {
                    txtresult.Text = "réussite";
                }
            }
            catch (OverflowException exc)
            {
                MessageBox.Show(exc.Message, "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnVérification_Click(object sender, EventArgs e)
        {
            txtNbRepas.Text = "";
            txtValAttendue.Text = "";
            txtValObtenue.Text = "";
            txtresult.Text = "";
        }

        private void txtNbRepas_KeyPress(object sender, KeyPressEventArgs e)
        {
            MesFonctionsEtProceduresGenerales.AUTORISE_CHIFFRE_BACK(e);
        }

        private void txtValAttendue_KeyPress(object sender, KeyPressEventArgs e)
        {
            MesFonctionsEtProceduresGenerales.AUTORISE_CHIFFRE_BACK(e);
        }
    }
}
