using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetWF
{
    public partial class frmSaisie : Form
    {
         
        public frmSaisie()
        {
            InitializeComponent();
        }

        private void txtPoids_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)Keys.Back)
                //si ce n'est pas un caractère accepté, on annule la saisie
                e.Handled = true;
        }

       
    }
}
