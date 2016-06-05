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
            this.dataGridImprevus = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridImprevus)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridImprevus
            // 
            this.dataGridImprevus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridImprevus.Location = new System.Drawing.Point(12, 25);
            this.dataGridImprevus.Name = "dataGridImprevus";
            this.dataGridImprevus.Size = new System.Drawing.Size(440, 272);
            this.dataGridImprevus.TabIndex = 1;
            // 
            // FormListeImprevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 309);
            this.Controls.Add(this.dataGridImprevus);
            this.Name = "FormListeImprevu";
            this.Text = "ListeImprevu";
            this.Load += new System.EventHandler(this.FormListeImprevu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridImprevus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridImprevus;
    }
}