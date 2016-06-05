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
            this.dataGridCamion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCamion)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCamion
            // 
            this.dataGridCamion.AllowUserToAddRows = false;
            this.dataGridCamion.AllowUserToDeleteRows = false;
            this.dataGridCamion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCamion.Location = new System.Drawing.Point(11, 22);
            this.dataGridCamion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridCamion.Name = "dataGridCamion";
            this.dataGridCamion.ReadOnly = true;
            this.dataGridCamion.RowTemplate.Height = 33;
            this.dataGridCamion.Size = new System.Drawing.Size(830, 353);
            this.dataGridCamion.TabIndex = 3;
            // 
            // FormListeCamions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 401);
            this.Controls.Add(this.dataGridCamion);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormListeCamions";
            this.Text = "Liste des Camions";
            this.Load += new System.EventHandler(this.FormListeCamions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCamion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCamion;
    }
}