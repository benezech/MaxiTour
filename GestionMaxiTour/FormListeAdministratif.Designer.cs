namespace GestionMaxiTour
{
    partial class FormListeAdministratif
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
            this.dataGridViewListeAdministratifs = new System.Windows.Forms.DataGridView();
            this.labelListeAdministratif = new System.Windows.Forms.Label();
            this.buttonFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeAdministratifs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListeAdministratifs
            // 
            this.dataGridViewListeAdministratifs.AllowUserToAddRows = false;
            this.dataGridViewListeAdministratifs.AllowUserToDeleteRows = false;
            this.dataGridViewListeAdministratifs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListeAdministratifs.Location = new System.Drawing.Point(72, 143);
            this.dataGridViewListeAdministratifs.Name = "dataGridViewListeAdministratifs";
            this.dataGridViewListeAdministratifs.ReadOnly = true;
            this.dataGridViewListeAdministratifs.RowTemplate.Height = 33;
            this.dataGridViewListeAdministratifs.Size = new System.Drawing.Size(1066, 584);
            this.dataGridViewListeAdministratifs.TabIndex = 0;
            // 
            // labelListeAdministratif
            // 
            this.labelListeAdministratif.AutoSize = true;
            this.labelListeAdministratif.Location = new System.Drawing.Point(67, 83);
            this.labelListeAdministratif.Name = "labelListeAdministratif";
            this.labelListeAdministratif.Size = new System.Drawing.Size(346, 25);
            this.labelListeAdministratif.TabIndex = 1;
            this.labelListeAdministratif.Text = "Liste des Employés Administratifs :";
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(919, 787);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(219, 51);
            this.buttonFermer.TabIndex = 2;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            // 
            // FormListeAdministratif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 905);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.labelListeAdministratif);
            this.Controls.Add(this.dataGridViewListeAdministratifs);
            this.Name = "FormListeAdministratif";
            this.Text = "Liste des Administratifs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeAdministratifs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListeAdministratifs;
        private System.Windows.Forms.Label labelListeAdministratif;
        private System.Windows.Forms.Button buttonFermer;
    }
}