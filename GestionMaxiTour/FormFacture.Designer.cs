namespace GestionMaxiTour
{
    partial class FormFacture
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
            this.labelNumeroFacture = new System.Windows.Forms.Label();
            this.labelDateFacture = new System.Windows.Forms.Label();
            this.labelDateTournee = new System.Windows.Forms.Label();
            this.labelDepartTournée = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPrixTournee = new System.Windows.Forms.Label();
            this.labelTotalHT = new System.Windows.Forms.Label();
            this.labelTVA = new System.Windows.Forms.Label();
            this.labelTotalTTC = new System.Windows.Forms.Label();
            this.textBoxNumeroFacture = new System.Windows.Forms.TextBox();
            this.labelTotalPrixImprevu = new System.Windows.Forms.Label();
            this.textBoxDepartTournee = new System.Windows.Forms.TextBox();
            this.textBoxDestinationTournee = new System.Windows.Forms.TextBox();
            this.textBoxTotalPrixImprevu = new System.Windows.Forms.TextBox();
            this.textBoxTotalTTC = new System.Windows.Forms.TextBox();
            this.textBoxTotalHT = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateFacture = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateTournee = new System.Windows.Forms.DateTimePicker();
            this.textBoxTVA = new System.Windows.Forms.TextBox();
            this.textBoxPrixTournee = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNumeroFacture
            // 
            this.labelNumeroFacture.AutoSize = true;
            this.labelNumeroFacture.Location = new System.Drawing.Point(15, 15);
            this.labelNumeroFacture.Name = "labelNumeroFacture";
            this.labelNumeroFacture.Size = new System.Drawing.Size(89, 13);
            this.labelNumeroFacture.TabIndex = 1;
            this.labelNumeroFacture.Text = "Numéro Facture :";
            this.labelNumeroFacture.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDateFacture
            // 
            this.labelDateFacture.AutoSize = true;
            this.labelDateFacture.Location = new System.Drawing.Point(15, 43);
            this.labelDateFacture.Name = "labelDateFacture";
            this.labelDateFacture.Size = new System.Drawing.Size(75, 13);
            this.labelDateFacture.TabIndex = 2;
            this.labelDateFacture.Text = "Date Facture :";
            // 
            // labelDateTournee
            // 
            this.labelDateTournee.AutoSize = true;
            this.labelDateTournee.Location = new System.Drawing.Point(15, 71);
            this.labelDateTournee.Name = "labelDateTournee";
            this.labelDateTournee.Size = new System.Drawing.Size(82, 13);
            this.labelDateTournee.TabIndex = 4;
            this.labelDateTournee.Text = "Date Tournée  :";
            // 
            // labelDepartTournée
            // 
            this.labelDepartTournée.AutoSize = true;
            this.labelDepartTournée.Location = new System.Drawing.Point(15, 99);
            this.labelDepartTournée.Name = "labelDepartTournée";
            this.labelDepartTournée.Size = new System.Drawing.Size(88, 13);
            this.labelDepartTournée.TabIndex = 6;
            this.labelDepartTournée.Text = "Départ Tournée :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Destination Tournée :";
            // 
            // labelPrixTournee
            // 
            this.labelPrixTournee.AutoSize = true;
            this.labelPrixTournee.Location = new System.Drawing.Point(15, 155);
            this.labelPrixTournee.Name = "labelPrixTournee";
            this.labelPrixTournee.Size = new System.Drawing.Size(73, 13);
            this.labelPrixTournee.TabIndex = 10;
            this.labelPrixTournee.Text = "Prix Tournée :";
            this.labelPrixTournee.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelTotalHT
            // 
            this.labelTotalHT.AutoSize = true;
            this.labelTotalHT.Location = new System.Drawing.Point(15, 183);
            this.labelTotalHT.Name = "labelTotalHT";
            this.labelTotalHT.Size = new System.Drawing.Size(55, 13);
            this.labelTotalHT.TabIndex = 12;
            this.labelTotalHT.Text = "Total HT :";
            // 
            // labelTVA
            // 
            this.labelTVA.AutoSize = true;
            this.labelTVA.Location = new System.Drawing.Point(15, 211);
            this.labelTVA.Name = "labelTVA";
            this.labelTVA.Size = new System.Drawing.Size(34, 13);
            this.labelTVA.TabIndex = 14;
            this.labelTVA.Text = "TVA :";
            this.labelTVA.Click += new System.EventHandler(this.label8_Click);
            // 
            // labelTotalTTC
            // 
            this.labelTotalTTC.AutoSize = true;
            this.labelTotalTTC.Location = new System.Drawing.Point(15, 239);
            this.labelTotalTTC.Name = "labelTotalTTC";
            this.labelTotalTTC.Size = new System.Drawing.Size(61, 13);
            this.labelTotalTTC.TabIndex = 16;
            this.labelTotalTTC.Text = "Total TTC :";
            this.labelTotalTTC.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBoxNumeroFacture
            // 
            this.textBoxNumeroFacture.Location = new System.Drawing.Point(138, 8);
            this.textBoxNumeroFacture.Name = "textBoxNumeroFacture";
            this.textBoxNumeroFacture.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeroFacture.TabIndex = 33;
            // 
            // labelTotalPrixImprevu
            // 
            this.labelTotalPrixImprevu.AutoSize = true;
            this.labelTotalPrixImprevu.Location = new System.Drawing.Point(15, 267);
            this.labelTotalPrixImprevu.Name = "labelTotalPrixImprevu";
            this.labelTotalPrixImprevu.Size = new System.Drawing.Size(98, 13);
            this.labelTotalPrixImprevu.TabIndex = 34;
            this.labelTotalPrixImprevu.Text = "Total Prix Imprevu :";
            this.labelTotalPrixImprevu.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxDepartTournee
            // 
            this.textBoxDepartTournee.Location = new System.Drawing.Point(138, 99);
            this.textBoxDepartTournee.Name = "textBoxDepartTournee";
            this.textBoxDepartTournee.Size = new System.Drawing.Size(100, 20);
            this.textBoxDepartTournee.TabIndex = 35;
            // 
            // textBoxDestinationTournee
            // 
            this.textBoxDestinationTournee.Location = new System.Drawing.Point(138, 127);
            this.textBoxDestinationTournee.Name = "textBoxDestinationTournee";
            this.textBoxDestinationTournee.Size = new System.Drawing.Size(100, 20);
            this.textBoxDestinationTournee.TabIndex = 36;
            // 
            // textBoxTotalPrixImprevu
            // 
            this.textBoxTotalPrixImprevu.Location = new System.Drawing.Point(138, 260);
            this.textBoxTotalPrixImprevu.Name = "textBoxTotalPrixImprevu";
            this.textBoxTotalPrixImprevu.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalPrixImprevu.TabIndex = 37;
            this.textBoxTotalPrixImprevu.TextChanged += new System.EventHandler(this.textBoxTotalPrixImprevu_TextChanged);
            // 
            // textBoxTotalTTC
            // 
            this.textBoxTotalTTC.Location = new System.Drawing.Point(138, 232);
            this.textBoxTotalTTC.Name = "textBoxTotalTTC";
            this.textBoxTotalTTC.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalTTC.TabIndex = 38;
            // 
            // textBoxTotalHT
            // 
            this.textBoxTotalHT.Location = new System.Drawing.Point(138, 176);
            this.textBoxTotalHT.Name = "textBoxTotalHT";
            this.textBoxTotalHT.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalHT.TabIndex = 39;
            // 
            // dateTimePickerDateFacture
            // 
            this.dateTimePickerDateFacture.Location = new System.Drawing.Point(120, 43);
            this.dateTimePickerDateFacture.Name = "dateTimePickerDateFacture";
            this.dateTimePickerDateFacture.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateFacture.TabIndex = 41;
            // 
            // dateTimePickerDateTournee
            // 
            this.dateTimePickerDateTournee.Location = new System.Drawing.Point(120, 71);
            this.dateTimePickerDateTournee.Name = "dateTimePickerDateTournee";
            this.dateTimePickerDateTournee.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateTournee.TabIndex = 42;
            // 
            // textBoxTVA
            // 
            this.textBoxTVA.Location = new System.Drawing.Point(138, 204);
            this.textBoxTVA.Name = "textBoxTVA";
            this.textBoxTVA.Size = new System.Drawing.Size(100, 20);
            this.textBoxTVA.TabIndex = 43;
            // 
            // textBoxPrixTournee
            // 
            this.textBoxPrixTournee.Location = new System.Drawing.Point(138, 153);
            this.textBoxPrixTournee.Name = "textBoxPrixTournee";
            this.textBoxPrixTournee.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrixTournee.TabIndex = 44;
            // 
            // FormFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 309);
            this.Controls.Add(this.textBoxPrixTournee);
            this.Controls.Add(this.textBoxTVA);
            this.Controls.Add(this.dateTimePickerDateTournee);
            this.Controls.Add(this.dateTimePickerDateFacture);
            this.Controls.Add(this.textBoxTotalHT);
            this.Controls.Add(this.textBoxTotalTTC);
            this.Controls.Add(this.textBoxTotalPrixImprevu);
            this.Controls.Add(this.textBoxDestinationTournee);
            this.Controls.Add(this.textBoxDepartTournee);
            this.Controls.Add(this.labelTotalPrixImprevu);
            this.Controls.Add(this.textBoxNumeroFacture);
            this.Controls.Add(this.labelTotalTTC);
            this.Controls.Add(this.labelTVA);
            this.Controls.Add(this.labelTotalHT);
            this.Controls.Add(this.labelPrixTournee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelDepartTournée);
            this.Controls.Add(this.labelDateTournee);
            this.Controls.Add(this.labelDateFacture);
            this.Controls.Add(this.labelNumeroFacture);
            this.Name = "FormFacture";
            this.Text = "Facture";
            this.Load += new System.EventHandler(this.FormFacture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumeroFacture;
        private System.Windows.Forms.Label labelDateFacture;
        private System.Windows.Forms.Label labelDateTournee;
        private System.Windows.Forms.Label labelDepartTournée;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPrixTournee;
        private System.Windows.Forms.Label labelTotalHT;
        private System.Windows.Forms.Label labelTVA;
        private System.Windows.Forms.Label labelTotalTTC;
        private System.Windows.Forms.TextBox textBoxNumeroFacture;
        private System.Windows.Forms.Label labelTotalPrixImprevu;
        private System.Windows.Forms.TextBox textBoxDepartTournee;
        private System.Windows.Forms.TextBox textBoxDestinationTournee;
        private System.Windows.Forms.TextBox textBoxTotalPrixImprevu;
        private System.Windows.Forms.TextBox textBoxTotalTTC;
        private System.Windows.Forms.TextBox textBoxTotalHT;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateFacture;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTournee;
        private System.Windows.Forms.TextBox textBoxTVA;
        private System.Windows.Forms.TextBox textBoxPrixTournee;
    }
}