namespace GestionMaxiTour
{
    partial class FormListeImprevu
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
            this.labelListeImprevu = new System.Windows.Forms.Label();
            this.dataGridViewListeImprevu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeImprevu)).BeginInit();
            this.SuspendLayout();
            // 
            // labelListeImprevu
            // 
            this.labelListeImprevu.AutoSize = true;
            this.labelListeImprevu.Location = new System.Drawing.Point(12, 9);
            this.labelListeImprevu.Name = "labelListeImprevu";
            this.labelListeImprevu.Size = new System.Drawing.Size(45, 13);
            this.labelListeImprevu.TabIndex = 0;
            this.labelListeImprevu.Text = "Imprevu";
            // 
            // dataGridViewListeImprevu
            // 
            this.dataGridViewListeImprevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListeImprevu.Location = new System.Drawing.Point(12, 25);
            this.dataGridViewListeImprevu.Name = "dataGridViewListeImprevu";
            this.dataGridViewListeImprevu.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewListeImprevu.TabIndex = 1;
            // 
            // FormListeImprevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 185);
            this.Controls.Add(this.dataGridViewListeImprevu);
            this.Controls.Add(this.labelListeImprevu);
            this.Name = "FormListeImprevu";
            this.Text = "ListeImprevu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeImprevu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListeImprevu;
        private System.Windows.Forms.DataGridView dataGridViewListeImprevu;
    }
}