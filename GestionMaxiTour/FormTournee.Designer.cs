namespace GestionMaxiTour
{
    partial class FormTournee
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
            this.label1 = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.devis_tb = new System.Windows.Forms.TextBox();
            this.facture_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_devis = new System.Windows.Forms.Button();
            this.btn_facture = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.intitul_tb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.depart_tb = new System.Windows.Forms.TextBox();
            this.arrivee_tb = new System.Windows.Forms.TextBox();
            this.frequence_tb = new System.Windows.Forms.TextBox();
            this.period_tb = new System.Windows.Forms.TextBox();
            this.nombrej_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxE = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonDebut = new System.Windows.Forms.Button();
            this.buttonPrecedent = new System.Windows.Forms.Button();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonFin = new System.Windows.Forms.Button();
            this.buttonAjout = new System.Windows.Forms.Button();
            this.buttonSupprim = new System.Windows.Forms.Button();
            this.btn_tournee = new System.Windows.Forms.Button();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.buttonModif = new System.Windows.Forms.Button();
            this.duree_tb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant ";
            // 
            // id_tb
            // 
            this.id_tb.Enabled = false;
            this.id_tb.Location = new System.Drawing.Point(96, 13);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(100, 20);
            this.id_tb.TabIndex = 1;
            // 
            // devis_tb
            // 
            this.devis_tb.Location = new System.Drawing.Point(96, 119);
            this.devis_tb.Name = "devis_tb";
            this.devis_tb.Size = new System.Drawing.Size(100, 20);
            this.devis_tb.TabIndex = 2;
            // 
            // facture_tb
            // 
            this.facture_tb.Location = new System.Drawing.Point(96, 175);
            this.facture_tb.Name = "facture_tb";
            this.facture_tb.Size = new System.Drawing.Size(100, 20);
            this.facture_tb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "liée au devis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "numéro facture";
            // 
            // btn_devis
            // 
            this.btn_devis.Location = new System.Drawing.Point(96, 145);
            this.btn_devis.Name = "btn_devis";
            this.btn_devis.Size = new System.Drawing.Size(100, 23);
            this.btn_devis.TabIndex = 6;
            this.btn_devis.Text = "liste des devis";
            this.btn_devis.UseVisualStyleBackColor = true;
            this.btn_devis.Click += new System.EventHandler(this.btn_devis_Click);
            // 
            // btn_facture
            // 
            this.btn_facture.Location = new System.Drawing.Point(96, 201);
            this.btn_facture.Name = "btn_facture";
            this.btn_facture.Size = new System.Drawing.Size(100, 23);
            this.btn_facture.TabIndex = 7;
            this.btn_facture.Text = "liste des factures";
            this.btn_facture.UseVisualStyleBackColor = true;
            this.btn_facture.Click += new System.EventHandler(this.btn_facture_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Intitulé tournée";
            // 
            // intitul_tb
            // 
            this.intitul_tb.Location = new System.Drawing.Point(97, 83);
            this.intitul_tb.Name = "intitul_tb";
            this.intitul_tb.Size = new System.Drawing.Size(100, 20);
            this.intitul_tb.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.duree_tb);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nombrej_tb);
            this.groupBox1.Controls.Add(this.period_tb);
            this.groupBox1.Controls.Add(this.frequence_tb);
            this.groupBox1.Controls.Add(this.arrivee_tb);
            this.groupBox1.Controls.Add(this.depart_tb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(237, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 236);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détails";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adresse Départ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Adresse arrivée";
            // 
            // depart_tb
            // 
            this.depart_tb.Location = new System.Drawing.Point(92, 34);
            this.depart_tb.Name = "depart_tb";
            this.depart_tb.Size = new System.Drawing.Size(238, 20);
            this.depart_tb.TabIndex = 2;
            // 
            // arrivee_tb
            // 
            this.arrivee_tb.Location = new System.Drawing.Point(93, 71);
            this.arrivee_tb.Name = "arrivee_tb";
            this.arrivee_tb.Size = new System.Drawing.Size(237, 20);
            this.arrivee_tb.TabIndex = 3;
            // 
            // frequence_tb
            // 
            this.frequence_tb.Location = new System.Drawing.Point(93, 98);
            this.frequence_tb.Name = "frequence_tb";
            this.frequence_tb.Size = new System.Drawing.Size(100, 20);
            this.frequence_tb.TabIndex = 4;
            // 
            // period_tb
            // 
            this.period_tb.Location = new System.Drawing.Point(93, 133);
            this.period_tb.Name = "period_tb";
            this.period_tb.Size = new System.Drawing.Size(100, 20);
            this.period_tb.TabIndex = 5;
            // 
            // nombrej_tb
            // 
            this.nombrej_tb.Location = new System.Drawing.Point(93, 170);
            this.nombrej_tb.Name = "nombrej_tb";
            this.nombrej_tb.Size = new System.Drawing.Size(100, 20);
            this.nombrej_tb.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fréquence";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Periodicité";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(199, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "fois par jour";
            // 
            // checkBoxE
            // 
            this.checkBoxE.AutoSize = true;
            this.checkBoxE.Location = new System.Drawing.Point(97, 50);
            this.checkBoxE.Name = "checkBoxE";
            this.checkBoxE.Size = new System.Drawing.Size(72, 17);
            this.checkBoxE.TabIndex = 11;
            this.checkBoxE.Text = "Validation";
            this.checkBoxE.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Etat";
            // 
            // buttonDebut
            // 
            this.buttonDebut.Location = new System.Drawing.Point(18, 265);
            this.buttonDebut.Name = "buttonDebut";
            this.buttonDebut.Size = new System.Drawing.Size(28, 23);
            this.buttonDebut.TabIndex = 13;
            this.buttonDebut.Text = "<<";
            this.buttonDebut.UseVisualStyleBackColor = true;
            this.buttonDebut.Click += new System.EventHandler(this.buttonDebut_Click);
            // 
            // buttonPrecedent
            // 
            this.buttonPrecedent.Location = new System.Drawing.Point(52, 265);
            this.buttonPrecedent.Name = "buttonPrecedent";
            this.buttonPrecedent.Size = new System.Drawing.Size(28, 23);
            this.buttonPrecedent.TabIndex = 14;
            this.buttonPrecedent.Text = "<";
            this.buttonPrecedent.UseVisualStyleBackColor = true;
            this.buttonPrecedent.Click += new System.EventHandler(this.buttonPrecedent_Click);
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Location = new System.Drawing.Point(86, 265);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(28, 23);
            this.buttonSuivant.TabIndex = 15;
            this.buttonSuivant.Text = ">";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.buttonSuivant_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(120, 265);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // buttonFin
            // 
            this.buttonFin.Location = new System.Drawing.Point(120, 265);
            this.buttonFin.Name = "buttonFin";
            this.buttonFin.Size = new System.Drawing.Size(28, 23);
            this.buttonFin.TabIndex = 17;
            this.buttonFin.Text = ">>";
            this.buttonFin.UseVisualStyleBackColor = true;
            this.buttonFin.Click += new System.EventHandler(this.buttonFin_Click);
            // 
            // buttonAjout
            // 
            this.buttonAjout.Location = new System.Drawing.Point(172, 265);
            this.buttonAjout.Name = "buttonAjout";
            this.buttonAjout.Size = new System.Drawing.Size(46, 23);
            this.buttonAjout.TabIndex = 18;
            this.buttonAjout.Text = "+";
            this.buttonAjout.UseVisualStyleBackColor = true;
            this.buttonAjout.Click += new System.EventHandler(this.buttonAjout_Click);
            // 
            // buttonSupprim
            // 
            this.buttonSupprim.Location = new System.Drawing.Point(224, 265);
            this.buttonSupprim.Name = "buttonSupprim";
            this.buttonSupprim.Size = new System.Drawing.Size(46, 23);
            this.buttonSupprim.TabIndex = 19;
            this.buttonSupprim.Text = "-";
            this.buttonSupprim.UseVisualStyleBackColor = true;
            this.buttonSupprim.Click += new System.EventHandler(this.buttonSupprim_Click);
            // 
            // btn_tournee
            // 
            this.btn_tournee.Location = new System.Drawing.Point(352, 265);
            this.btn_tournee.Name = "btn_tournee";
            this.btn_tournee.Size = new System.Drawing.Size(104, 23);
            this.btn_tournee.TabIndex = 20;
            this.btn_tournee.Text = "liste de tournées";
            this.btn_tournee.UseVisualStyleBackColor = true;
            this.btn_tournee.Click += new System.EventHandler(this.btn_tournee_Click);
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(491, 265);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(75, 23);
            this.buttonFermer.TabIndex = 21;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // buttonModif
            // 
            this.buttonModif.Location = new System.Drawing.Point(277, 265);
            this.buttonModif.Name = "buttonModif";
            this.buttonModif.Size = new System.Drawing.Size(45, 23);
            this.buttonModif.TabIndex = 22;
            this.buttonModif.Text = "mod";
            this.buttonModif.UseVisualStyleBackColor = true;
            this.buttonModif.Click += new System.EventHandler(this.buttonModif_Click);
            // 
            // duree_tb
            // 
            this.duree_tb.Location = new System.Drawing.Point(92, 210);
            this.duree_tb.Name = "duree_tb";
            this.duree_tb.Size = new System.Drawing.Size(100, 20);
            this.duree_tb.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Durée";
            // 
            // FormTournee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 300);
            this.Controls.Add(this.buttonModif);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.btn_tournee);
            this.Controls.Add(this.buttonSupprim);
            this.Controls.Add(this.buttonAjout);
            this.Controls.Add(this.buttonFin);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.buttonPrecedent);
            this.Controls.Add(this.buttonDebut);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBoxE);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.intitul_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_facture);
            this.Controls.Add(this.btn_devis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.facture_tb);
            this.Controls.Add(this.devis_tb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.label1);
            this.Name = "FormTournee";
            this.Text = "FormTournee";
            this.Load += new System.EventHandler(this.FormTournee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.TextBox devis_tb;
        private System.Windows.Forms.TextBox facture_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_devis;
        private System.Windows.Forms.Button btn_facture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox intitul_tb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox arrivee_tb;
        private System.Windows.Forms.TextBox depart_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nombrej_tb;
        private System.Windows.Forms.TextBox period_tb;
        private System.Windows.Forms.TextBox frequence_tb;
        private System.Windows.Forms.CheckBox checkBoxE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonDebut;
        private System.Windows.Forms.Button buttonPrecedent;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonFin;
        private System.Windows.Forms.Button buttonAjout;
        private System.Windows.Forms.Button buttonSupprim;
        private System.Windows.Forms.Button btn_tournee;
        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.Button buttonModif;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox duree_tb;
    }
}