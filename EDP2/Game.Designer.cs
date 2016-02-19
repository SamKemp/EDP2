namespace EDP2
{
    partial class frmGame
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
            this.buttColor1 = new System.Windows.Forms.Button();
            this.buttColor2 = new System.Windows.Forms.Button();
            this.buttColor3 = new System.Windows.Forms.Button();
            this.labScore = new System.Windows.Forms.Label();
            this.labScoreNum = new System.Windows.Forms.Label();
            this.labTimeNum = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labQuestionNum = new System.Windows.Forms.Label();
            this.labQuestion = new System.Windows.Forms.Label();
            this.labQuestionTotal = new System.Windows.Forms.Label();
            this.labQuestion2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttColor1
            // 
            this.buttColor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttColor1.Location = new System.Drawing.Point(12, 429);
            this.buttColor1.Name = "buttColor1";
            this.buttColor1.Size = new System.Drawing.Size(248, 88);
            this.buttColor1.TabIndex = 0;
            this.buttColor1.Text = "Red";
            this.buttColor1.UseVisualStyleBackColor = true;
            // 
            // buttColor2
            // 
            this.buttColor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttColor2.Location = new System.Drawing.Point(266, 429);
            this.buttColor2.Name = "buttColor2";
            this.buttColor2.Size = new System.Drawing.Size(248, 88);
            this.buttColor2.TabIndex = 1;
            this.buttColor2.Text = "Red";
            this.buttColor2.UseVisualStyleBackColor = true;
            // 
            // buttColor3
            // 
            this.buttColor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttColor3.Location = new System.Drawing.Point(520, 429);
            this.buttColor3.Name = "buttColor3";
            this.buttColor3.Size = new System.Drawing.Size(248, 88);
            this.buttColor3.TabIndex = 2;
            this.buttColor3.Text = "Red";
            this.buttColor3.UseVisualStyleBackColor = true;
            // 
            // labScore
            // 
            this.labScore.AutoSize = true;
            this.labScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labScore.Location = new System.Drawing.Point(550, 9);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(163, 55);
            this.labScore.TabIndex = 3;
            this.labScore.Text = "Score:";
            // 
            // labScoreNum
            // 
            this.labScoreNum.AutoSize = true;
            this.labScoreNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labScoreNum.Location = new System.Drawing.Point(719, 9);
            this.labScoreNum.Name = "labScoreNum";
            this.labScoreNum.Size = new System.Drawing.Size(51, 55);
            this.labScoreNum.TabIndex = 4;
            this.labScoreNum.Text = "0";
            // 
            // labTimeNum
            // 
            this.labTimeNum.AutoSize = true;
            this.labTimeNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTimeNum.Location = new System.Drawing.Point(385, 9);
            this.labTimeNum.Name = "labTimeNum";
            this.labTimeNum.Size = new System.Drawing.Size(51, 55);
            this.labTimeNum.TabIndex = 6;
            this.labTimeNum.Text = "0";
            this.labTimeNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTime.Location = new System.Drawing.Point(12, 9);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(367, 55);
            this.labTime.TabIndex = 5;
            this.labTime.Text = "Time remaining:";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(204, 122);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(371, 253);
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // labQuestionNum
            // 
            this.labQuestionNum.AutoSize = true;
            this.labQuestionNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQuestionNum.Location = new System.Drawing.Point(355, 529);
            this.labQuestionNum.Name = "labQuestionNum";
            this.labQuestionNum.Size = new System.Drawing.Size(51, 55);
            this.labQuestionNum.TabIndex = 9;
            this.labQuestionNum.Text = "0";
            // 
            // labQuestion
            // 
            this.labQuestion.AutoSize = true;
            this.labQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQuestion.Location = new System.Drawing.Point(133, 529);
            this.labQuestion.Name = "labQuestion";
            this.labQuestion.Size = new System.Drawing.Size(216, 55);
            this.labQuestion.TabIndex = 8;
            this.labQuestion.Text = "Question";
            // 
            // labQuestionTotal
            // 
            this.labQuestionTotal.AutoSize = true;
            this.labQuestionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQuestionTotal.Location = new System.Drawing.Point(562, 529);
            this.labQuestionTotal.Name = "labQuestionTotal";
            this.labQuestionTotal.Size = new System.Drawing.Size(78, 55);
            this.labQuestionTotal.TabIndex = 11;
            this.labQuestionTotal.Text = "10";
            // 
            // labQuestion2
            // 
            this.labQuestion2.AutoSize = true;
            this.labQuestion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQuestion2.Location = new System.Drawing.Point(412, 529);
            this.labQuestion2.Name = "labQuestion2";
            this.labQuestion2.Size = new System.Drawing.Size(144, 55);
            this.labQuestion2.TabIndex = 10;
            this.labQuestion2.Text = "out of";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 593);
            this.Controls.Add(this.labQuestionTotal);
            this.Controls.Add(this.labQuestion2);
            this.Controls.Add(this.labQuestionNum);
            this.Controls.Add(this.labQuestion);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labTimeNum);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.labScoreNum);
            this.Controls.Add(this.labScore);
            this.Controls.Add(this.buttColor3);
            this.Controls.Add(this.buttColor2);
            this.Controls.Add(this.buttColor1);
            this.Name = "frmGame";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttColor1;
        private System.Windows.Forms.Button buttColor2;
        private System.Windows.Forms.Button buttColor3;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Label labScoreNum;
        private System.Windows.Forms.Label labTimeNum;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labQuestionNum;
        private System.Windows.Forms.Label labQuestion;
        private System.Windows.Forms.Label labQuestionTotal;
        private System.Windows.Forms.Label labQuestion2;
    }
}