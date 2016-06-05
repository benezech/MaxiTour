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
            this.dataGridChauffeur = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChauffeur)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(452, 394);
            this.buttonFermer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(110, 27);
            this.buttonFermer.TabIndex = 5;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            // 
            // dataGridChauffeur
            // 
            this.dataGridChauffeur.AllowUserToAddRows = false;
            this.dataGridChauffeur.AllowUserToDeleteRows = false;
            this.dataGridChauffeur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridChauffeur.Location = new System.Drawing.Point(28, 59);
            this.dataGridChauffeur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridChauffeur.Name = "dataGridChauffeur";
            this.dataGridChauffeur.ReadOnly = true;
            this.dataGridChauffeur.RowTemplate.Height = 33;
            this.dataGridChauffeur.Size = new System.Drawing.Size(533, 304);
            this.dataGridChauffeur.TabIndex = 3;
            // 
            // FormListeChauffeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 381);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.dataGridChauffeur);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormListeChauffeur";
            this.Text = "Liste des Chauffeurs";
            this.Load += new System.EventHandler(this.FormListeChauffeur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChauffeur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.DataGridView dataGridChauffeur;
    }
}