namespace GestionMaxiTour
{
    partial class FormGestionTournee
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idT_tb = new System.Windows.Forms.TextBox();
            this.idCh_tb = new System.Windows.Forms.TextBox();
            this.idCa_tb = new System.Windows.Forms.TextBox();
            this.dateTimePickerAf = new System.Windows.Forms.DateTimePicker();
            this.affect_tb = new System.Windows.Forms.TextBox();
            this.chauffeur_btn = new System.Windows.Forms.Button();
            this.camion_btn = new System.Windows.Forms.Button();
            this.buttonAjout = new System.Windows.Forms.Button();
            this.buttonSupprim = new System.Windows.Forms.Button();
            this.buttonModif = new System.Windows.Forms.Button();
            this.buttonDebut = new System.Windows.Forms.Button();
            this.buttonPrecedent = new System.Windows.Forms.Button();
            this.buttonFin = new System.Windows.Forms.Button();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Affecter chauffeur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Affecter camion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identifiant Tournée";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date affectation ";
            // 
            // idT_tb
            // 
            this.idT_tb.Location = new System.Drawing.Point(129, 17);
            this.idT_tb.Name = "idT_tb";
            this.idT_tb.Size = new System.Drawing.Size(159, 20);
            this.idT_tb.TabIndex = 4;
            // 
            // idCh_tb
            // 
            this.idCh_tb.Location = new System.Drawing.Point(129, 50);
            this.idCh_tb.Name = "idCh_tb";
            this.idCh_tb.Size = new System.Drawing.Size(159, 20);
            this.idCh_tb.TabIndex = 5;
            // 
            // idCa_tb
            // 
            this.idCa_tb.Location = new System.Drawing.Point(129, 108);
            this.idCa_tb.Name = "idCa_tb";
            this.idCa_tb.Size = new System.Drawing.Size(159, 20);
            this.idCa_tb.TabIndex = 6;
            // 
            // dateTimePickerAf
            // 
            this.dateTimePickerAf.Location = new System.Drawing.Point(131, 215);
            this.dateTimePickerAf.Name = "dateTimePickerAf";
            this.dateTimePickerAf.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAf.TabIndex = 7;
            // 
            // affect_tb
            // 
            this.affect_tb.Enabled = false;
            this.affect_tb.Location = new System.Drawing.Point(131, 182);
            this.affect_tb.Name = "affect_tb";
            this.affect_tb.Size = new System.Drawing.Size(200, 20);
            this.affect_tb.TabIndex = 8;
            // 
            // chauffeur_btn
            // 
            this.chauffeur_btn.Location = new System.Drawing.Point(129, 79);
            this.chauffeur_btn.Name = "chauffeur_btn";
            this.chauffeur_btn.Size = new System.Drawing.Size(159, 23);
            this.chauffeur_btn.TabIndex = 9;
            this.chauffeur_btn.Text = "liste chauffeur";
            this.chauffeur_btn.UseVisualStyleBackColor = true;
            this.chauffeur_btn.Click += new System.EventHandler(this.chauffeur_btn_Click);
            // 
            // camion_btn
            // 
            this.camion_btn.Location = new System.Drawing.Point(129, 134);
            this.camion_btn.Name = "camion_btn";
            this.camion_btn.Size = new System.Drawing.Size(159, 23);
            this.camion_btn.TabIndex = 10;
            this.camion_btn.Text = "liste camion";
            this.camion_btn.UseVisualStyleBackColor = true;
            this.camion_btn.Click += new System.EventHandler(this.camion_btn_Click);
            // 
            // buttonAjout
            // 
            this.buttonAjout.Location = new System.Drawing.Point(183, 260);
            this.buttonAjout.Name = "buttonAjout";
            this.buttonAjout.Size = new System.Drawing.Size(46, 23);
            this.buttonAjout.TabIndex = 11;
            this.buttonAjout.Text = "+";
            this.buttonAjout.UseVisualStyleBackColor = true;
            this.buttonAjout.Click += new System.EventHandler(this.buttonAjout_Click);
            // 
            // buttonSupprim
            // 
            this.buttonSupprim.Location = new System.Drawing.Point(235, 260);
            this.buttonSupprim.Name = "buttonSupprim";
            this.buttonSupprim.Size = new System.Drawing.Size(46, 23);
            this.buttonSupprim.TabIndex = 12;
            this.buttonSupprim.Text = "-";
            this.buttonSupprim.UseVisualStyleBackColor = true;
            this.buttonSupprim.Click += new System.EventHandler(this.buttonSupprim_Click);
            // 
            // buttonModif
            // 
            this.buttonModif.Location = new System.Drawing.Point(287, 260);
            this.buttonModif.Name = "buttonModif";
            this.buttonModif.Size = new System.Drawing.Size(46, 23);
            this.buttonModif.TabIndex = 13;
            this.buttonModif.Text = "mod";
            this.buttonModif.UseVisualStyleBackColor = true;
            this.buttonModif.Click += new System.EventHandler(this.buttonModif_Click);
            // 
            // buttonDebut
            // 
            this.buttonDebut.Location = new System.Drawing.Point(29, 260);
            this.buttonDebut.Name = "buttonDebut";
            this.buttonDebut.Size = new System.Drawing.Size(27, 23);
            this.buttonDebut.TabIndex = 14;
            this.buttonDebut.Text = "<<";
            this.buttonDebut.UseVisualStyleBackColor = true;
            this.buttonDebut.Click += new System.EventHandler(this.buttonDebut_Click);
            // 
            // buttonPrecedent
            // 
            this.buttonPrecedent.Location = new System.Drawing.Point(62, 260);
            this.buttonPrecedent.Name = "buttonPrecedent";
            this.buttonPrecedent.Size = new System.Drawing.Size(27, 23);
            this.buttonPrecedent.TabIndex = 15;
            this.buttonPrecedent.Text = "<";
            this.buttonPrecedent.UseVisualStyleBackColor = true;
            this.buttonPrecedent.Click += new System.EventHandler(this.buttonPrecedent_Click);
            // 
            // buttonFin
            // 
            this.buttonFin.Location = new System.Drawing.Point(128, 260);
            this.buttonFin.Name = "buttonFin";
            this.buttonFin.Size = new System.Drawing.Size(27, 23);
            this.buttonFin.TabIndex = 16;
            this.buttonFin.Text = ">>";
            this.buttonFin.UseVisualStyleBackColor = true;
            this.buttonFin.Click += new System.EventHandler(this.buttonFin_Click);
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Location = new System.Drawing.Point(95, 260);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(27, 23);
            this.buttonSuivant.TabIndex = 17;
            this.buttonSuivant.Text = ">";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.buttonSuivant_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(131, 298);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 18;
            this.button7.Text = "Fermer";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // FormGestionTournee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 333);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.buttonFin);
            this.Controls.Add(this.buttonPrecedent);
            this.Controls.Add(this.buttonDebut);
            this.Controls.Add(this.buttonModif);
            this.Controls.Add(this.buttonSupprim);
            this.Controls.Add(this.buttonAjout);
            this.Controls.Add(this.camion_btn);
            this.Controls.Add(this.chauffeur_btn);
            this.Controls.Add(this.affect_tb);
            this.Controls.Add(this.dateTimePickerAf);
            this.Controls.Add(this.idCa_tb);
            this.Controls.Add(this.idCh_tb);
            this.Controls.Add(this.idT_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormGestionTournee";
            this.Text = "GestionTournee";
            this.Load += new System.EventHandler(this.GestionTournee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idT_tb;
        private System.Windows.Forms.TextBox idCh_tb;
        private System.Windows.Forms.TextBox idCa_tb;
        private System.Windows.Forms.DateTimePicker dateTimePickerAf;
        private System.Windows.Forms.TextBox affect_tb;
        private System.Windows.Forms.Button chauffeur_btn;
        private System.Windows.Forms.Button camion_btn;
        private System.Windows.Forms.Button buttonAjout;
        private System.Windows.Forms.Button buttonSupprim;
        private System.Windows.Forms.Button buttonModif;
        private System.Windows.Forms.Button buttonDebut;
        private System.Windows.Forms.Button buttonPrecedent;
        private System.Windows.Forms.Button buttonFin;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.Button button7;
    }
}