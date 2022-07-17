
namespace AppliDiététique
{
    partial class form1
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
            this.radio_sexeH = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.grp_sexe = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPoids = new System.Windows.Forms.NumericUpDown();
            this.txtTaille = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_3 = new System.Windows.Forms.RadioButton();
            this.rdo_4 = new System.Windows.Forms.RadioButton();
            this.rdo_1 = new System.Windows.Forms.RadioButton();
            this.rdo_2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numIMC = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMB = new System.Windows.Forms.TextBox();
            this.txtDEJ = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.NumericUpDown();
            this.lblIMC = new System.Windows.Forms.Label();
            this.grp_sexe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPoids)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaille)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIMC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge)).BeginInit();
            this.SuspendLayout();
            // 
            // radio_sexeH
            // 
            this.radio_sexeH.AutoSize = true;
            this.radio_sexeH.Location = new System.Drawing.Point(6, 32);
            this.radio_sexeH.Name = "radio_sexeH";
            this.radio_sexeH.Size = new System.Drawing.Size(77, 21);
            this.radio_sexeH.TabIndex = 0;
            this.radio_sexeH.TabStop = true;
            this.radio_sexeH.Text = "Homme";
            this.radio_sexeH.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Femme";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // grp_sexe
            // 
            this.grp_sexe.Controls.Add(this.radio_sexeH);
            this.grp_sexe.Controls.Add(this.radioButton2);
            this.grp_sexe.Location = new System.Drawing.Point(38, 140);
            this.grp_sexe.Name = "grp_sexe";
            this.grp_sexe.Size = new System.Drawing.Size(222, 100);
            this.grp_sexe.TabIndex = 2;
            this.grp_sexe.TabStop = false;
            this.grp_sexe.Text = "Genre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Poids (en kgs)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Taille (en mètres)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "MB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "IMC";
            // 
            // txtPoids
            // 
            this.txtPoids.Location = new System.Drawing.Point(140, 21);
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.Size = new System.Drawing.Size(120, 22);
            this.txtPoids.TabIndex = 7;
            // 
            // txtTaille
            // 
            this.txtTaille.DecimalPlaces = 2;
            this.txtTaille.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtTaille.Location = new System.Drawing.Point(140, 63);
            this.txtTaille.Name = "txtTaille";
            this.txtTaille.Size = new System.Drawing.Size(120, 22);
            this.txtTaille.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_3);
            this.groupBox1.Controls.Add(this.rdo_4);
            this.groupBox1.Controls.Add(this.rdo_1);
            this.groupBox1.Controls.Add(this.rdo_2);
            this.groupBox1.Location = new System.Drawing.Point(38, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 153);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Niveau d\'activité physique";
            // 
            // rdo_3
            // 
            this.rdo_3.AutoSize = true;
            this.rdo_3.Location = new System.Drawing.Point(6, 90);
            this.rdo_3.Name = "rdo_3";
            this.rdo_3.Size = new System.Drawing.Size(166, 21);
            this.rdo_3.TabIndex = 3;
            this.rdo_3.TabStop = true;
            this.rdo_3.Text = "3 - Activité importante";
            this.rdo_3.UseVisualStyleBackColor = true;
            // 
            // rdo_4
            // 
            this.rdo_4.AutoSize = true;
            this.rdo_4.Location = new System.Drawing.Point(6, 117);
            this.rdo_4.Name = "rdo_4";
            this.rdo_4.Size = new System.Drawing.Size(194, 21);
            this.rdo_4.TabIndex = 2;
            this.rdo_4.TabStop = true;
            this.rdo_4.Text = "4 - Activité très importante";
            this.rdo_4.UseVisualStyleBackColor = true;
            // 
            // rdo_1
            // 
            this.rdo_1.AutoSize = true;
            this.rdo_1.Location = new System.Drawing.Point(6, 36);
            this.rdo_1.Name = "rdo_1";
            this.rdo_1.Size = new System.Drawing.Size(133, 21);
            this.rdo_1.TabIndex = 0;
            this.rdo_1.TabStop = true;
            this.rdo_1.Text = "1 - Activité faible";
            this.rdo_1.UseVisualStyleBackColor = true;
            // 
            // rdo_2
            // 
            this.rdo_2.AutoSize = true;
            this.rdo_2.Location = new System.Drawing.Point(6, 63);
            this.rdo_2.Name = "rdo_2";
            this.rdo_2.Size = new System.Drawing.Size(157, 21);
            this.rdo_2.TabIndex = 1;
            this.rdo_2.TabStop = true;
            this.rdo_2.Text = "2 - Activité moyenne";
            this.rdo_2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblIMC);
            this.groupBox2.Controls.Add(this.numIMC);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMB);
            this.groupBox2.Controls.Add(this.txtDEJ);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(298, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 172);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Résultats";
            // 
            // numIMC
            // 
            this.numIMC.InterceptArrowKeys = false;
            this.numIMC.Location = new System.Drawing.Point(115, 29);
            this.numIMC.Name = "numIMC";
            this.numIMC.Size = new System.Drawing.Size(100, 22);
            this.numIMC.TabIndex = 14;
            this.numIMC.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "DEJ";
            // 
            // txtMB
            // 
            this.txtMB.Enabled = false;
            this.txtMB.Location = new System.Drawing.Point(115, 93);
            this.txtMB.Name = "txtMB";
            this.txtMB.Size = new System.Drawing.Size(100, 22);
            this.txtMB.TabIndex = 12;
            // 
            // txtDEJ
            // 
            this.txtDEJ.Enabled = false;
            this.txtDEJ.Location = new System.Drawing.Point(115, 132);
            this.txtDEJ.Name = "txtDEJ";
            this.txtDEJ.Size = new System.Drawing.Size(100, 22);
            this.txtDEJ.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 67);
            this.button1.TabIndex = 12;
            this.button1.Text = "Calculer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.txtAge.Location = new System.Drawing.Point(140, 106);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(120, 22);
            this.txtAge.TabIndex = 14;
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Location = new System.Drawing.Point(37, 58);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(0, 17);
            this.lblIMC.TabIndex = 15;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 447);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTaille);
            this.Controls.Add(this.txtPoids);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grp_sexe);
            this.Name = "form1";
            this.Text = "Calculs diététiques";
            this.grp_sexe.ResumeLayout(false);
            this.grp_sexe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPoids)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaille)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIMC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_sexeH;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox grp_sexe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtPoids;
        private System.Windows.Forms.NumericUpDown txtTaille;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_3;
        private System.Windows.Forms.RadioButton rdo_4;
        private System.Windows.Forms.RadioButton rdo_1;
        private System.Windows.Forms.RadioButton rdo_2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMB;
        private System.Windows.Forms.TextBox txtDEJ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numIMC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtAge;
        private System.Windows.Forms.Label lblIMC;
    }
}

