namespace GestionMaxiTour
{
    partial class FormListeChauffeur
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
            this.buttonFermer = new System.Windows.Forms.Button();
            this.labelListeAdministratif = new System.Windows.Forms.Label();
            this.dataGridViewListeChauffeurs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeChauffeurs)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(903, 757);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(219, 51);
            this.buttonFermer.TabIndex = 5;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            // 
            // labelListeAdministratif
            // 
            this.labelListeAdministratif.AutoSize = true;
            this.labelListeAdministratif.Location = new System.Drawing.Point(51, 53);
            this.labelListeAdministratif.Name = "labelListeAdministratif";
            this.labelListeAdministratif.Size = new System.Drawing.Size(322, 25);
            this.labelListeAdministratif.TabIndex = 4;
            this.labelListeAdministratif.Text = "Liste des Employés Chauffeurs :";
            // 
            // dataGridViewListeChauffeurs
            // 
            this.dataGridViewListeChauffeurs.AllowUserToAddRows = false;
            this.dataGridViewListeChauffeurs.AllowUserToDeleteRows = false;
            this.dataGridViewListeChauffeurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListeChauffeurs.Location = new System.Drawing.Point(56, 113);
            this.dataGridViewListeChauffeurs.Name = "dataGridViewListeChauffeurs";
            this.dataGridViewListeChauffeurs.ReadOnly = true;
            this.dataGridViewListeChauffeurs.RowTemplate.Height = 33;
            this.dataGridViewListeChauffeurs.Size = new System.Drawing.Size(1066, 584);
            this.dataGridViewListeChauffeurs.TabIndex = 3;
            // 
            // FormListeChauffeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 849);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.labelListeAdministratif);
            this.Controls.Add(this.dataGridViewListeChauffeurs);
            this.Name = "FormListeChauffeur";
            this.Text = "Liste des Chauffeurs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeChauffeurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.Label labelListeAdministratif;
        private System.Windows.Forms.DataGridView dataGridViewListeChauffeurs;
    }
}