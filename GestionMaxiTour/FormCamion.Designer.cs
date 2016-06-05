namespace GestionMaxiTour
{
    partial class FormCamion
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
            this.labelMarque = new System.Windows.Forms.Label();
            this.labelModele = new System.Windows.Forms.Label();
            this.labelImmatriculation = new System.Windows.Forms.Label();
            this.labelEtat = new System.Windows.Forms.Label();
            this.labelKilometrage = new System.Windows.Forms.Label();
            this.labelConsommation = new System.Windows.Forms.Label();
            this.labelCarburant = new System.Windows.Forms.Label();
            this.labelDataAchat = new System.Windows.Forms.Label();
            this.labelDateMiseCirculation = new System.Windows.Forms.Label();
            this.labelHayonPuissance = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelLongInter = new System.Windows.Forms.Label();
            this.LabelLargInt = new System.Windows.Forms.Label();
            this.labelHautInt = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelVolumeLibre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxEtat = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idCamion_tb = new System.Windows.Forms.TextBox();
            this.datec_tb = new System.Windows.Forms.TextBox();
            this.datea_tb = new System.Windows.Forms.TextBox();
            this.dateTimePickerCirculation = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAchat = new System.Windows.Forms.DateTimePicker();
            this.carbu_tb = new System.Windows.Forms.TextBox();
            this.conso_tb = new System.Windows.Forms.TextBox();
            this.km_tb = new System.Windows.Forms.TextBox();
            this.immat_tb = new System.Windows.Forms.TextBox();
            this.modele_tb = new System.Windows.Forms.TextBox();
            this.marque_tb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxHayon = new System.Windows.Forms.CheckBox();
            this.ptac_tb = new System.Windows.Forms.TextBox();
            this.poidv_tb = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.largint_tb = new System.Windows.Forms.TextBox();
            this.hautint_tb = new System.Windows.Forms.TextBox();
            this.longint_tb = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.volumelibre_tb = new System.Windows.Forms.TextBox();
            this.volume_tb = new System.Windows.Forms.TextBox();
            this.buttonDebut = new System.Windows.Forms.Button();
            this.buttonPrecedent = new System.Windows.Forms.Button();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.buttonFin = new System.Windows.Forms.Button();
            this.buttonAjout = new System.Windows.Forms.Button();
            this.buttonSupprim = new System.Windows.Forms.Button();
            this.buttonModif = new System.Windows.Forms.Button();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.buttonListeC = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMarque
            // 
            this.labelMarque.AutoSize = true;
            this.labelMarque.Location = new System.Drawing.Point(8, 75);
            this.labelMarque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarque.Name = "labelMarque";
            this.labelMarque.Size = new System.Drawing.Size(49, 13);
            this.labelMarque.TabIndex = 0;
            this.labelMarque.Text = "Marque :";
            // 
            // labelModele
            // 
            this.labelModele.AutoSize = true;
            this.labelModele.Location = new System.Drawing.Point(8, 105);
            this.labelModele.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModele.Name = "labelModele";
            this.labelModele.Size = new System.Drawing.Size(48, 13);
            this.labelModele.TabIndex = 1;
            this.labelModele.Text = "Modèle :";
            // 
            // labelImmatriculation
            // 
            this.labelImmatriculation.AutoSize = true;
            this.labelImmatriculation.Location = new System.Drawing.Point(8, 135);
            this.labelImmatriculation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelImmatriculation.Name = "labelImmatriculation";
            this.labelImmatriculation.Size = new System.Drawing.Size(86, 13);
            this.labelImmatriculation.TabIndex = 2;
            this.labelImmatriculation.Text = "Immatriculation : ";
            // 
            // labelEtat
            // 
            this.labelEtat.AutoSize = true;
            this.labelEtat.Location = new System.Drawing.Point(8, 48);
            this.labelEtat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEtat.Name = "labelEtat";
            this.labelEtat.Size = new System.Drawing.Size(32, 13);
            this.labelEtat.TabIndex = 3;
            this.labelEtat.Text = "Etat :";
            // 
            // labelKilometrage
            // 
            this.labelKilometrage.AutoSize = true;
            this.labelKilometrage.Location = new System.Drawing.Point(8, 194);
            this.labelKilometrage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKilometrage.Name = "labelKilometrage";
            this.labelKilometrage.Size = new System.Drawing.Size(68, 13);
            this.labelKilometrage.TabIndex = 4;
            this.labelKilometrage.Text = "Kilomètrage :";
            // 
            // labelConsommation
            // 
            this.labelConsommation.AutoSize = true;
            this.labelConsommation.Location = new System.Drawing.Point(8, 223);
            this.labelConsommation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConsommation.Name = "labelConsommation";
            this.labelConsommation.Size = new System.Drawing.Size(82, 13);
            this.labelConsommation.TabIndex = 5;
            this.labelConsommation.Text = "Consommation :";
            // 
            // labelCarburant
            // 
            this.labelCarburant.AutoSize = true;
            this.labelCarburant.Location = new System.Drawing.Point(8, 253);
            this.labelCarburant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCarburant.Name = "labelCarburant";
            this.labelCarburant.Size = new System.Drawing.Size(59, 13);
            this.labelCarburant.TabIndex = 6;
            this.labelCarburant.Text = "Carburant :";
            // 
            // labelDataAchat
            // 
            this.labelDataAchat.AutoSize = true;
            this.labelDataAchat.Location = new System.Drawing.Point(8, 290);
            this.labelDataAchat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDataAchat.Name = "labelDataAchat";
            this.labelDataAchat.Size = new System.Drawing.Size(70, 13);
            this.labelDataAchat.TabIndex = 7;
            this.labelDataAchat.Text = "Date Achat : ";
            // 
            // labelDateMiseCirculation
            // 
            this.labelDateMiseCirculation.AutoSize = true;
            this.labelDateMiseCirculation.Location = new System.Drawing.Point(5, 342);
            this.labelDateMiseCirculation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateMiseCirculation.Name = "labelDateMiseCirculation";
            this.labelDateMiseCirculation.Size = new System.Drawing.Size(142, 13);
            this.labelDateMiseCirculation.TabIndex = 8;
            this.labelDateMiseCirculation.Text = "Date de Mise en circulation :";
            // 
            // labelHayonPuissance
            // 
            this.labelHayonPuissance.AutoSize = true;
            this.labelHayonPuissance.Location = new System.Drawing.Point(16, 45);
            this.labelHayonPuissance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHayonPuissance.Name = "labelHayonPuissance";
            this.labelHayonPuissance.Size = new System.Drawing.Size(69, 13);
            this.labelHayonPuissance.TabIndex = 11;
            this.labelHayonPuissance.Text = "Poid à vide : ";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(16, 71);
            this.labelType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(44, 13);
            this.labelType.TabIndex = 12;
            this.labelType.Text = "PTAC : ";
            // 
            // labelLongInter
            // 
            this.labelLongInter.AutoSize = true;
            this.labelLongInter.Location = new System.Drawing.Point(12, 37);
            this.labelLongInter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLongInter.Name = "labelLongInter";
            this.labelLongInter.Size = new System.Drawing.Size(105, 13);
            this.labelLongInter.TabIndex = 14;
            this.labelLongInter.Text = "Longueur Intérieure :";
            this.labelLongInter.Click += new System.EventHandler(this.label15_Click);
            // 
            // LabelLargInt
            // 
            this.LabelLargInt.AutoSize = true;
            this.LabelLargInt.Location = new System.Drawing.Point(12, 66);
            this.LabelLargInt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelLargInt.Name = "LabelLargInt";
            this.LabelLargInt.Size = new System.Drawing.Size(99, 13);
            this.LabelLargInt.TabIndex = 15;
            this.LabelLargInt.Text = "Largeur Intérieure : ";
            this.LabelLargInt.Click += new System.EventHandler(this.label16_Click);
            // 
            // labelHautInt
            // 
            this.labelHautInt.AutoSize = true;
            this.labelHautInt.Location = new System.Drawing.Point(12, 96);
            this.labelHautInt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHautInt.Name = "labelHautInt";
            this.labelHautInt.Size = new System.Drawing.Size(98, 13);
            this.labelHautInt.TabIndex = 17;
            this.labelHautInt.Text = "Hauteur Intérieure :";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(16, 23);
            this.labelVolume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(51, 13);
            this.labelVolume.TabIndex = 19;
            this.labelVolume.Text = "Volume : ";
            this.labelVolume.Click += new System.EventHandler(this.label20_Click);
            // 
            // labelVolumeLibre
            // 
            this.labelVolumeLibre.AutoSize = true;
            this.labelVolumeLibre.Location = new System.Drawing.Point(16, 50);
            this.labelVolumeLibre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVolumeLibre.Name = "labelVolumeLibre";
            this.labelVolumeLibre.Size = new System.Drawing.Size(74, 13);
            this.labelVolumeLibre.TabIndex = 20;
            this.labelVolumeLibre.Text = "Volume Libre :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBoxEtat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.idCamion_tb);
            this.groupBox1.Controls.Add(this.datec_tb);
            this.groupBox1.Controls.Add(this.datea_tb);
            this.groupBox1.Controls.Add(this.dateTimePickerCirculation);
            this.groupBox1.Controls.Add(this.dateTimePickerAchat);
            this.groupBox1.Controls.Add(this.carbu_tb);
            this.groupBox1.Controls.Add(this.conso_tb);
            this.groupBox1.Controls.Add(this.km_tb);
            this.groupBox1.Controls.Add(this.immat_tb);
            this.groupBox1.Controls.Add(this.modele_tb);
            this.groupBox1.Controls.Add(this.marque_tb);
            this.groupBox1.Controls.Add(this.labelMarque);
            this.groupBox1.Controls.Add(this.labelModele);
            this.groupBox1.Controls.Add(this.labelImmatriculation);
            this.groupBox1.Controls.Add(this.labelEtat);
            this.groupBox1.Controls.Add(this.labelKilometrage);
            this.groupBox1.Controls.Add(this.labelConsommation);
            this.groupBox1.Controls.Add(this.labelCarburant);
            this.groupBox1.Controls.Add(this.labelDataAchat);
            this.groupBox1.Controls.Add(this.labelDateMiseCirculation);
            this.groupBox1.Location = new System.Drawing.Point(26, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(301, 406);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caractéristiques Vehicules";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "L/100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Km(s)";
            // 
            // checkBoxEtat
            // 
            this.checkBoxEtat.AutoSize = true;
            this.checkBoxEtat.Location = new System.Drawing.Point(153, 50);
            this.checkBoxEtat.Name = "checkBoxEtat";
            this.checkBoxEtat.Size = new System.Drawing.Size(81, 17);
            this.checkBoxEtat.TabIndex = 24;
            this.checkBoxEtat.Text = "Fonctionnel";
            this.checkBoxEtat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Identifiant :";
            // 
            // idCamion_tb
            // 
            this.idCamion_tb.Enabled = false;
            this.idCamion_tb.Location = new System.Drawing.Point(153, 23);
            this.idCamion_tb.Name = "idCamion_tb";
            this.idCamion_tb.Size = new System.Drawing.Size(133, 20);
            this.idCamion_tb.TabIndex = 22;
            // 
            // datec_tb
            // 
            this.datec_tb.Enabled = false;
            this.datec_tb.Location = new System.Drawing.Point(153, 342);
            this.datec_tb.Name = "datec_tb";
            this.datec_tb.Size = new System.Drawing.Size(133, 20);
            this.datec_tb.TabIndex = 21;
            // 
            // datea_tb
            // 
            this.datea_tb.Enabled = false;
            this.datea_tb.Location = new System.Drawing.Point(153, 287);
            this.datea_tb.Name = "datea_tb";
            this.datea_tb.Size = new System.Drawing.Size(133, 20);
            this.datea_tb.TabIndex = 20;
            // 
            // dateTimePickerCirculation
            // 
            this.dateTimePickerCirculation.Location = new System.Drawing.Point(153, 367);
            this.dateTimePickerCirculation.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerCirculation.Name = "dateTimePickerCirculation";
            this.dateTimePickerCirculation.Size = new System.Drawing.Size(133, 20);
            this.dateTimePickerCirculation.TabIndex = 18;
            // 
            // dateTimePickerAchat
            // 
            this.dateTimePickerAchat.Location = new System.Drawing.Point(153, 317);
            this.dateTimePickerAchat.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerAchat.Name = "dateTimePickerAchat";
            this.dateTimePickerAchat.Size = new System.Drawing.Size(133, 20);
            this.dateTimePickerAchat.TabIndex = 17;
            // 
            // carbu_tb
            // 
            this.carbu_tb.Location = new System.Drawing.Point(153, 253);
            this.carbu_tb.Margin = new System.Windows.Forms.Padding(2);
            this.carbu_tb.Name = "carbu_tb";
            this.carbu_tb.Size = new System.Drawing.Size(133, 20);
            this.carbu_tb.TabIndex = 15;
            // 
            // conso_tb
            // 
            this.conso_tb.Location = new System.Drawing.Point(153, 224);
            this.conso_tb.Margin = new System.Windows.Forms.Padding(2);
            this.conso_tb.Name = "conso_tb";
            this.conso_tb.Size = new System.Drawing.Size(92, 20);
            this.conso_tb.TabIndex = 14;
            // 
            // km_tb
            // 
            this.km_tb.Location = new System.Drawing.Point(153, 191);
            this.km_tb.Margin = new System.Windows.Forms.Padding(2);
            this.km_tb.Name = "km_tb";
            this.km_tb.Size = new System.Drawing.Size(92, 20);
            this.km_tb.TabIndex = 13;
            // 
            // immat_tb
            // 
            this.immat_tb.Location = new System.Drawing.Point(153, 135);
            this.immat_tb.Margin = new System.Windows.Forms.Padding(2);
            this.immat_tb.Name = "immat_tb";
            this.immat_tb.Size = new System.Drawing.Size(133, 20);
            this.immat_tb.TabIndex = 12;
            // 
            // modele_tb
            // 
            this.modele_tb.Location = new System.Drawing.Point(153, 108);
            this.modele_tb.Margin = new System.Windows.Forms.Padding(2);
            this.modele_tb.Name = "modele_tb";
            this.modele_tb.Size = new System.Drawing.Size(133, 20);
            this.modele_tb.TabIndex = 11;
            // 
            // marque_tb
            // 
            this.marque_tb.Location = new System.Drawing.Point(153, 75);
            this.marque_tb.Margin = new System.Windows.Forms.Padding(2);
            this.marque_tb.Name = "marque_tb";
            this.marque_tb.Size = new System.Drawing.Size(133, 20);
            this.marque_tb.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxHayon);
            this.groupBox2.Controls.Add(this.ptac_tb);
            this.groupBox2.Controls.Add(this.poidv_tb);
            this.groupBox2.Controls.Add(this.labelType);
            this.groupBox2.Controls.Add(this.labelHayonPuissance);
            this.groupBox2.Location = new System.Drawing.Point(352, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(299, 95);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remorques";
            // 
            // checkBoxHayon
            // 
            this.checkBoxHayon.AutoSize = true;
            this.checkBoxHayon.Location = new System.Drawing.Point(138, 19);
            this.checkBoxHayon.Name = "checkBoxHayon";
            this.checkBoxHayon.Size = new System.Drawing.Size(114, 17);
            this.checkBoxHayon.TabIndex = 20;
            this.checkBoxHayon.Text = "Possède un hayon";
            this.checkBoxHayon.UseVisualStyleBackColor = true;
            // 
            // ptac_tb
            // 
            this.ptac_tb.Location = new System.Drawing.Point(138, 71);
            this.ptac_tb.Margin = new System.Windows.Forms.Padding(2);
            this.ptac_tb.Name = "ptac_tb";
            this.ptac_tb.Size = new System.Drawing.Size(112, 20);
            this.ptac_tb.TabIndex = 19;
            // 
            // poidv_tb
            // 
            this.poidv_tb.Location = new System.Drawing.Point(138, 45);
            this.poidv_tb.Margin = new System.Windows.Forms.Padding(2);
            this.poidv_tb.Name = "poidv_tb";
            this.poidv_tb.Size = new System.Drawing.Size(112, 20);
            this.poidv_tb.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.largint_tb);
            this.groupBox3.Controls.Add(this.hautint_tb);
            this.groupBox3.Controls.Add(this.longint_tb);
            this.groupBox3.Controls.Add(this.labelLongInter);
            this.groupBox3.Controls.Add(this.LabelLargInt);
            this.groupBox3.Controls.Add(this.labelHautInt);
            this.groupBox3.Location = new System.Drawing.Point(352, 122);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(302, 132);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Longueurs";
            // 
            // largint_tb
            // 
            this.largint_tb.Location = new System.Drawing.Point(132, 63);
            this.largint_tb.Margin = new System.Windows.Forms.Padding(2);
            this.largint_tb.Name = "largint_tb";
            this.largint_tb.Size = new System.Drawing.Size(112, 20);
            this.largint_tb.TabIndex = 22;
            // 
            // hautint_tb
            // 
            this.hautint_tb.Location = new System.Drawing.Point(132, 90);
            this.hautint_tb.Margin = new System.Windows.Forms.Padding(2);
            this.hautint_tb.Name = "hautint_tb";
            this.hautint_tb.Size = new System.Drawing.Size(112, 20);
            this.hautint_tb.TabIndex = 26;
            // 
            // longint_tb
            // 
            this.longint_tb.Location = new System.Drawing.Point(132, 37);
            this.longint_tb.Margin = new System.Windows.Forms.Padding(2);
            this.longint_tb.Name = "longint_tb";
            this.longint_tb.Size = new System.Drawing.Size(112, 20);
            this.longint_tb.TabIndex = 21;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.volumelibre_tb);
            this.groupBox4.Controls.Add(this.volume_tb);
            this.groupBox4.Controls.Add(this.labelVolume);
            this.groupBox4.Controls.Add(this.labelVolumeLibre);
            this.groupBox4.Location = new System.Drawing.Point(352, 269);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(296, 81);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Volumes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "cm3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "cm3";
            // 
            // volumelibre_tb
            // 
            this.volumelibre_tb.Enabled = false;
            this.volumelibre_tb.Location = new System.Drawing.Point(135, 50);
            this.volumelibre_tb.Margin = new System.Windows.Forms.Padding(2);
            this.volumelibre_tb.Name = "volumelibre_tb";
            this.volumelibre_tb.Size = new System.Drawing.Size(112, 20);
            this.volumelibre_tb.TabIndex = 29;
            // 
            // volume_tb
            // 
            this.volume_tb.Enabled = false;
            this.volume_tb.Location = new System.Drawing.Point(135, 22);
            this.volume_tb.Margin = new System.Windows.Forms.Padding(2);
            this.volume_tb.Name = "volume_tb";
            this.volume_tb.Size = new System.Drawing.Size(112, 20);
            this.volume_tb.TabIndex = 28;
            // 
            // buttonDebut
            // 
            this.buttonDebut.Location = new System.Drawing.Point(352, 371);
            this.buttonDebut.Name = "buttonDebut";
            this.buttonDebut.Size = new System.Drawing.Size(35, 23);
            this.buttonDebut.TabIndex = 25;
            this.buttonDebut.Text = "<<";
            this.buttonDebut.UseVisualStyleBackColor = true;
            this.buttonDebut.Click += new System.EventHandler(this.buttonDebut_Click);
            // 
            // buttonPrecedent
            // 
            this.buttonPrecedent.Location = new System.Drawing.Point(393, 371);
            this.buttonPrecedent.Name = "buttonPrecedent";
            this.buttonPrecedent.Size = new System.Drawing.Size(35, 23);
            this.buttonPrecedent.TabIndex = 26;
            this.buttonPrecedent.Text = "<";
            this.buttonPrecedent.UseVisualStyleBackColor = true;
            this.buttonPrecedent.Click += new System.EventHandler(this.buttonPrecedent_Click);
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Location = new System.Drawing.Point(434, 371);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(35, 23);
            this.buttonSuivant.TabIndex = 27;
            this.buttonSuivant.Text = ">";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.buttonSuivant_Click);
            // 
            // buttonFin
            // 
            this.buttonFin.Location = new System.Drawing.Point(475, 371);
            this.buttonFin.Name = "buttonFin";
            this.buttonFin.Size = new System.Drawing.Size(35, 23);
            this.buttonFin.TabIndex = 28;
            this.buttonFin.Text = ">>";
            this.buttonFin.UseVisualStyleBackColor = true;
            this.buttonFin.Click += new System.EventHandler(this.buttonFin_Click);
            // 
            // buttonAjout
            // 
            this.buttonAjout.Location = new System.Drawing.Point(534, 371);
            this.buttonAjout.Name = "buttonAjout";
            this.buttonAjout.Size = new System.Drawing.Size(35, 23);
            this.buttonAjout.TabIndex = 29;
            this.buttonAjout.Text = "+";
            this.buttonAjout.UseVisualStyleBackColor = true;
            this.buttonAjout.Click += new System.EventHandler(this.buttonAjout_Click);
            // 
            // buttonSupprim
            // 
            this.buttonSupprim.Location = new System.Drawing.Point(578, 371);
            this.buttonSupprim.Name = "buttonSupprim";
            this.buttonSupprim.Size = new System.Drawing.Size(35, 23);
            this.buttonSupprim.TabIndex = 30;
            this.buttonSupprim.Text = "-";
            this.buttonSupprim.UseVisualStyleBackColor = true;
            this.buttonSupprim.Click += new System.EventHandler(this.buttonSupprim_Click);
            // 
            // buttonModif
            // 
            this.buttonModif.Location = new System.Drawing.Point(622, 371);
            this.buttonModif.Name = "buttonModif";
            this.buttonModif.Size = new System.Drawing.Size(35, 23);
            this.buttonModif.TabIndex = 31;
            this.buttonModif.Text = "mod";
            this.buttonModif.UseVisualStyleBackColor = true;
            this.buttonModif.Click += new System.EventHandler(this.buttonModif_Click);
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(534, 413);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(123, 23);
            this.buttonFermer.TabIndex = 32;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // buttonListeC
            // 
            this.buttonListeC.Location = new System.Drawing.Point(400, 413);
            this.buttonListeC.Name = "buttonListeC";
            this.buttonListeC.Size = new System.Drawing.Size(110, 23);
            this.buttonListeC.TabIndex = 33;
            this.buttonListeC.Text = "liste camions";
            this.buttonListeC.UseVisualStyleBackColor = true;
            this.buttonListeC.Click += new System.EventHandler(this.buttonListeC_Click);
            // 
            // FormCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 448);
            this.Controls.Add(this.buttonListeC);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.buttonModif);
            this.Controls.Add(this.buttonSupprim);
            this.Controls.Add(this.buttonAjout);
            this.Controls.Add(this.buttonFin);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.buttonPrecedent);
            this.Controls.Add(this.buttonDebut);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCamion";
            this.Text = "Camion ";
            this.Load += new System.EventHandler(this.FormCamion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMarque;
        private System.Windows.Forms.Label labelModele;
        private System.Windows.Forms.Label labelImmatriculation;
        private System.Windows.Forms.Label labelEtat;
        private System.Windows.Forms.Label labelKilometrage;
        private System.Windows.Forms.Label labelConsommation;
        private System.Windows.Forms.Label labelCarburant;
        private System.Windows.Forms.Label labelDataAchat;
        private System.Windows.Forms.Label labelDateMiseCirculation;
        private System.Windows.Forms.Label labelHayonPuissance;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelLongInter;
        private System.Windows.Forms.Label LabelLargInt;
        private System.Windows.Forms.Label labelHautInt;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelVolumeLibre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerCirculation;
        private System.Windows.Forms.DateTimePicker dateTimePickerAchat;
        private System.Windows.Forms.TextBox carbu_tb;
        private System.Windows.Forms.TextBox conso_tb;
        private System.Windows.Forms.TextBox km_tb;
        private System.Windows.Forms.TextBox immat_tb;
        private System.Windows.Forms.TextBox modele_tb;
        private System.Windows.Forms.TextBox marque_tb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ptac_tb;
        private System.Windows.Forms.TextBox poidv_tb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox hautint_tb;
        private System.Windows.Forms.TextBox longint_tb;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox volumelibre_tb;
        private System.Windows.Forms.TextBox volume_tb;
        private System.Windows.Forms.TextBox largint_tb;
        private System.Windows.Forms.TextBox datec_tb;
        private System.Windows.Forms.TextBox datea_tb;
        private System.Windows.Forms.CheckBox checkBoxHayon;
        private System.Windows.Forms.Button buttonDebut;
        private System.Windows.Forms.Button buttonPrecedent;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.Button buttonFin;
        private System.Windows.Forms.Button buttonAjout;
        private System.Windows.Forms.Button buttonSupprim;
        private System.Windows.Forms.Button buttonModif;
        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.Button buttonListeC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idCamion_tb;
        private System.Windows.Forms.CheckBox checkBoxEtat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}