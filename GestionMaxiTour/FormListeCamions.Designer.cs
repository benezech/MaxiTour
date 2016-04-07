namespace GestionMaxiTour
{
    partial class FormListeCamions
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
            this.labelListeCamion = new System.Windows.Forms.Label();
            this.dataGridViewListeCamions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeCamions)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(934, 795);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(219, 51);
            this.buttonFermer.TabIndex = 5;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            // 
            // labelListeCamion
            // 
            this.labelListeCamion.AutoSize = true;
            this.labelListeCamion.Location = new System.Drawing.Point(82, 91);
            this.labelListeCamion.Name = "labelListeCamion";
            this.labelListeCamion.Size = new System.Drawing.Size(201, 25);
            this.labelListeCamion.TabIndex = 4;
            this.labelListeCamion.Text = "Liste des Camions :";
            // 
            // dataGridViewListeCamions
            // 
            this.dataGridViewListeCamions.AllowUserToAddRows = false;
            this.dataGridViewListeCamions.AllowUserToDeleteRows = false;
            this.dataGridViewListeCamions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListeCamions.Location = new System.Drawing.Point(87, 155);
            this.dataGridViewListeCamions.Name = "dataGridViewListeCamions";
            this.dataGridViewListeCamions.ReadOnly = true;
            this.dataGridViewListeCamions.RowTemplate.Height = 33;
            this.dataGridViewListeCamions.Size = new System.Drawing.Size(1066, 584);
            this.dataGridViewListeCamions.TabIndex = 3;
            // 
            // FormListeCamions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 885);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.labelListeCamion);
            this.Controls.Add(this.dataGridViewListeCamions);
            this.Name = "FormListeCamions";
            this.Text = "Liste des Camions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeCamions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.Label labelListeCamion;
        private System.Windows.Forms.DataGridView dataGridViewListeCamions;
    }
}