namespace WindowsFormsApp1
{
    partial class Form1
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
            this.tNum = new System.Windows.Forms.TextBox();
            this.TClé = new System.Windows.Forms.TextBox();
            this.LabSécu = new System.Windows.Forms.Label();
            this.LabClé = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButVali = new System.Windows.Forms.Button();
            this.Laberr = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tNum
            // 
            this.tNum.Location = new System.Drawing.Point(43, 50);
            this.tNum.Name = "tNum";
            this.tNum.Size = new System.Drawing.Size(132, 20);
            this.tNum.TabIndex = 0;
            // 
            // TClé
            // 
            this.TClé.Location = new System.Drawing.Point(221, 50);
            this.TClé.Name = "TClé";
            this.TClé.Size = new System.Drawing.Size(128, 20);
            this.TClé.TabIndex = 1;
            // 
            // LabSécu
            // 
            this.LabSécu.AutoSize = true;
            this.LabSécu.Location = new System.Drawing.Point(40, 34);
            this.LabSécu.Name = "LabSécu";
            this.LabSécu.Size = new System.Drawing.Size(135, 13);
            this.LabSécu.TabIndex = 2;
            this.LabSécu.Text = "Numéro de sécurité sociale";
            // 
            // LabClé
            // 
            this.LabClé.AutoSize = true;
            this.LabClé.Location = new System.Drawing.Point(218, 34);
            this.LabClé.Name = "LabClé";
            this.LabClé.Size = new System.Drawing.Size(131, 13);
            this.LabClé.TabIndex = 3;
            this.LabClé.Text = "Clé de contrôle du numéro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Laberr);
            this.groupBox1.Controls.Add(this.ButVali);
            this.groupBox1.Controls.Add(this.LabClé);
            this.groupBox1.Controls.Add(this.LabSécu);
            this.groupBox1.Controls.Add(this.TClé);
            this.groupBox1.Controls.Add(this.tNum);
            this.groupBox1.Location = new System.Drawing.Point(101, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 139);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // ButVali
            // 
            this.ButVali.Location = new System.Drawing.Point(161, 97);
            this.ButVali.Name = "ButVali";
            this.ButVali.Size = new System.Drawing.Size(75, 23);
            this.ButVali.TabIndex = 4;
            this.ButVali.Text = "Valider";
            this.ButVali.UseVisualStyleBackColor = true;
            this.ButVali.Click += new System.EventHandler(this.ButVali_Click);
            // 
            // Laberr
            // 
            this.Laberr.AutoSize = true;
            this.Laberr.Location = new System.Drawing.Point(131, 77);
            this.Laberr.Name = "Laberr";
            this.Laberr.Size = new System.Drawing.Size(0, 13);
            this.Laberr.TabIndex = 5;
            this.Laberr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tNum;
        private System.Windows.Forms.TextBox TClé;
        private System.Windows.Forms.Label LabSécu;
        private System.Windows.Forms.Label LabClé;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Laberr;
        private System.Windows.Forms.Button ButVali;
    }
}

