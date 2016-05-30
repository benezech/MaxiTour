namespace GestionMaxiTour
{
    partial class FormListeClients
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
            this.dataGridListeClients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListeClients)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(472, 415);
            this.buttonFermer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(110, 27);
            this.buttonFermer.TabIndex = 5;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            // 
            // dataGridListeClients
            // 
            this.dataGridListeClients.AllowUserToAddRows = false;
            this.dataGridListeClients.AllowUserToDeleteRows = false;
            this.dataGridListeClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListeClients.Location = new System.Drawing.Point(25, 23);
            this.dataGridListeClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridListeClients.Name = "dataGridListeClients";
            this.dataGridListeClients.ReadOnly = true;
            this.dataGridListeClients.RowTemplate.Height = 33;
            this.dataGridListeClients.Size = new System.Drawing.Size(774, 347);
            this.dataGridListeClients.TabIndex = 3;
            // 
            // FormListeClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 381);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.dataGridListeClients);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormListeClients";
            this.Text = "Liste des Clients";
            this.Load += new System.EventHandler(this.FormListeClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListeClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.DataGridView dataGridListeClients;
    }
}