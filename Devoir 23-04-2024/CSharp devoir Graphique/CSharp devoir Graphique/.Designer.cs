
namespace CSharp_devoir_Graphique
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
            this.CévalLvl = new System.Windows.Forms.CheckBox();
            this.bverif = new System.Windows.Forms.Button();
            this.légale = new System.Windows.Forms.Label();
            this.labPlusMoins = new System.Windows.Forms.Label();
            this.tNumb2 = new System.Windows.Forms.TextBox();
            this.tNumb1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tresult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CountCor = new System.Windows.Forms.Label();
            this.CountInco = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.radSous = new System.Windows.Forms.RadioButton();
            this.radNv1 = new System.Windows.Forms.RadioButton();
            this.radNv2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // CévalLvl
            // 
            this.CévalLvl.AutoSize = true;
            this.CévalLvl.Location = new System.Drawing.Point(578, 255);
            this.CévalLvl.Name = "CévalLvl";
            this.CévalLvl.Size = new System.Drawing.Size(125, 17);
            this.CévalLvl.TabIndex = 0;
            this.CévalLvl.Text = "évaluation du niveau";
            this.CévalLvl.UseVisualStyleBackColor = true;
            // 
            // bverif
            // 
            this.bverif.Location = new System.Drawing.Point(533, 47);
            this.bverif.Name = "bverif";
            this.bverif.Size = new System.Drawing.Size(75, 36);
            this.bverif.TabIndex = 1;
            this.bverif.Text = "Vérifier la réponse";
            this.bverif.UseVisualStyleBackColor = true;
            this.bverif.Click += new System.EventHandler(this.bverif_Click);
            // 
            // légale
            // 
            this.légale.AutoSize = true;
            this.légale.Location = new System.Drawing.Point(380, 53);
            this.légale.Name = "légale";
            this.légale.Size = new System.Drawing.Size(13, 13);
            this.légale.TabIndex = 2;
            this.légale.Text = "=";
            // 
            // labPlusMoins
            // 
            this.labPlusMoins.AutoSize = true;
            this.labPlusMoins.Location = new System.Drawing.Point(190, 52);
            this.labPlusMoins.Name = "labPlusMoins";
            this.labPlusMoins.Size = new System.Drawing.Size(13, 13);
            this.labPlusMoins.TabIndex = 3;
            this.labPlusMoins.Text = "+";
            // 
            // tNumb2
            // 
            this.tNumb2.Enabled = false;
            this.tNumb2.Location = new System.Drawing.Point(254, 50);
            this.tNumb2.Name = "tNumb2";
            this.tNumb2.Size = new System.Drawing.Size(100, 20);
            this.tNumb2.TabIndex = 4;
            // 
            // tNumb1
            // 
            this.tNumb1.Enabled = false;
            this.tNumb1.Location = new System.Drawing.Point(34, 49);
            this.tNumb1.Name = "tNumb1";
            this.tNumb1.Size = new System.Drawing.Size(100, 20);
            this.tNumb1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tresult);
            this.groupBox1.Controls.Add(this.tNumb1);
            this.groupBox1.Controls.Add(this.tNumb2);
            this.groupBox1.Controls.Add(this.labPlusMoins);
            this.groupBox1.Controls.Add(this.légale);
            this.groupBox1.Controls.Add(this.bverif);
            this.groupBox1.Location = new System.Drawing.Point(89, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 114);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // tresult
            // 
            this.tresult.Location = new System.Drawing.Point(418, 49);
            this.tresult.Name = "tresult";
            this.tresult.Size = new System.Drawing.Size(100, 20);
            this.tresult.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Correct : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Incorrect : ";
            // 
            // CountCor
            // 
            this.CountCor.AutoSize = true;
            this.CountCor.Location = new System.Drawing.Point(31, 63);
            this.CountCor.Name = "CountCor";
            this.CountCor.Size = new System.Drawing.Size(13, 13);
            this.CountCor.TabIndex = 9;
            this.CountCor.Text = "0";
            // 
            // CountInco
            // 
            this.CountInco.AutoSize = true;
            this.CountInco.Location = new System.Drawing.Point(115, 63);
            this.CountInco.Name = "CountInco";
            this.CountInco.Size = new System.Drawing.Size(13, 13);
            this.CountInco.TabIndex = 10;
            this.CountInco.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.CountInco);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CountCor);
            this.groupBox2.Location = new System.Drawing.Point(552, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 114);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radSous);
            this.groupBox3.Controls.Add(this.radAdd);
            this.groupBox3.Location = new System.Drawing.Point(266, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(167, 114);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opération";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radNv2);
            this.groupBox4.Controls.Add(this.radNv1);
            this.groupBox4.Location = new System.Drawing.Point(56, 279);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(167, 114);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Niveau";
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.Checked = true;
            this.radAdd.Location = new System.Drawing.Point(16, 37);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(63, 17);
            this.radAdd.TabIndex = 0;
            this.radAdd.TabStop = true;
            this.radAdd.Text = "Addition";
            this.radAdd.UseVisualStyleBackColor = true;
            this.radAdd.CheckedChanged += new System.EventHandler(this.radAdd_CheckedChanged);
            // 
            // radSous
            // 
            this.radSous.AutoSize = true;
            this.radSous.Location = new System.Drawing.Point(16, 60);
            this.radSous.Name = "radSous";
            this.radSous.Size = new System.Drawing.Size(84, 17);
            this.radSous.TabIndex = 1;
            this.radSous.Text = "Soustraction";
            this.radSous.UseVisualStyleBackColor = true;
            this.radSous.CheckedChanged += new System.EventHandler(this.radSous_CheckedChanged);
            // 
            // radNv1
            // 
            this.radNv1.AutoSize = true;
            this.radNv1.Checked = true;
            this.radNv1.Location = new System.Drawing.Point(16, 37);
            this.radNv1.Name = "radNv1";
            this.radNv1.Size = new System.Drawing.Size(95, 17);
            this.radNv1.TabIndex = 1;
            this.radNv1.TabStop = true;
            this.radNv1.Text = "Niveau1 (1-10)";
            this.radNv1.UseVisualStyleBackColor = true;
            this.radNv1.CheckedChanged += new System.EventHandler(this.radNv1_CheckedChanged);
            // 
            // radNv2
            // 
            this.radNv2.AutoSize = true;
            this.radNv2.Location = new System.Drawing.Point(16, 60);
            this.radNv2.Name = "radNv2";
            this.radNv2.Size = new System.Drawing.Size(110, 17);
            this.radNv2.TabIndex = 2;
            this.radNv2.Text = "Niveau 2 (10-100)";
            this.radNv2.UseVisualStyleBackColor = true;
            this.radNv2.CheckedChanged += new System.EventHandler(this.radNv2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CévalLvl);
            this.Name = "Form1";
            this.Text = "d";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CévalLvl;
        private System.Windows.Forms.Button bverif;
        private System.Windows.Forms.Label légale;
        private System.Windows.Forms.Label labPlusMoins;
        private System.Windows.Forms.TextBox tNumb2;
        private System.Windows.Forms.TextBox tNumb1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tresult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CountCor;
        private System.Windows.Forms.Label CountInco;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radSous;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.RadioButton radNv2;
        private System.Windows.Forms.RadioButton radNv1;
    }
}

