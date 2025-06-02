namespace projetWF
{
    partial class frmSaisie
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrix = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPoids = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPrix
            // 
            this.btnPrix.Location = new System.Drawing.Point(222, 133);
            this.btnPrix.Name = "btnPrix";
            this.btnPrix.Size = new System.Drawing.Size(149, 43);
            this.btnPrix.TabIndex = 0;
            this.btnPrix.Text = "voir le prix à payer";
            this.btnPrix.UseVisualStyleBackColor = true;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrez un poids de courrier :";
            // 
            // txtPoids
            // 
            this.txtPoids.Location = new System.Drawing.Point(271, 51);
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.Size = new System.Drawing.Size(100, 22);
            this.txtPoids.TabIndex = 2;
            this.txtPoids.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPoids_KeyPress);
            // 
            // frmSaisie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 321);
            this.Controls.Add(this.txtPoids);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrix);
            this.Name = "frmSaisie";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPoids;
    }
}

