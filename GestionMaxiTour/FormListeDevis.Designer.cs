namespace GestionMaxiTour
{
    partial class FormListeDevis
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
            this.dataGridDevis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDevis)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDevis
            // 
            this.dataGridDevis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDevis.Location = new System.Drawing.Point(22, 22);
            this.dataGridDevis.Name = "dataGridDevis";
            this.dataGridDevis.ReadOnly = true;
            this.dataGridDevis.Size = new System.Drawing.Size(1050, 383);
            this.dataGridDevis.TabIndex = 0;
            // 
            // FormListeDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 435);
            this.Controls.Add(this.dataGridDevis);
            this.Name = "FormListeDevis";
            this.Text = "Liste de Devis";
            this.Load += new System.EventHandler(this.FormListeDevis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDevis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDevis;
    }
}