namespace GestionMaxiTour
{
    partial class FormImprevu
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
            this.labelType = new System.Windows.Forms.Label();
            this.labelCout = new System.Windows.Forms.Label();
            this.type_tb = new System.Windows.Forms.TextBox();
            this.cout_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numfacture_tb = new System.Windows.Forms.TextBox();
            this.buttonDebut = new System.Windows.Forms.Button();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.buttonPrecedent = new System.Windows.Forms.Button();
            this.buttonFin = new System.Windows.Forms.Button();
            this.buttonAjout = new System.Windows.Forms.Button();
            this.buttonSupprim = new System.Windows.Forms.Button();
            this.buttonModif = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.identifiant_tb = new System.Windows.Forms.TextBox();
            this.btn_imprevus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(12, 79);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 0;
            this.labelType.Text = "Type";
            // 
            // labelCout
            // 
            this.labelCout.AutoSize = true;
            this.labelCout.Location = new System.Drawing.Point(12, 112);
            this.labelCout.Name = "labelCout";
            this.labelCout.Size = new System.Drawing.Size(29, 13);
            this.labelCout.TabIndex = 1;
            this.labelCout.Text = "Coût";
            // 
            // type_tb
            // 
            this.type_tb.Location = new System.Drawing.Point(96, 76);
            this.type_tb.Name = "type_tb";
            this.type_tb.Size = new System.Drawing.Size(190, 20);
            this.type_tb.TabIndex = 2;
            // 
            // cout_tb
            // 
            this.cout_tb.Location = new System.Drawing.Point(96, 109);
            this.cout_tb.Name = "cout_tb";
            this.cout_tb.Size = new System.Drawing.Size(190, 20);
            this.cout_tb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Facture numéro";
            // 
            // numfacture_tb
            // 
            this.numfacture_tb.Location = new System.Drawing.Point(96, 46);
            this.numfacture_tb.Name = "numfacture_tb";
            this.numfacture_tb.Size = new System.Drawing.Size(190, 20);
            this.numfacture_tb.TabIndex = 5;
            // 
            // buttonDebut
            // 
            this.buttonDebut.Location = new System.Drawing.Point(12, 152);
            this.buttonDebut.Name = "buttonDebut";
            this.buttonDebut.Size = new System.Drawing.Size(36, 23);
            this.buttonDebut.TabIndex = 6;
            this.buttonDebut.Text = "<<";
            this.buttonDebut.UseVisualStyleBackColor = true;
            this.buttonDebut.Click += new System.EventHandler(this.buttonDebut_Click);
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Location = new System.Drawing.Point(96, 152);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(36, 23);
            this.buttonSuivant.TabIndex = 7;
            this.buttonSuivant.Text = ">";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.buttonSuivant_Click);
            // 
            // buttonPrecedent
            // 
            this.buttonPrecedent.Location = new System.Drawing.Point(54, 152);
            this.buttonPrecedent.Name = "buttonPrecedent";
            this.buttonPrecedent.Size = new System.Drawing.Size(36, 23);
            this.buttonPrecedent.TabIndex = 8;
            this.buttonPrecedent.Text = "<";
            this.buttonPrecedent.UseVisualStyleBackColor = true;
            this.buttonPrecedent.Click += new System.EventHandler(this.buttonPrecedent_Click);
            // 
            // buttonFin
            // 
            this.buttonFin.Location = new System.Drawing.Point(138, 152);
            this.buttonFin.Name = "buttonFin";
            this.buttonFin.Size = new System.Drawing.Size(36, 23);
            this.buttonFin.TabIndex = 9;
            this.buttonFin.Text = ">>";
            this.buttonFin.UseVisualStyleBackColor = true;
            this.buttonFin.Click += new System.EventHandler(this.buttonFin_Click);
            // 
            // buttonAjout
            // 
            this.buttonAjout.Location = new System.Drawing.Point(194, 152);
            this.buttonAjout.Name = "buttonAjout";
            this.buttonAjout.Size = new System.Drawing.Size(43, 23);
            this.buttonAjout.TabIndex = 10;
            this.buttonAjout.Text = "+";
            this.buttonAjout.UseVisualStyleBackColor = true;
            this.buttonAjout.Click += new System.EventHandler(this.buttonAjout_Click);
            // 
            // buttonSupprim
            // 
            this.buttonSupprim.Location = new System.Drawing.Point(243, 152);
            this.buttonSupprim.Name = "buttonSupprim";
            this.buttonSupprim.Size = new System.Drawing.Size(43, 23);
            this.buttonSupprim.TabIndex = 11;
            this.buttonSupprim.Text = "-";
            this.buttonSupprim.UseVisualStyleBackColor = true;
            this.buttonSupprim.Click += new System.EventHandler(this.buttonSupprim_Click);
            // 
            // buttonModif
            // 
            this.buttonModif.Location = new System.Drawing.Point(292, 152);
            this.buttonModif.Name = "buttonModif";
            this.buttonModif.Size = new System.Drawing.Size(43, 23);
            this.buttonModif.TabIndex = 12;
            this.buttonModif.Text = "mod";
            this.buttonModif.UseVisualStyleBackColor = true;
            this.buttonModif.Click += new System.EventHandler(this.buttonModif_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Euros";
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(194, 206);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(75, 23);
            this.buttonFermer.TabIndex = 14;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Identifiant";
            // 
            // identifiant_tb
            // 
            this.identifiant_tb.Enabled = false;
            this.identifiant_tb.Location = new System.Drawing.Point(96, 13);
            this.identifiant_tb.Name = "identifiant_tb";
            this.identifiant_tb.Size = new System.Drawing.Size(190, 20);
            this.identifiant_tb.TabIndex = 16;
            // 
            // btn_imprevus
            // 
            this.btn_imprevus.Location = new System.Drawing.Point(54, 206);
            this.btn_imprevus.Name = "btn_imprevus";
            this.btn_imprevus.Size = new System.Drawing.Size(117, 23);
            this.btn_imprevus.TabIndex = 17;
            this.btn_imprevus.Text = "liste Imprévus";
            this.btn_imprevus.UseVisualStyleBackColor = true;
            this.btn_imprevus.Click += new System.EventHandler(this.btn_imprevus_Click);
            // 
            // FormImprevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 241);
            this.Controls.Add(this.btn_imprevus);
            this.Controls.Add(this.identifiant_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonModif);
            this.Controls.Add(this.buttonSupprim);
            this.Controls.Add(this.buttonAjout);
            this.Controls.Add(this.buttonFin);
            this.Controls.Add(this.buttonPrecedent);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.buttonDebut);
            this.Controls.Add(this.numfacture_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cout_tb);
            this.Controls.Add(this.type_tb);
            this.Controls.Add(this.labelCout);
            this.Controls.Add(this.labelType);
            this.Name = "FormImprevu";
            this.Text = "Imprévus";
            this.Load += new System.EventHandler(this.FormImprevu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelCout;
        private System.Windows.Forms.TextBox type_tb;
        private System.Windows.Forms.TextBox cout_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numfacture_tb;
        private System.Windows.Forms.Button buttonDebut;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.Button buttonPrecedent;
        private System.Windows.Forms.Button buttonFin;
        private System.Windows.Forms.Button buttonAjout;
        private System.Windows.Forms.Button buttonSupprim;
        private System.Windows.Forms.Button buttonModif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox identifiant_tb;
        private System.Windows.Forms.Button btn_imprevus;
    }
}