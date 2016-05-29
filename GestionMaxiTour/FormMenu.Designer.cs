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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.factureTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.devisTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.tourneeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.factureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.imprevusTSMI = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripTextBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(458, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // factureTSMI
            // 
            this.factureTSMI.Name = "factureTSMI";
            this.factureTSMI.Size = new System.Drawing.Size(63, 23);
            this.factureTSMI.Text = "Factures";
            this.factureTSMI.Click += new System.EventHandler(this.factureTSMI_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // devisTSMI
            // 
            this.devisTSMI.Name = "devisTSMI";
            this.devisTSMI.Size = new System.Drawing.Size(47, 23);
            this.devisTSMI.Text = "Devis";
            this.devisTSMI.Click += new System.EventHandler(this.devisTSMI_Click);
            // 
            // tourneeToolStripMenuItem
            // 
            this.tourneeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devisToolStripMenuItem1,
            this.factureToolStripMenuItem});
            this.tourneeToolStripMenuItem.Name = "tourneeToolStripMenuItem";
            this.tourneeToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.tourneeToolStripMenuItem.Text = "Tournées";
            // 
            // devisToolStripMenuItem1
            // 
            this.devisToolStripMenuItem1.Name = "devisToolStripMenuItem1";
            this.devisToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.devisToolStripMenuItem1.Text = "Devis";
            // 
            // factureToolStripMenuItem
            // 
            this.factureToolStripMenuItem.Name = "factureToolStripMenuItem";
            this.factureToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.factureToolStripMenuItem.Text = "Factures";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenue sur MaxiTour";
            // 
            // imprevusTSMI
            // 
            this.imprevusTSMI.Name = "imprevusTSMI";
            this.imprevusTSMI.Size = new System.Drawing.Size(68, 23);
            this.imprevusTSMI.Text = "Imprévus";
            this.imprevusTSMI.Click += new System.EventHandler(this.imprevusTSMI_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 125);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem tourneeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devisToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem factureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devisTSMI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem imprevusTSMI;

    }
}