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
            this.labelListeClient = new System.Windows.Forms.Label();
            this.dataGridViewListeClients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeClients)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFermer
            // 
            this.buttonFermer.Location = new System.Drawing.Point(944, 799);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(219, 51);
            this.buttonFermer.TabIndex = 5;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            // 
            // labelListeClient
            // 
            this.labelListeClient.AutoSize = true;
            this.labelListeClient.Location = new System.Drawing.Point(92, 95);
            this.labelListeClient.Name = "labelListeClient";
            this.labelListeClient.Size = new System.Drawing.Size(183, 25);
            this.labelListeClient.TabIndex = 4;
            this.labelListeClient.Text = "Liste des Clients :";
            // 
            // dataGridViewListeClients
            // 
            this.dataGridViewListeClients.AllowUserToAddRows = false;
            this.dataGridViewListeClients.AllowUserToDeleteRows = false;
            this.dataGridViewListeClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListeClients.Location = new System.Drawing.Point(97, 155);
            this.dataGridViewListeClients.Name = "dataGridViewListeClients";
            this.dataGridViewListeClients.ReadOnly = true;
            this.dataGridViewListeClients.RowTemplate.Height = 33;
            this.dataGridViewListeClients.Size = new System.Drawing.Size(1066, 584);
            this.dataGridViewListeClients.TabIndex = 3;
            // 
            // FormListeClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 897);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.labelListeClient);
            this.Controls.Add(this.dataGridViewListeClients);
            this.Name = "FormListeClients";
            this.Text = "Liste des Clients";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.Label labelListeClient;
        private System.Windows.Forms.DataGridView dataGridViewListeClients;
    }
}