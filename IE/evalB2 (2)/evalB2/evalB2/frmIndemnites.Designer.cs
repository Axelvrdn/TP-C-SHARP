
namespace eval01B2
{
    partial class frmIndemnites
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIndemnites = new System.Windows.Forms.TextBox();
            this.btnCalcul = new System.Windows.Forms.Button();
            this.txtNbRepas = new System.Windows.Forms.TextBox();
            this.lblNbRepas = new System.Windows.Forms.Label();
            this.txtNbKilometres = new System.Windows.Forms.TextBox();
            this.lblNbKilometres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIndemnites
            // 
            this.txtIndemnites.Enabled = false;
            this.txtIndemnites.Location = new System.Drawing.Point(320, 316);
            this.txtIndemnites.Margin = new System.Windows.Forms.Padding(4);
            this.txtIndemnites.Name = "txtIndemnites";
            this.txtIndemnites.Size = new System.Drawing.Size(147, 22);
            this.txtIndemnites.TabIndex = 11;
            // 
            // btnCalcul
            // 
            this.btnCalcul.Location = new System.Drawing.Point(287, 235);
            this.btnCalcul.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(228, 31);
            this.btnCalcul.TabIndex = 10;
            this.btnCalcul.Text = "Calculer les indemnités";
            this.btnCalcul.UseVisualStyleBackColor = true;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // txtNbRepas
            // 
            this.txtNbRepas.Location = new System.Drawing.Point(451, 170);
            this.txtNbRepas.Margin = new System.Windows.Forms.Padding(4);
            this.txtNbRepas.Name = "txtNbRepas";
            this.txtNbRepas.Size = new System.Drawing.Size(128, 22);
            this.txtNbRepas.TabIndex = 9;
            this.txtNbRepas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNbRepas_KeyPress);
            // 
            // lblNbRepas
            // 
            this.lblNbRepas.AutoSize = true;
            this.lblNbRepas.Location = new System.Drawing.Point(275, 174);
            this.lblNbRepas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbRepas.Name = "lblNbRepas";
            this.lblNbRepas.Size = new System.Drawing.Size(153, 17);
            this.lblNbRepas.TabIndex = 8;
            this.lblNbRepas.Text = "Nombre de repas pris :";
            // 
            // txtNbKilometres
            // 
            this.txtNbKilometres.Location = new System.Drawing.Point(451, 113);
            this.txtNbKilometres.Margin = new System.Windows.Forms.Padding(4);
            this.txtNbKilometres.Name = "txtNbKilometres";
            this.txtNbKilometres.Size = new System.Drawing.Size(128, 22);
            this.txtNbKilometres.TabIndex = 7;
            this.txtNbKilometres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNbKilometres_KeyPress);
            // 
            // lblNbKilometres
            // 
            this.lblNbKilometres.AutoSize = true;
            this.lblNbKilometres.Location = new System.Drawing.Point(221, 117);
            this.lblNbKilometres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbKilometres.Name = "lblNbKilometres";
            this.lblNbKilometres.Size = new System.Drawing.Size(216, 17);
            this.lblNbKilometres.TabIndex = 6;
            this.lblNbKilometres.Text = "Nombre de kilomètres effectués :";
            // 
            // frmIndemnites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIndemnites);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.txtNbRepas);
            this.Controls.Add(this.lblNbRepas);
            this.Controls.Add(this.txtNbKilometres);
            this.Controls.Add(this.lblNbKilometres);
            this.Name = "frmIndemnites";
            this.Text = "Calcul d\'indemnités";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIndemnites;
        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.TextBox txtNbRepas;
        private System.Windows.Forms.Label lblNbRepas;
        private System.Windows.Forms.TextBox txtNbKilometres;
        private System.Windows.Forms.Label lblNbKilometres;
    }
}