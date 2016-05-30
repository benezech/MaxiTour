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
            this.labelAgeCamion = new System.Windows.Forms.Label();
            this.labelLongInter = new System.Windows.Forms.Label();
            this.LabelLargInt = new System.Windows.Forms.Label();
            this.labelHautInt = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.CaracVehicule = new System.Windows.Forms.GroupBox();
            this.cb_hayon = new System.Windows.Forms.CheckBox();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.textBoxLargInt = new System.Windows.Forms.TextBox();
            this.textBoxHautInt = new System.Windows.Forms.TextBox();
            this.textBoxLongInt = new System.Windows.Forms.TextBox();
            this.radioButtonNon = new System.Windows.Forms.RadioButton();
            this.radioButtonOui = new System.Windows.Forms.RadioButton();
            this.dateTimePickerCirculation = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAchat = new System.Windows.Forms.DateTimePicker();
            this.textBoxAgeCamion = new System.Windows.Forms.TextBox();
            this.textBoxCarburant = new System.Windows.Forms.TextBox();
            this.textBoxConsommation = new System.Windows.Forms.TextBox();
            this.textBoxKilometrage = new System.Windows.Forms.TextBox();
            this.textBoxImmatriculation = new System.Windows.Forms.TextBox();
            this.textBoxModele = new System.Windows.Forms.TextBox();
            this.textBoxMarque = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CaracVehicule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMarque
            // 
            this.labelMarque.AutoSize = true;
            this.labelMarque.Location = new System.Drawing.Point(28, 30);
            this.labelMarque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarque.Name = "labelMarque";
            this.labelMarque.Size = new System.Drawing.Size(49, 13);
            this.labelMarque.TabIndex = 0;
            this.labelMarque.Text = "Marque :";
            // 
            // labelModele
            // 
            this.labelModele.AutoSize = true;
            this.labelModele.Location = new System.Drawing.Point(28, 64);
            this.labelModele.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModele.Name = "labelModele";
            this.labelModele.Size = new System.Drawing.Size(48, 13);
            this.labelModele.TabIndex = 1;
            this.labelModele.Text = "Modèle :";
            // 
            // labelImmatriculation
            // 
            this.labelImmatriculation.AutoSize = true;
            this.labelImmatriculation.Location = new System.Drawing.Point(28, 98);
            this.labelImmatriculation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelImmatriculation.Name = "labelImmatriculation";
            this.labelImmatriculation.Size = new System.Drawing.Size(86, 13);
            this.labelImmatriculation.TabIndex = 2;
            this.labelImmatriculation.Text = "Immatriculation : ";
            // 
            // labelEtat
            // 
            this.labelEtat.AutoSize = true;
            this.labelEtat.Location = new System.Drawing.Point(28, 132);
            this.labelEtat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEtat.Name = "labelEtat";
            this.labelEtat.Size = new System.Drawing.Size(32, 13);
            this.labelEtat.TabIndex = 3;
            this.labelEtat.Text = "Etat :";
            // 
            // labelKilometrage
            // 
            this.labelKilometrage.AutoSize = true;
            this.labelKilometrage.Location = new System.Drawing.Point(28, 166);
            this.labelKilometrage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKilometrage.Name = "labelKilometrage";
            this.labelKilometrage.Size = new System.Drawing.Size(68, 13);
            this.labelKilometrage.TabIndex = 4;
            this.labelKilometrage.Text = "Kilomètrage :";
            // 
            // labelConsommation
            // 
            this.labelConsommation.AutoSize = true;
            this.labelConsommation.Location = new System.Drawing.Point(28, 200);
            this.labelConsommation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConsommation.Name = "labelConsommation";
            this.labelConsommation.Size = new System.Drawing.Size(82, 13);
            this.labelConsommation.TabIndex = 5;
            this.labelConsommation.Text = "Consommation :";
            // 
            // labelCarburant
            // 
            this.labelCarburant.AutoSize = true;
            this.labelCarburant.Location = new System.Drawing.Point(28, 234);
            this.labelCarburant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCarburant.Name = "labelCarburant";
            this.labelCarburant.Size = new System.Drawing.Size(59, 13);
            this.labelCarburant.TabIndex = 6;
            this.labelCarburant.Text = "Carburant :";
            // 
            // labelDataAchat
            // 
            this.labelDataAchat.AutoSize = true;
            this.labelDataAchat.Location = new System.Drawing.Point(28, 268);
            this.labelDataAchat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDataAchat.Name = "labelDataAchat";
            this.labelDataAchat.Size = new System.Drawing.Size(70, 13);
            this.labelDataAchat.TabIndex = 7;
            this.labelDataAchat.Text = "Date Achat : ";
            // 
            // labelDateMiseCirculation
            // 
            this.labelDateMiseCirculation.AutoSize = true;
            this.labelDateMiseCirculation.Location = new System.Drawing.Point(28, 302);
            this.labelDateMiseCirculation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateMiseCirculation.Name = "labelDateMiseCirculation";
            this.labelDateMiseCirculation.Size = new System.Drawing.Size(142, 13);
            this.labelDateMiseCirculation.TabIndex = 8;
            this.labelDateMiseCirculation.Text = "Date de Mise en circulation :";
            // 
            // labelAgeCamion
            // 
            this.labelAgeCamion.AutoSize = true;
            this.labelAgeCamion.Location = new System.Drawing.Point(28, 336);
            this.labelAgeCamion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAgeCamion.Name = "labelAgeCamion";
            this.labelAgeCamion.Size = new System.Drawing.Size(70, 13);
            this.labelAgeCamion.TabIndex = 9;
            this.labelAgeCamion.Text = "Age Camion :";
            // 
            // labelLongInter
            // 
            this.labelLongInter.AutoSize = true;
            this.labelLongInter.Location = new System.Drawing.Point(28, 386);
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
            this.LabelLargInt.Location = new System.Drawing.Point(28, 420);
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
            this.labelHautInt.Location = new System.Drawing.Point(28, 454);
            this.labelHautInt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHautInt.Name = "labelHautInt";
            this.labelHautInt.Size = new System.Drawing.Size(98, 13);
            this.labelHautInt.TabIndex = 17;
            this.labelHautInt.Text = "Hauteur Intérieure :";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(28, 488);
            this.labelVolume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(51, 13);
            this.labelVolume.TabIndex = 19;
            this.labelVolume.Text = "Volume : ";
            this.labelVolume.Click += new System.EventHandler(this.label20_Click);
            // 
            // CaracVehicule
            // 
            this.CaracVehicule.Controls.Add(this.cb_hayon);
            this.CaracVehicule.Controls.Add(this.textBoxVolume);
            this.CaracVehicule.Controls.Add(this.labelVolume);
            this.CaracVehicule.Controls.Add(this.textBoxLargInt);
            this.CaracVehicule.Controls.Add(this.textBoxHautInt);
            this.CaracVehicule.Controls.Add(this.textBoxLongInt);
            this.CaracVehicule.Controls.Add(this.radioButtonNon);
            this.CaracVehicule.Controls.Add(this.labelLongInter);
            this.CaracVehicule.Controls.Add(this.radioButtonOui);
            this.CaracVehicule.Controls.Add(this.LabelLargInt);
            this.CaracVehicule.Controls.Add(this.dateTimePickerCirculation);
            this.CaracVehicule.Controls.Add(this.labelHautInt);
            this.CaracVehicule.Controls.Add(this.dateTimePickerAchat);
            this.CaracVehicule.Controls.Add(this.textBoxAgeCamion);
            this.CaracVehicule.Controls.Add(this.textBoxCarburant);
            this.CaracVehicule.Controls.Add(this.textBoxConsommation);
            this.CaracVehicule.Controls.Add(this.textBoxKilometrage);
            this.CaracVehicule.Controls.Add(this.textBoxImmatriculation);
            this.CaracVehicule.Controls.Add(this.textBoxModele);
            this.CaracVehicule.Controls.Add(this.textBoxMarque);
            this.CaracVehicule.Controls.Add(this.labelMarque);
            this.CaracVehicule.Controls.Add(this.labelModele);
            this.CaracVehicule.Controls.Add(this.labelImmatriculation);
            this.CaracVehicule.Controls.Add(this.labelEtat);
            this.CaracVehicule.Controls.Add(this.labelKilometrage);
            this.CaracVehicule.Controls.Add(this.labelConsommation);
            this.CaracVehicule.Controls.Add(this.labelCarburant);
            this.CaracVehicule.Controls.Add(this.labelDataAchat);
            this.CaracVehicule.Controls.Add(this.labelDateMiseCirculation);
            this.CaracVehicule.Controls.Add(this.labelAgeCamion);
            this.CaracVehicule.Location = new System.Drawing.Point(28, 17);
            this.CaracVehicule.Margin = new System.Windows.Forms.Padding(2);
            this.CaracVehicule.Name = "CaracVehicule";
            this.CaracVehicule.Padding = new System.Windows.Forms.Padding(2);
            this.CaracVehicule.Size = new System.Drawing.Size(378, 521);
            this.CaracVehicule.TabIndex = 21;
            this.CaracVehicule.TabStop = false;
            this.CaracVehicule.Text = "Caractéristiques Vehicules";
            // 
            // cb_hayon
            // 
            this.cb_hayon.AutoSize = true;
            this.cb_hayon.Location = new System.Drawing.Point(28, 362);
            this.cb_hayon.Name = "cb_hayon";
            this.cb_hayon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_hayon.Size = new System.Drawing.Size(60, 17);
            this.cb_hayon.TabIndex = 29;
            this.cb_hayon.Text = "Hayon ";
            this.cb_hayon.UseVisualStyleBackColor = true;
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.Location = new System.Drawing.Point(212, 488);
            this.textBoxVolume.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.Size = new System.Drawing.Size(112, 20);
            this.textBoxVolume.TabIndex = 28;
            // 
            // textBoxLargInt
            // 
            this.textBoxLargInt.Location = new System.Drawing.Point(212, 420);
            this.textBoxLargInt.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLargInt.Name = "textBoxLargInt";
            this.textBoxLargInt.Size = new System.Drawing.Size(112, 20);
            this.textBoxLargInt.TabIndex = 22;
            // 
            // textBoxHautInt
            // 
            this.textBoxHautInt.Location = new System.Drawing.Point(212, 454);
            this.textBoxHautInt.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHautInt.Name = "textBoxHautInt";
            this.textBoxHautInt.Size = new System.Drawing.Size(112, 20);
            this.textBoxHautInt.TabIndex = 26;
            // 
            // textBoxLongInt
            // 
            this.textBoxLongInt.Location = new System.Drawing.Point(212, 386);
            this.textBoxLongInt.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLongInt.Name = "textBoxLongInt";
            this.textBoxLongInt.Size = new System.Drawing.Size(112, 20);
            this.textBoxLongInt.TabIndex = 21;
            // 
            // radioButtonNon
            // 
            this.radioButtonNon.AutoSize = true;
            this.radioButtonNon.Location = new System.Drawing.Point(274, 128);
            this.radioButtonNon.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNon.Name = "radioButtonNon";
            this.radioButtonNon.Size = new System.Drawing.Size(100, 17);
            this.radioButtonNon.TabIndex = 20;
            this.radioButtonNon.TabStop = true;
            this.radioButtonNon.Text = "NonFonctionnel";
            this.radioButtonNon.UseVisualStyleBackColor = true;
            // 
            // radioButtonOui
            // 
            this.radioButtonOui.AutoSize = true;
            this.radioButtonOui.Location = new System.Drawing.Point(171, 128);
            this.radioButtonOui.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonOui.Name = "radioButtonOui";
            this.radioButtonOui.Size = new System.Drawing.Size(80, 17);
            this.radioButtonOui.TabIndex = 19;
            this.radioButtonOui.TabStop = true;
            this.radioButtonOui.Text = "Fonctionnel";
            this.radioButtonOui.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerCirculation
            // 
            this.dateTimePickerCirculation.Location = new System.Drawing.Point(171, 302);
            this.dateTimePickerCirculation.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerCirculation.Name = "dateTimePickerCirculation";
            this.dateTimePickerCirculation.Size = new System.Drawing.Size(186, 20);
            this.dateTimePickerCirculation.TabIndex = 18;
            // 
            // dateTimePickerAchat
            // 
            this.dateTimePickerAchat.Location = new System.Drawing.Point(171, 268);
            this.dateTimePickerAchat.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerAchat.Name = "dateTimePickerAchat";
            this.dateTimePickerAchat.Size = new System.Drawing.Size(186, 20);
            this.dateTimePickerAchat.TabIndex = 17;
            // 
            // textBoxAgeCamion
            // 
            this.textBoxAgeCamion.Location = new System.Drawing.Point(212, 336);
            this.textBoxAgeCamion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAgeCamion.Name = "textBoxAgeCamion";
            this.textBoxAgeCamion.Size = new System.Drawing.Size(112, 20);
            this.textBoxAgeCamion.TabIndex = 16;
            this.textBoxAgeCamion.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBoxCarburant
            // 
            this.textBoxCarburant.Location = new System.Drawing.Point(212, 234);
            this.textBoxCarburant.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCarburant.Name = "textBoxCarburant";
            this.textBoxCarburant.Size = new System.Drawing.Size(112, 20);
            this.textBoxCarburant.TabIndex = 15;
            // 
            // textBoxConsommation
            // 
            this.textBoxConsommation.Location = new System.Drawing.Point(212, 200);
            this.textBoxConsommation.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxConsommation.Name = "textBoxConsommation";
            this.textBoxConsommation.Size = new System.Drawing.Size(112, 20);
            this.textBoxConsommation.TabIndex = 14;
            // 
            // textBoxKilometrage
            // 
            this.textBoxKilometrage.Location = new System.Drawing.Point(212, 166);
            this.textBoxKilometrage.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKilometrage.Name = "textBoxKilometrage";
            this.textBoxKilometrage.Size = new System.Drawing.Size(112, 20);
            this.textBoxKilometrage.TabIndex = 13;
            // 
            // textBoxImmatriculation
            // 
            this.textBoxImmatriculation.Location = new System.Drawing.Point(212, 94);
            this.textBoxImmatriculation.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxImmatriculation.Name = "textBoxImmatriculation";
            this.textBoxImmatriculation.Size = new System.Drawing.Size(112, 20);
            this.textBoxImmatriculation.TabIndex = 12;
            // 
            // textBoxModele
            // 
            this.textBoxModele.Location = new System.Drawing.Point(212, 62);
            this.textBoxModele.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxModele.Name = "textBoxModele";
            this.textBoxModele.Size = new System.Drawing.Size(112, 20);
            this.textBoxModele.TabIndex = 11;
            // 
            // textBoxMarque
            // 
            this.textBoxMarque.Location = new System.Drawing.Point(212, 30);
            this.textBoxMarque.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMarque.Name = "textBoxMarque";
            this.textBoxMarque.Size = new System.Drawing.Size(112, 20);
            this.textBoxMarque.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(459, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 461);
            this.dataGridView1.TabIndex = 22;
            // 
            // FormCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 549);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CaracVehicule);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCamion";
            this.Text = "Camion ";
            this.Load += new System.EventHandler(this.FormCamion_Load);
            this.CaracVehicule.ResumeLayout(false);
            this.CaracVehicule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label labelAgeCamion;
        private System.Windows.Forms.Label labelLongInter;
        private System.Windows.Forms.Label LabelLargInt;
        private System.Windows.Forms.Label labelHautInt;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.GroupBox CaracVehicule;
        private System.Windows.Forms.DateTimePicker dateTimePickerCirculation;
        private System.Windows.Forms.DateTimePicker dateTimePickerAchat;
        private System.Windows.Forms.TextBox textBoxAgeCamion;
        private System.Windows.Forms.TextBox textBoxCarburant;
        private System.Windows.Forms.TextBox textBoxConsommation;
        private System.Windows.Forms.TextBox textBoxKilometrage;
        private System.Windows.Forms.TextBox textBoxImmatriculation;
        private System.Windows.Forms.TextBox textBoxModele;
        private System.Windows.Forms.TextBox textBoxMarque;
        private System.Windows.Forms.TextBox textBoxHautInt;
        private System.Windows.Forms.TextBox textBoxLongInt;
        private System.Windows.Forms.TextBox textBoxVolume;
        private System.Windows.Forms.TextBox textBoxLargInt;
        private System.Windows.Forms.RadioButton radioButtonNon;
        private System.Windows.Forms.RadioButton radioButtonOui;
        private System.Windows.Forms.CheckBox cb_hayon;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}