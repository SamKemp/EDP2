namespace EDP2
{
    partial class frmHelp
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
            this.webHelp = new System.Windows.Forms.WebBrowser();
            this.buttClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webHelp
            // 
            this.webHelp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.webHelp.Location = new System.Drawing.Point(1, 1);
            this.webHelp.MinimumSize = new System.Drawing.Size(20, 20);
            this.webHelp.Name = "webHelp";
            this.webHelp.Size = new System.Drawing.Size(1090, 483);
            this.webHelp.TabIndex = 0;
            // 
            // buttClose
            // 
            this.buttClose.Location = new System.Drawing.Point(13, 490);
            this.buttClose.Name = "buttClose";
            this.buttClose.Size = new System.Drawing.Size(149, 61);
            this.buttClose.TabIndex = 1;
            this.buttClose.Text = "Close";
            this.buttClose.UseVisualStyleBackColor = true;
            this.buttClose.Click += new System.EventHandler(this.buttClose_Click);
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1095, 563);
            this.ControlBox = false;
            this.Controls.Add(this.buttClose);
            this.Controls.Add(this.webHelp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webHelp;
        private System.Windows.Forms.Button buttClose;
    }
}