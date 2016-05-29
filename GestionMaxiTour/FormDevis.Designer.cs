namespace GestionMaxiTour
{
    partial class FormDevis
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
            this.labelid = new System.Windows.Forms.Label();
            this.labelEtat = new System.Windows.Forms.Label();
            this.labelPeage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFraisEmploye = new System.Windows.Forms.Label();
            this.labelAssurance = new System.Windows.Forms.Label();
            this.labelAm = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.etat_tb = new System.Windows.Forms.TextBox();
            this.prixpeage_tb = new System.Windows.Forms.TextBox();
            this.prixmaint_tb = new System.Windows.Forms.TextBox();
            this.prixassur_tb = new System.Windows.Forms.TextBox();
            this.fraisemploye_tb = new System.Windows.Forms.TextBox();
            this.ammort_tb = new System.Windows.Forms.TextBox();
            this.ressource_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kmclient_tb = new System.Windows.Forms.TextBox();
            this.kmallee_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kmretour_tb = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalkm_tb = new System.Windows.Forms.TextBox();
            this.groupBoxTotaux = new System.Windows.Forms.GroupBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonDebut = new System.Windows.Forms.Button();
            this.buttonPrecedent = new System.Windows.Forms.Button();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.buttonFin = new System.Windows.Forms.Button();
            this.buttonAjout = new System.Windows.Forms.Button();
            this.buttonSupprim = new System.Windows.Forms.Button();
            this.buttonModif = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBoxTotaux.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(18, 26);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(53, 13);
            this.labelid.TabIndex = 0;
            this.labelid.Text = "Identifiant";
            // 
            // labelEtat
            // 
            this.labelEtat.AutoSize = true;
            this.labelEtat.Location = new System.Drawing.Point(18, 60);
            this.labelEtat.Name = "labelEtat";
            this.labelEtat.Size = new System.Drawing.Size(26, 13);
            this.labelEtat.TabIndex = 1;
            this.labelEtat.Text = "Etat";
            // 
            // labelPeage
            // 
            this.labelPeage.AutoSize = true;
            this.labelPeage.Location = new System.Drawing.Point(20, 95);
            this.labelPeage.Name = "labelPeage";
            this.labelPeage.Size = new System.Drawing.Size(55, 13);
            this.labelPeage.TabIndex = 2;
            this.labelPeage.Text = "PrixPeage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prix Maintenance : ";
            // 
            // labelFraisEmploye
            // 
            this.labelFraisEmploye.AutoSize = true;
            this.labelFraisEmploye.Location = new System.Drawing.Point(18, 214);
            this.labelFraisEmploye.Name = "labelFraisEmploye";
            this.labelFraisEmploye.Size = new System.Drawing.Size(92, 13);
            this.labelFraisEmploye.TabIndex = 5;
            this.labelFraisEmploye.Text = "Frais Employé(s) : ";
            // 
            // labelAssurance
            // 
            this.labelAssurance.AutoSize = true;
            this.labelAssurance.Location = new System.Drawing.Point(18, 177);
            this.labelAssurance.Name = "labelAssurance";
            this.labelAssurance.Size = new System.Drawing.Size(85, 13);
            this.labelAssurance.TabIndex = 6;
            this.labelAssurance.Text = "Prix assurance : ";
            // 
            // labelAm
            // 
            this.labelAm.AutoSize = true;
            this.labelAm.Location = new System.Drawing.Point(18, 252);
            this.labelAm.Name = "labelAm";
            this.labelAm.Size = new System.Drawing.Size(83, 13);
            this.labelAm.TabIndex = 7;
            this.labelAm.Text = "Ammortissement";
            // 
            // id_tb
            // 
            this.id_tb.Enabled = false;
            this.id_tb.Location = new System.Drawing.Point(139, 26);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(121, 20);
            this.id_tb.TabIndex = 8;
            // 
            // etat_tb
            // 
            this.etat_tb.Location = new System.Drawing.Point(139, 60);
            this.etat_tb.Name = "etat_tb";
            this.etat_tb.Size = new System.Drawing.Size(121, 20);
            this.etat_tb.TabIndex = 9;
            // 
            // prixpeage_tb
            // 
            this.prixpeage_tb.Location = new System.Drawing.Point(139, 92);
            this.prixpeage_tb.Name = "prixpeage_tb";
            this.prixpeage_tb.Size = new System.Drawing.Size(121, 20);
            this.prixpeage_tb.TabIndex = 10;
            // 
            // prixmaint_tb
            // 
            this.prixmaint_tb.Location = new System.Drawing.Point(139, 132);
            this.prixmaint_tb.Name = "prixmaint_tb";
            this.prixmaint_tb.Size = new System.Drawing.Size(121, 20);
            this.prixmaint_tb.TabIndex = 11;
            // 
            // prixassur_tb
            // 
            this.prixassur_tb.Location = new System.Drawing.Point(139, 174);
            this.prixassur_tb.Name = "prixassur_tb";
            this.prixassur_tb.Size = new System.Drawing.Size(121, 20);
            this.prixassur_tb.TabIndex = 12;
            // 
            // fraisemploye_tb
            // 
            this.fraisemploye_tb.Location = new System.Drawing.Point(139, 214);
            this.fraisemploye_tb.Name = "fraisemploye_tb";
            this.fraisemploye_tb.Size = new System.Drawing.Size(121, 20);
            this.fraisemploye_tb.TabIndex = 14;
            // 
            // ammort_tb
            // 
            this.ammort_tb.Location = new System.Drawing.Point(139, 249);
            this.ammort_tb.Name = "ammort_tb";
            this.ammort_tb.Size = new System.Drawing.Size(121, 20);
            this.ammort_tb.TabIndex = 15;
            // 
            // ressource_tb
            // 
            this.ressource_tb.Location = new System.Drawing.Point(138, 280);
            this.ressource_tb.Name = "ressource_tb";
            this.ressource_tb.Size = new System.Drawing.Size(121, 20);
            this.ressource_tb.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ressource(s) : ";
            // 
            // kmclient_tb
            // 
            this.kmclient_tb.Location = new System.Drawing.Point(424, 22);
            this.kmclient_tb.Name = "kmclient_tb";
            this.kmclient_tb.Size = new System.Drawing.Size(121, 20);
            this.kmclient_tb.TabIndex = 18;
            // 
            // kmallee_tb
            // 
            this.kmallee_tb.Location = new System.Drawing.Point(424, 63);
            this.kmallee_tb.Name = "kmallee_tb";
            this.kmallee_tb.Size = new System.Drawing.Size(121, 20);
            this.kmallee_tb.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Kilomètres Client : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Kilomètres  Allée : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Kilomètres Retour : ";
            // 
            // kmretour_tb
            // 
            this.kmretour_tb.Location = new System.Drawing.Point(424, 99);
            this.kmretour_tb.Name = "kmretour_tb";
            this.kmretour_tb.Size = new System.Drawing.Size(121, 20);
            this.kmretour_tb.TabIndex = 23;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(426, 170);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(121, 20);
            this.textBox12.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Volume Marchandise : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Total Kilomètres : ";
            // 
            // totalkm_tb
            // 
            this.totalkm_tb.Enabled = false;
            this.totalkm_tb.Location = new System.Drawing.Point(424, 135);
            this.totalkm_tb.Name = "totalkm_tb";
            this.totalkm_tb.Size = new System.Drawing.Size(121, 20);
            this.totalkm_tb.TabIndex = 27;
            // 
            // groupBoxTotaux
            // 
            this.groupBoxTotaux.Controls.Add(this.textBox19);
            this.groupBoxTotaux.Controls.Add(this.label14);
            this.groupBoxTotaux.Controls.Add(this.label13);
            this.groupBoxTotaux.Controls.Add(this.label12);
            this.groupBoxTotaux.Controls.Add(this.label11);
            this.groupBoxTotaux.Controls.Add(this.textBox18);
            this.groupBoxTotaux.Controls.Add(this.textBox17);
            this.groupBoxTotaux.Controls.Add(this.textBox16);
            this.groupBoxTotaux.Controls.Add(this.textBox15);
            this.groupBoxTotaux.Controls.Add(this.label10);
            this.groupBoxTotaux.Location = new System.Drawing.Point(590, 26);
            this.groupBoxTotaux.Name = "groupBoxTotaux";
            this.groupBoxTotaux.Size = new System.Drawing.Size(252, 274);
            this.groupBoxTotaux.TabIndex = 30;
            this.groupBoxTotaux.TabStop = false;
            this.groupBoxTotaux.Text = "Prix Totaux";
            this.groupBoxTotaux.Enter += new System.EventHandler(this.groupBoxTotaux_Enter);
            // 
            // textBox19
            // 
            this.textBox19.Enabled = false;
            this.textBox19.Location = new System.Drawing.Point(118, 147);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(100, 20);
            this.textBox19.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Prix Chauffeur";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Prix Véhicule : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 241);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Total : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Prix Facturation : ";
            // 
            // textBox18
            // 
            this.textBox18.Enabled = false;
            this.textBox18.Location = new System.Drawing.Point(118, 188);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 20);
            this.textBox18.TabIndex = 32;
            // 
            // textBox17
            // 
            this.textBox17.Enabled = false;
            this.textBox17.Location = new System.Drawing.Point(118, 238);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 20);
            this.textBox17.TabIndex = 31;
            // 
            // textBox16
            // 
            this.textBox16.Enabled = false;
            this.textBox16.Location = new System.Drawing.Point(118, 110);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(100, 20);
            this.textBox16.TabIndex = 30;
            // 
            // textBox15
            // 
            this.textBox15.Enabled = false;
            this.textBox15.Location = new System.Drawing.Point(118, 41);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 20);
            this.textBox15.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Prix au kilomètre";
            // 
            // buttonDebut
            // 
            this.buttonDebut.Location = new System.Drawing.Point(12, 324);
            this.buttonDebut.Name = "buttonDebut";
            this.buttonDebut.Size = new System.Drawing.Size(36, 23);
            this.buttonDebut.TabIndex = 32;
            this.buttonDebut.Text = "<<";
            this.buttonDebut.UseVisualStyleBackColor = true;
            this.buttonDebut.Click += new System.EventHandler(this.buttonDebut_Click);
            // 
            // buttonPrecedent
            // 
            this.buttonPrecedent.Location = new System.Drawing.Point(54, 324);
            this.buttonPrecedent.Name = "buttonPrecedent";
            this.buttonPrecedent.Size = new System.Drawing.Size(36, 23);
            this.buttonPrecedent.TabIndex = 33;
            this.buttonPrecedent.Text = "<";
            this.buttonPrecedent.UseVisualStyleBackColor = true;
            this.buttonPrecedent.Click += new System.EventHandler(this.buttonPrecedent_Click);
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Location = new System.Drawing.Point(96, 324);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(36, 23);
            this.buttonSuivant.TabIndex = 34;
            this.buttonSuivant.Text = ">";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.buttonSuivant_Click);
            // 
            // buttonFin
            // 
            this.buttonFin.Location = new System.Drawing.Point(138, 324);
            this.buttonFin.Name = "buttonFin";
            this.buttonFin.Size = new System.Drawing.Size(36, 23);
            this.buttonFin.TabIndex = 35;
            this.buttonFin.Text = ">>";
            this.buttonFin.UseVisualStyleBackColor = true;
            this.buttonFin.Click += new System.EventHandler(this.buttonFin_Click);
            // 
            // buttonAjout
            // 
            this.buttonAjout.Location = new System.Drawing.Point(200, 324);
            this.buttonAjout.Name = "buttonAjout";
            this.buttonAjout.Size = new System.Drawing.Size(60, 23);
            this.buttonAjout.TabIndex = 36;
            this.buttonAjout.Text = "+";
            this.buttonAjout.UseVisualStyleBackColor = true;
            // 
            // buttonSupprim
            // 
            this.buttonSupprim.Location = new System.Drawing.Point(270, 324);
            this.buttonSupprim.Name = "buttonSupprim";
            this.buttonSupprim.Size = new System.Drawing.Size(60, 23);
            this.buttonSupprim.TabIndex = 37;
            this.buttonSupprim.Text = "-";
            this.buttonSupprim.UseVisualStyleBackColor = true;
            // 
            // buttonModif
            // 
            this.buttonModif.Location = new System.Drawing.Point(336, 324);
            this.buttonModif.Name = "buttonModif";
            this.buttonModif.Size = new System.Drawing.Size(60, 23);
            this.buttonModif.TabIndex = 38;
            this.buttonModif.Text = "mod";
            this.buttonModif.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(414, 324);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(121, 23);
            this.button8.TabIndex = 39;
            this.button8.Text = "liste des devis";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(673, 324);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(83, 23);
            this.buttonFermer.TabIndex = 40;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Date Début";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Date Fin";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(372, 225);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 43;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(372, 280);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 44;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(306, 251);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(239, 20);
            this.dateTimePicker1.TabIndex = 45;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(307, 199);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(238, 20);
            this.dateTimePicker2.TabIndex = 46;
            // 
            // FormDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 370);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.buttonModif);
            this.Controls.Add(this.buttonSupprim);
            this.Controls.Add(this.buttonAjout);
            this.Controls.Add(this.buttonFin);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.buttonPrecedent);
            this.Controls.Add(this.buttonDebut);
            this.Controls.Add(this.groupBoxTotaux);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.kmretour_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalkm_tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.kmallee_tb);
            this.Controls.Add(this.kmclient_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ressource_tb);
            this.Controls.Add(this.ammort_tb);
            this.Controls.Add(this.fraisemploye_tb);
            this.Controls.Add(this.prixassur_tb);
            this.Controls.Add(this.prixmaint_tb);
            this.Controls.Add(this.prixpeage_tb);
            this.Controls.Add(this.etat_tb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.labelAm);
            this.Controls.Add(this.labelAssurance);
            this.Controls.Add(this.labelFraisEmploye);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPeage);
            this.Controls.Add(this.labelEtat);
            this.Controls.Add(this.labelid);
            this.Name = "FormDevis";
            this.Text = "Saisir Devis";
            this.Load += new System.EventHandler(this.FormSaisirDevis_Load);
            this.groupBoxTotaux.ResumeLayout(false);
            this.groupBoxTotaux.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labelEtat;
        private System.Windows.Forms.Label labelPeage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFraisEmploye;
        private System.Windows.Forms.Label labelAssurance;
        private System.Windows.Forms.Label labelAm;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.TextBox etat_tb;
        private System.Windows.Forms.TextBox prixpeage_tb;
        private System.Windows.Forms.TextBox prixmaint_tb;
        private System.Windows.Forms.TextBox prixassur_tb;
        private System.Windows.Forms.TextBox fraisemploye_tb;
        private System.Windows.Forms.TextBox ammort_tb;
        private System.Windows.Forms.TextBox ressource_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kmclient_tb;
        private System.Windows.Forms.TextBox kmallee_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kmretour_tb;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox totalkm_tb;
        private System.Windows.Forms.GroupBox groupBoxTotaux;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonDebut;
        private System.Windows.Forms.Button buttonPrecedent;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.Button buttonFin;
        private System.Windows.Forms.Button buttonAjout;
        private System.Windows.Forms.Button buttonSupprim;
        private System.Windows.Forms.Button buttonModif;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}