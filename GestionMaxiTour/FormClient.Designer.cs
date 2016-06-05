namespace GestionMaxiTour
{
    partial class FormClient
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
            this.labelIdClient = new System.Windows.Forms.Label();
            this.labelNomClient = new System.Windows.Forms.Label();
            this.labelPrenomClient = new System.Windows.Forms.Label();
            this.labelNSSClient = new System.Windows.Forms.Label();
            this.labelAdresseClient = new System.Windows.Forms.Label();
            this.labelCPClient = new System.Windows.Forms.Label();
            this.labelVilleClient = new System.Windows.Forms.Label();
            this.labelTelClient = new System.Windows.Forms.Label();
            this.labelmailClient = new System.Windows.Forms.Label();
            this.labelRaisonSocialeClient = new System.Windows.Forms.Label();
            this.labelSiretClient = new System.Windows.Forms.Label();
            this.labelCodeNafClient = new System.Windows.Forms.Label();
            this.IdClient_tb = new System.Windows.Forms.TextBox();
            this.nom_tb = new System.Windows.Forms.TextBox();
            this.prenom_tb = new System.Windows.Forms.TextBox();
            this.numsecu_tb = new System.Windows.Forms.TextBox();
            this.adresse_tb = new System.Windows.Forms.TextBox();
            this.cp_tb = new System.Windows.Forms.TextBox();
            this.ville_tb = new System.Windows.Forms.TextBox();
            this.tel_tb = new System.Windows.Forms.TextBox();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.raisonssociale_tb = new System.Windows.Forms.TextBox();
            this.siret_tb = new System.Windows.Forms.TextBox();
            this.codenaf_tb = new System.Windows.Forms.TextBox();
            this.buttonDebut = new System.Windows.Forms.Button();
            this.buttonPrecedent = new System.Windows.Forms.Button();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.buttonFin = new System.Windows.Forms.Button();
            this.buttonAjout = new System.Windows.Forms.Button();
            this.buttonSupprim = new System.Windows.Forms.Button();
            this.buttonModif = new System.Windows.Forms.Button();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.dataGridClient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClient)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIdClient
            // 
            this.labelIdClient.AutoSize = true;
            this.labelIdClient.Location = new System.Drawing.Point(31, 14);
            this.labelIdClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIdClient.Name = "labelIdClient";
            this.labelIdClient.Size = new System.Drawing.Size(53, 13);
            this.labelIdClient.TabIndex = 0;
            this.labelIdClient.Text = "Numéro  :";
            // 
            // labelNomClient
            // 
            this.labelNomClient.AutoSize = true;
            this.labelNomClient.Location = new System.Drawing.Point(32, 79);
            this.labelNomClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomClient.Name = "labelNomClient";
            this.labelNomClient.Size = new System.Drawing.Size(35, 13);
            this.labelNomClient.TabIndex = 1;
            this.labelNomClient.Text = "Nom :";
            // 
            // labelPrenomClient
            // 
            this.labelPrenomClient.AutoSize = true;
            this.labelPrenomClient.Location = new System.Drawing.Point(32, 103);
            this.labelPrenomClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrenomClient.Name = "labelPrenomClient";
            this.labelPrenomClient.Size = new System.Drawing.Size(49, 13);
            this.labelPrenomClient.TabIndex = 2;
            this.labelPrenomClient.Text = "Prénom :";
            // 
            // labelNSSClient
            // 
            this.labelNSSClient.AutoSize = true;
            this.labelNSSClient.Location = new System.Drawing.Point(30, 40);
            this.labelNSSClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNSSClient.Name = "labelNSSClient";
            this.labelNSSClient.Size = new System.Drawing.Size(93, 13);
            this.labelNSSClient.TabIndex = 3;
            this.labelNSSClient.Text = "Sécurité Sociale : ";
            // 
            // labelAdresseClient
            // 
            this.labelAdresseClient.AutoSize = true;
            this.labelAdresseClient.Location = new System.Drawing.Point(30, 139);
            this.labelAdresseClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdresseClient.Name = "labelAdresseClient";
            this.labelAdresseClient.Size = new System.Drawing.Size(54, 13);
            this.labelAdresseClient.TabIndex = 4;
            this.labelAdresseClient.Text = "Adresse : ";
            // 
            // labelCPClient
            // 
            this.labelCPClient.AutoSize = true;
            this.labelCPClient.Location = new System.Drawing.Point(30, 165);
            this.labelCPClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCPClient.Name = "labelCPClient";
            this.labelCPClient.Size = new System.Drawing.Size(70, 13);
            this.labelCPClient.TabIndex = 5;
            this.labelCPClient.Text = "Code Postal :";
            // 
            // labelVilleClient
            // 
            this.labelVilleClient.AutoSize = true;
            this.labelVilleClient.Location = new System.Drawing.Point(30, 189);
            this.labelVilleClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVilleClient.Name = "labelVilleClient";
            this.labelVilleClient.Size = new System.Drawing.Size(32, 13);
            this.labelVilleClient.TabIndex = 6;
            this.labelVilleClient.Text = "Ville :";
            // 
            // labelTelClient
            // 
            this.labelTelClient.AutoSize = true;
            this.labelTelClient.Location = new System.Drawing.Point(30, 209);
            this.labelTelClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTelClient.Name = "labelTelClient";
            this.labelTelClient.Size = new System.Drawing.Size(64, 13);
            this.labelTelClient.TabIndex = 7;
            this.labelTelClient.Text = "Téléphone :";
            // 
            // labelmailClient
            // 
            this.labelmailClient.AutoSize = true;
            this.labelmailClient.Location = new System.Drawing.Point(30, 241);
            this.labelmailClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelmailClient.Name = "labelmailClient";
            this.labelmailClient.Size = new System.Drawing.Size(38, 13);
            this.labelmailClient.TabIndex = 8;
            this.labelmailClient.Text = "Email :";
            // 
            // labelRaisonSocialeClient
            // 
            this.labelRaisonSocialeClient.AutoSize = true;
            this.labelRaisonSocialeClient.Location = new System.Drawing.Point(30, 269);
            this.labelRaisonSocialeClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRaisonSocialeClient.Name = "labelRaisonSocialeClient";
            this.labelRaisonSocialeClient.Size = new System.Drawing.Size(84, 13);
            this.labelRaisonSocialeClient.TabIndex = 9;
            this.labelRaisonSocialeClient.Text = "Raison Sociale :";
            // 
            // labelSiretClient
            // 
            this.labelSiretClient.AutoSize = true;
            this.labelSiretClient.Location = new System.Drawing.Point(30, 293);
            this.labelSiretClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSiretClient.Name = "labelSiretClient";
            this.labelSiretClient.Size = new System.Drawing.Size(34, 13);
            this.labelSiretClient.TabIndex = 10;
            this.labelSiretClient.Text = "Siret :";
            // 
            // labelCodeNafClient
            // 
            this.labelCodeNafClient.AutoSize = true;
            this.labelCodeNafClient.Location = new System.Drawing.Point(30, 322);
            this.labelCodeNafClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodeNafClient.Name = "labelCodeNafClient";
            this.labelCodeNafClient.Size = new System.Drawing.Size(58, 13);
            this.labelCodeNafClient.TabIndex = 11;
            this.labelCodeNafClient.Text = "Code Naf :";
            // 
            // IdClient_tb
            // 
            this.IdClient_tb.Enabled = false;
            this.IdClient_tb.Location = new System.Drawing.Point(123, 14);
            this.IdClient_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IdClient_tb.Name = "IdClient_tb";
            this.IdClient_tb.Size = new System.Drawing.Size(114, 20);
            this.IdClient_tb.TabIndex = 12;
            // 
            // nom_tb
            // 
            this.nom_tb.Location = new System.Drawing.Point(123, 76);
            this.nom_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nom_tb.Name = "nom_tb";
            this.nom_tb.Size = new System.Drawing.Size(114, 20);
            this.nom_tb.TabIndex = 13;
            // 
            // prenom_tb
            // 
            this.prenom_tb.Location = new System.Drawing.Point(123, 100);
            this.prenom_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prenom_tb.Name = "prenom_tb";
            this.prenom_tb.Size = new System.Drawing.Size(114, 20);
            this.prenom_tb.TabIndex = 14;
            // 
            // numsecu_tb
            // 
            this.numsecu_tb.Location = new System.Drawing.Point(123, 37);
            this.numsecu_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numsecu_tb.Name = "numsecu_tb";
            this.numsecu_tb.Size = new System.Drawing.Size(114, 20);
            this.numsecu_tb.TabIndex = 15;
            // 
            // adresse_tb
            // 
            this.adresse_tb.Location = new System.Drawing.Point(123, 139);
            this.adresse_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adresse_tb.Name = "adresse_tb";
            this.adresse_tb.Size = new System.Drawing.Size(194, 20);
            this.adresse_tb.TabIndex = 16;
            // 
            // cp_tb
            // 
            this.cp_tb.Location = new System.Drawing.Point(123, 162);
            this.cp_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cp_tb.Name = "cp_tb";
            this.cp_tb.Size = new System.Drawing.Size(114, 20);
            this.cp_tb.TabIndex = 17;
            // 
            // ville_tb
            // 
            this.ville_tb.Location = new System.Drawing.Point(123, 186);
            this.ville_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ville_tb.Name = "ville_tb";
            this.ville_tb.Size = new System.Drawing.Size(114, 20);
            this.ville_tb.TabIndex = 18;
            // 
            // tel_tb
            // 
            this.tel_tb.Location = new System.Drawing.Point(123, 209);
            this.tel_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tel_tb.Name = "tel_tb";
            this.tel_tb.Size = new System.Drawing.Size(114, 20);
            this.tel_tb.TabIndex = 19;
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(123, 241);
            this.email_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(194, 20);
            this.email_tb.TabIndex = 20;
            // 
            // raisonssociale_tb
            // 
            this.raisonssociale_tb.Location = new System.Drawing.Point(123, 269);
            this.raisonssociale_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.raisonssociale_tb.Name = "raisonssociale_tb";
            this.raisonssociale_tb.Size = new System.Drawing.Size(194, 20);
            this.raisonssociale_tb.TabIndex = 21;
            // 
            // siret_tb
            // 
            this.siret_tb.Location = new System.Drawing.Point(123, 293);
            this.siret_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siret_tb.Name = "siret_tb";
            this.siret_tb.Size = new System.Drawing.Size(194, 20);
            this.siret_tb.TabIndex = 22;
            // 
            // codenaf_tb
            // 
            this.codenaf_tb.Location = new System.Drawing.Point(123, 319);
            this.codenaf_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codenaf_tb.Name = "codenaf_tb";
            this.codenaf_tb.Size = new System.Drawing.Size(194, 20);
            this.codenaf_tb.TabIndex = 23;
            // 
            // buttonDebut
            // 
            this.buttonDebut.Location = new System.Drawing.Point(33, 354);
            this.buttonDebut.Name = "buttonDebut";
            this.buttonDebut.Size = new System.Drawing.Size(33, 23);
            this.buttonDebut.TabIndex = 24;
            this.buttonDebut.Text = "<<";
            this.buttonDebut.UseVisualStyleBackColor = true;
            this.buttonDebut.Click += new System.EventHandler(this.buttonDebut_Click);
            // 
            // buttonPrecedent
            // 
            this.buttonPrecedent.Location = new System.Drawing.Point(72, 353);
            this.buttonPrecedent.Name = "buttonPrecedent";
            this.buttonPrecedent.Size = new System.Drawing.Size(33, 23);
            this.buttonPrecedent.TabIndex = 25;
            this.buttonPrecedent.Text = "<";
            this.buttonPrecedent.UseVisualStyleBackColor = true;
            this.buttonPrecedent.Click += new System.EventHandler(this.buttonPrecedent_Click);
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Location = new System.Drawing.Point(111, 353);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(33, 23);
            this.buttonSuivant.TabIndex = 26;
            this.buttonSuivant.Text = ">";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.buttonSuivant_Click);
            // 
            // buttonFin
            // 
            this.buttonFin.Location = new System.Drawing.Point(150, 353);
            this.buttonFin.Name = "buttonFin";
            this.buttonFin.Size = new System.Drawing.Size(33, 23);
            this.buttonFin.TabIndex = 27;
            this.buttonFin.Text = ">>";
            this.buttonFin.UseVisualStyleBackColor = true;
            this.buttonFin.Click += new System.EventHandler(this.buttonFin_Click);
            // 
            // buttonAjout
            // 
            this.buttonAjout.Location = new System.Drawing.Point(203, 353);
            this.buttonAjout.Name = "buttonAjout";
            this.buttonAjout.Size = new System.Drawing.Size(45, 23);
            this.buttonAjout.TabIndex = 28;
            this.buttonAjout.Text = "+";
            this.buttonAjout.UseVisualStyleBackColor = true;
            this.buttonAjout.Click += new System.EventHandler(this.buttonAjout_Click);
            // 
            // buttonSupprim
            // 
            this.buttonSupprim.Location = new System.Drawing.Point(254, 354);
            this.buttonSupprim.Name = "buttonSupprim";
            this.buttonSupprim.Size = new System.Drawing.Size(45, 23);
            this.buttonSupprim.TabIndex = 29;
            this.buttonSupprim.Text = "-";
            this.buttonSupprim.UseVisualStyleBackColor = true;
            this.buttonSupprim.Click += new System.EventHandler(this.buttonSupprim_Click);
            // 
            // buttonModif
            // 
            this.buttonModif.Location = new System.Drawing.Point(305, 354);
            this.buttonModif.Name = "buttonModif";
            this.buttonModif.Size = new System.Drawing.Size(44, 23);
            this.buttonModif.TabIndex = 30;
            this.buttonModif.Text = "modif";
            this.buttonModif.UseVisualStyleBackColor = true;
            this.buttonModif.Click += new System.EventHandler(this.buttonModif_Click);
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(581, 355);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(75, 23);
            this.buttonFermer.TabIndex = 31;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // dataGridClient
            // 
            this.dataGridClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClient.Location = new System.Drawing.Point(369, 28);
            this.dataGridClient.Name = "dataGridClient";
            this.dataGridClient.Size = new System.Drawing.Size(580, 307);
            this.dataGridClient.TabIndex = 32;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 390);
            this.Controls.Add(this.dataGridClient);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.buttonModif);
            this.Controls.Add(this.buttonSupprim);
            this.Controls.Add(this.buttonAjout);
            this.Controls.Add(this.buttonFin);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.buttonPrecedent);
            this.Controls.Add(this.buttonDebut);
            this.Controls.Add(this.codenaf_tb);
            this.Controls.Add(this.siret_tb);
            this.Controls.Add(this.raisonssociale_tb);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.tel_tb);
            this.Controls.Add(this.ville_tb);
            this.Controls.Add(this.cp_tb);
            this.Controls.Add(this.adresse_tb);
            this.Controls.Add(this.numsecu_tb);
            this.Controls.Add(this.prenom_tb);
            this.Controls.Add(this.nom_tb);
            this.Controls.Add(this.IdClient_tb);
            this.Controls.Add(this.labelCodeNafClient);
            this.Controls.Add(this.labelSiretClient);
            this.Controls.Add(this.labelRaisonSocialeClient);
            this.Controls.Add(this.labelmailClient);
            this.Controls.Add(this.labelTelClient);
            this.Controls.Add(this.labelVilleClient);
            this.Controls.Add(this.labelCPClient);
            this.Controls.Add(this.labelAdresseClient);
            this.Controls.Add(this.labelNSSClient);
            this.Controls.Add(this.labelPrenomClient);
            this.Controls.Add(this.labelNomClient);
            this.Controls.Add(this.labelIdClient);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormClient";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.FormClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIdClient;
        private System.Windows.Forms.Label labelNomClient;
        private System.Windows.Forms.Label labelPrenomClient;
        private System.Windows.Forms.Label labelNSSClient;
        private System.Windows.Forms.Label labelAdresseClient;
        private System.Windows.Forms.Label labelCPClient;
        private System.Windows.Forms.Label labelVilleClient;
        private System.Windows.Forms.Label labelTelClient;
        private System.Windows.Forms.Label labelmailClient;
        private System.Windows.Forms.Label labelRaisonSocialeClient;
        private System.Windows.Forms.Label labelSiretClient;
        private System.Windows.Forms.Label labelCodeNafClient;
        private System.Windows.Forms.TextBox IdClient_tb;
        private System.Windows.Forms.TextBox nom_tb;
        private System.Windows.Forms.TextBox prenom_tb;
        private System.Windows.Forms.TextBox numsecu_tb;
        private System.Windows.Forms.TextBox adresse_tb;
        private System.Windows.Forms.TextBox cp_tb;
        private System.Windows.Forms.TextBox ville_tb;
        private System.Windows.Forms.TextBox tel_tb;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.TextBox raisonssociale_tb;
        private System.Windows.Forms.TextBox siret_tb;
        private System.Windows.Forms.TextBox codenaf_tb;
        private System.Windows.Forms.Button buttonDebut;
        private System.Windows.Forms.Button buttonPrecedent;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.Button buttonFin;
        private System.Windows.Forms.Button buttonAjout;
        private System.Windows.Forms.Button buttonSupprim;
        private System.Windows.Forms.Button buttonModif;
        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.DataGridView dataGridClient;
    }
}