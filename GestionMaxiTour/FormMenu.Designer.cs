namespace GestionMaxiTour
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tourneeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factureTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.devisTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.imprevusTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.clientTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.chauffeurTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.camionTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tourneeToolStripMenuItem,
            this.factureTSMI,
            this.devisTSMI,
            this.imprevusTSMI,
            this.clientTSMI,
            this.chauffeurTSMI,
            this.camionTSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(497, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tourneeToolStripMenuItem
            // 
            this.tourneeToolStripMenuItem.Name = "tourneeToolStripMenuItem";
            this.tourneeToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.tourneeToolStripMenuItem.Text = "Tournées";
            this.tourneeToolStripMenuItem.Click += new System.EventHandler(this.tourneeToolStripMenuItem_Click);
            // 
            // factureTSMI
            // 
            this.factureTSMI.Name = "factureTSMI";
            this.factureTSMI.Size = new System.Drawing.Size(63, 20);
            this.factureTSMI.Text = "Factures";
            this.factureTSMI.Click += new System.EventHandler(this.factureTSMI_Click);
            // 
            // devisTSMI
            // 
            this.devisTSMI.Name = "devisTSMI";
            this.devisTSMI.Size = new System.Drawing.Size(47, 20);
            this.devisTSMI.Text = "Devis";
            this.devisTSMI.Click += new System.EventHandler(this.devisTSMI_Click);
            // 
            // imprevusTSMI
            // 
            this.imprevusTSMI.Name = "imprevusTSMI";
            this.imprevusTSMI.Size = new System.Drawing.Size(68, 20);
            this.imprevusTSMI.Text = "Imprévus";
            this.imprevusTSMI.Click += new System.EventHandler(this.imprevusTSMI_Click);
            // 
            // clientTSMI
            // 
            this.clientTSMI.Name = "clientTSMI";
            this.clientTSMI.Size = new System.Drawing.Size(50, 20);
            this.clientTSMI.Text = "Client";
            this.clientTSMI.Click += new System.EventHandler(this.clientTSMI_Click);
            // 
            // chauffeurTSMI
            // 
            this.chauffeurTSMI.Name = "chauffeurTSMI";
            this.chauffeurTSMI.Size = new System.Drawing.Size(72, 20);
            this.chauffeurTSMI.Text = "Chauffeur";
            this.chauffeurTSMI.Click += new System.EventHandler(this.chauffeurTSMI_Click);
            // 
            // camionTSMI
            // 
            this.camionTSMI.Name = "camionTSMI";
            this.camionTSMI.Size = new System.Drawing.Size(61, 20);
            this.camionTSMI.Text = "Camion";
            this.camionTSMI.Click += new System.EventHandler(this.camionTSMI_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(497, 316);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "MaxiTour";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem factureTSMI;
        private System.Windows.Forms.ToolStripMenuItem tourneeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devisTSMI;
        private System.Windows.Forms.ToolStripMenuItem imprevusTSMI;
        private System.Windows.Forms.ToolStripMenuItem clientTSMI;
        private System.Windows.Forms.ToolStripMenuItem chauffeurTSMI;
        private System.Windows.Forms.ToolStripMenuItem camionTSMI;

    }
}