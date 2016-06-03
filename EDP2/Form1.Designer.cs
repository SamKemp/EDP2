namespace EDP2
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butStart = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.buttAbout = new System.Windows.Forms.Button();
            this.buttHelp = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 276);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // butStart
            // 
            this.butStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butStart.Location = new System.Drawing.Point(12, 301);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(178, 67);
            this.butStart.TabIndex = 1;
            this.butStart.Text = "Start";
            this.ToolTip.SetToolTip(this.butStart, "Starts the Game");
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // butClose
            // 
            this.butClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClose.Location = new System.Drawing.Point(216, 301);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(178, 67);
            this.butClose.TabIndex = 2;
            this.butClose.Text = "Close";
            this.ToolTip.SetToolTip(this.butClose, "Closes the Menu");
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttAbout
            // 
            this.buttAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttAbout.Location = new System.Drawing.Point(216, 374);
            this.buttAbout.Name = "buttAbout";
            this.buttAbout.Size = new System.Drawing.Size(178, 67);
            this.buttAbout.TabIndex = 4;
            this.buttAbout.Text = "About";
            this.ToolTip.SetToolTip(this.buttAbout, "Opens the About Box");
            this.buttAbout.UseVisualStyleBackColor = true;
            this.buttAbout.Click += new System.EventHandler(this.buttAbout_Click);
            // 
            // buttHelp
            // 
            this.buttHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttHelp.Location = new System.Drawing.Point(12, 374);
            this.buttHelp.Name = "buttHelp";
            this.buttHelp.Size = new System.Drawing.Size(178, 67);
            this.buttHelp.TabIndex = 3;
            this.buttHelp.Text = "Help";
            this.ToolTip.SetToolTip(this.buttHelp, "Opens the Help Box");
            this.buttHelp.UseVisualStyleBackColor = true;
            this.buttHelp.Click += new System.EventHandler(this.buttHelp_Click);
            // 
            // ToolTip
            // 
            this.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip.ToolTipTitle = "Help";
            this.ToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.ControlBox = false;
            this.Controls.Add(this.buttAbout);
            this.Controls.Add(this.buttHelp);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMenu";
            this.Text = "Color Matcher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button buttAbout;
        private System.Windows.Forms.Button buttHelp;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}

