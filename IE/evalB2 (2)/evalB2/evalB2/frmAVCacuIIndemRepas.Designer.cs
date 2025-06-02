
namespace eval01B2
{
    partial class frmAVCacuIIndemRepas
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
            this.txtValObtenue = new System.Windows.Forms.TextBox();
            this.btnCalcul = new System.Windows.Forms.Button();
            this.txtNbRepas = new System.Windows.Forms.TextBox();
            this.lblNbRepas = new System.Windows.Forms.Label();
            this.txtValAttendue = new System.Windows.Forms.TextBox();
            this.lblValAttendue = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btnVérification = new System.Windows.Forms.Button();
            this.lblValObtenue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValObtenue
            // 
            this.txtValObtenue.Enabled = false;
            this.txtValObtenue.Location = new System.Drawing.Point(311, 292);
            this.txtValObtenue.Name = "txtValObtenue";
            this.txtValObtenue.Size = new System.Drawing.Size(111, 20);
            this.txtValObtenue.TabIndex = 17;
            // 
            // btnCalcul
            // 
            this.btnCalcul.Location = new System.Drawing.Point(280, 232);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(171, 25);
            this.btnCalcul.TabIndex = 16;
            this.btnCalcul.Text = "Calculer les indemnités";
            this.btnCalcul.UseVisualStyleBackColor = true;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // txtNbRepas
            // 
            this.txtNbRepas.Location = new System.Drawing.Point(311, 130);
            this.txtNbRepas.Name = "txtNbRepas";
            this.txtNbRepas.Size = new System.Drawing.Size(97, 20);
            this.txtNbRepas.TabIndex = 15;
            this.txtNbRepas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNbRepas_KeyPress);
            // 
            // lblNbRepas
            // 
            this.lblNbRepas.AutoSize = true;
            this.lblNbRepas.Location = new System.Drawing.Point(179, 133);
            this.lblNbRepas.Name = "lblNbRepas";
            this.lblNbRepas.Size = new System.Drawing.Size(113, 13);
            this.lblNbRepas.TabIndex = 14;
            this.lblNbRepas.Text = "Nombre de repas pris :";
            // 
            // txtValAttendue
            // 
            this.txtValAttendue.Location = new System.Drawing.Point(311, 182);
            this.txtValAttendue.Name = "txtValAttendue";
            this.txtValAttendue.Size = new System.Drawing.Size(97, 20);
            this.txtValAttendue.TabIndex = 13;
            this.txtValAttendue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValAttendue_KeyPress);
            // 
            // lblValAttendue
            // 
            this.lblValAttendue.AutoSize = true;
            this.lblValAttendue.Location = new System.Drawing.Point(204, 185);
            this.lblValAttendue.Name = "lblValAttendue";
            this.lblValAttendue.Size = new System.Drawing.Size(88, 13);
            this.lblValAttendue.TabIndex = 12;
            this.lblValAttendue.Text = "Valeur attendue :";
            // 
            // txtresult
            // 
            this.txtresult.Enabled = false;
            this.txtresult.Location = new System.Drawing.Point(486, 292);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(111, 20);
            this.txtresult.TabIndex = 18;
            // 
            // btnVérification
            // 
            this.btnVérification.Location = new System.Drawing.Point(471, 232);
            this.btnVérification.Name = "btnVérification";
            this.btnVérification.Size = new System.Drawing.Size(142, 25);
            this.btnVérification.TabIndex = 19;
            this.btnVérification.Text = "Nouvelle vérification";
            this.btnVérification.UseVisualStyleBackColor = true;
            this.btnVérification.Click += new System.EventHandler(this.btnVérification_Click);
            // 
            // lblValObtenue
            // 
            this.lblValObtenue.AutoSize = true;
            this.lblValObtenue.Location = new System.Drawing.Point(207, 295);
            this.lblValObtenue.Name = "lblValObtenue";
            this.lblValObtenue.Size = new System.Drawing.Size(85, 13);
            this.lblValObtenue.TabIndex = 20;
            this.lblValObtenue.Text = "Valeur obtenue :";
            // 
            // frmAVCacuIIndemRepas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblValObtenue);
            this.Controls.Add(this.btnVérification);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtValObtenue);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.txtNbRepas);
            this.Controls.Add(this.lblNbRepas);
            this.Controls.Add(this.txtValAttendue);
            this.Controls.Add(this.lblValAttendue);
            this.Name = "frmAVCacuIIndemRepas";
            this.Text = "frmAVCacuIIndemRepas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValObtenue;
        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.TextBox txtNbRepas;
        private System.Windows.Forms.Label lblNbRepas;
        private System.Windows.Forms.TextBox txtValAttendue;
        private System.Windows.Forms.Label lblValAttendue;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btnVérification;
        private System.Windows.Forms.Label lblValObtenue;
    }
}