﻿namespace GestionMaxiTour
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
            this.dataGridFacture = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacture)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridFacture
            // 
            this.dataGridFacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFacture.Location = new System.Drawing.Point(12, 43);
            this.dataGridFacture.Name = "dataGridFacture";
            this.dataGridFacture.Size = new System.Drawing.Size(400, 244);
            this.dataGridFacture.TabIndex = 0;
            // 
            // FormListeFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 333);
            this.Controls.Add(this.dataGridFacture);
            this.Name = "FormListeFacture";
            this.Text = "FormListeFacture";
            this.Load += new System.EventHandler(this.FormListeFacture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFacture;
    }
}