namespace GestionMaxiTour
{
    partial class FormListeFacture
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
            this.dataGridViewListedesFactures = new System.Windows.Forms.DataGridView();
            this.labelListeFacture = new System.Windows.Forms.Label();
            this.buttonFermerListedesFactures = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListedesFactures)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListedesFactures
            // 
            this.dataGridViewListedesFactures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListedesFactures.Location = new System.Drawing.Point(12, 43);
            this.dataGridViewListedesFactures.Name = "dataGridViewListedesFactures";
            this.dataGridViewListedesFactures.Size = new System.Drawing.Size(400, 244);
            this.dataGridViewListedesFactures.TabIndex = 0;
            // 
            // labelListeFacture
            // 
            this.labelListeFacture.AutoSize = true;
            this.labelListeFacture.Location = new System.Drawing.Point(30, 9);
            this.labelListeFacture.Name = "labelListeFacture";
            this.labelListeFacture.Size = new System.Drawing.Size(99, 13);
            this.labelListeFacture.TabIndex = 1;
            this.labelListeFacture.Text = "Liste des Factures :";
            // 
            // buttonFermerListedesFactures
            // 
            this.buttonFermerListedesFactures.Location = new System.Drawing.Point(337, 298);
            this.buttonFermerListedesFactures.Name = "buttonFermerListedesFactures";
            this.buttonFermerListedesFactures.Size = new System.Drawing.Size(75, 23);
            this.buttonFermerListedesFactures.TabIndex = 3;
            this.buttonFermerListedesFactures.Text = "Fermer";
            this.buttonFermerListedesFactures.UseVisualStyleBackColor = true;
            // 
            // FormListeFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 333);
            this.Controls.Add(this.buttonFermerListedesFactures);
            this.Controls.Add(this.labelListeFacture);
            this.Controls.Add(this.dataGridViewListedesFactures);
            this.Name = "FormListeFacture";
            this.Text = "FormListeFacture";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListedesFactures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListedesFactures;
        private System.Windows.Forms.Label labelListeFacture;
        private System.Windows.Forms.Button buttonFermerListedesFactures;
    }
}