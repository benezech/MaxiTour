namespace GestionMaxiTour
{
    partial class FormListeTournees
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
            this.dataGridTournee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTournee)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTournee
            // 
            this.dataGridTournee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTournee.Location = new System.Drawing.Point(41, 24);
            this.dataGridTournee.Name = "dataGridTournee";
            this.dataGridTournee.Size = new System.Drawing.Size(780, 343);
            this.dataGridTournee.TabIndex = 0;
            // 
            // FormListeTournees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 360);
            this.Controls.Add(this.dataGridTournee);
            this.Name = "FormListeTournees";
            this.Text = "FormListeTournees";
            this.Load += new System.EventHandler(this.FormListeTournees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTournee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTournee;
    }
}