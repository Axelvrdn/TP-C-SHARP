
namespace tpCsharp01découverteGraphique
{
    partial class frmimc
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
            this.txtPoids = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.txttaille = new System.Windows.Forms.TextBox();
            this.labelTaille = new System.Windows.Forms.Label();
            this.labelIMC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPoids
            // 
            this.txtPoids.Location = new System.Drawing.Point(252, 79);
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.Size = new System.Drawing.Size(100, 20);
            this.txtPoids.TabIndex = 0;
            this.txtPoids.Text = "Poids";
            this.txtPoids.Enter += new System.EventHandler(this.txtPoids_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Votre Poids :";
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.AliceBlue;
            this.button.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(222, 177);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(147, 55);
            this.button.TabIndex = 2;
            this.button.Text = "Valider";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // txttaille
            // 
            this.txttaille.Location = new System.Drawing.Point(252, 120);
            this.txttaille.Name = "txttaille";
            this.txttaille.Size = new System.Drawing.Size(100, 20);
            this.txttaille.TabIndex = 3;
            this.txttaille.Text = "Taille";
            this.txttaille.Enter += new System.EventHandler(this.txttaille_Enter);
            // 
            // labelTaille
            // 
            this.labelTaille.AutoSize = true;
            this.labelTaille.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaille.Location = new System.Drawing.Point(185, 122);
            this.labelTaille.Name = "labelTaille";
            this.labelTaille.Size = new System.Drawing.Size(59, 15);
            this.labelTaille.TabIndex = 4;
            this.labelTaille.Text = "Votre Taille :";
            // 
            // labelIMC
            // 
            this.labelIMC.AutoSize = true;
            this.labelIMC.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIMC.Location = new System.Drawing.Point(129, 299);
            this.labelIMC.Name = "labelIMC";
            this.labelIMC.Size = new System.Drawing.Size(0, 37);
            this.labelIMC.TabIndex = 5;
            // 
            // frmimc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.labelIMC);
            this.Controls.Add(this.labelTaille);
            this.Controls.Add(this.txttaille);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPoids);
            this.Name = "frmimc";
            this.Text = "Calcul d\'imc";
            this.Load += new System.EventHandler(this.frmimc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPoids;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox txttaille;
        private System.Windows.Forms.Label labelTaille;
        private System.Windows.Forms.Label labelIMC;
    }
}

