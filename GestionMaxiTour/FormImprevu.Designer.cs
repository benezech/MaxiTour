namespace GestionMaxiTour
{
    partial class Imprevu
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
            this.labelType = new System.Windows.Forms.Label();
            this.labelCout = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxCout = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(12, 9);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 0;
            this.labelType.Text = "Type";
            // 
            // labelCout
            // 
            this.labelCout.AutoSize = true;
            this.labelCout.Location = new System.Drawing.Point(12, 34);
            this.labelCout.Name = "labelCout";
            this.labelCout.Size = new System.Drawing.Size(29, 13);
            this.labelCout.TabIndex = 1;
            this.labelCout.Text = "Cout";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(122, 9);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(100, 20);
            this.textBoxType.TabIndex = 2;
            // 
            // textBoxCout
            // 
            this.textBoxCout.Location = new System.Drawing.Point(122, 31);
            this.textBoxCout.Name = "textBoxCout";
            this.textBoxCout.Size = new System.Drawing.Size(100, 20);
            this.textBoxCout.TabIndex = 3;
            // 
            // Imprevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 61);
            this.Controls.Add(this.textBoxCout);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.labelCout);
            this.Controls.Add(this.labelType);
            this.Name = "Imprevu";
            this.Text = "FormImprevu";
            this.Load += new System.EventHandler(this.FormImprevu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelCout;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxCout;
    }
}