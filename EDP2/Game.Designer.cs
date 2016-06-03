namespace EDP2
{
    partial class FrmGame
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
            this.buttRed = new System.Windows.Forms.Button();
            this.buttGreen = new System.Windows.Forms.Button();
            this.buttBlue = new System.Windows.Forms.Button();
            this.labScore = new System.Windows.Forms.Label();
            this.labScoreNum = new System.Windows.Forms.Label();
            this.labTimeNum = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labQuestionNum = new System.Windows.Forms.Label();
            this.labQuestion = new System.Windows.Forms.Label();
            this.labQuestionTotal = new System.Windows.Forms.Label();
            this.labQuestion2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.buttClose = new System.Windows.Forms.Button();
            this.buttPurple = new System.Windows.Forms.Button();
            this.buttOrange = new System.Windows.Forms.Button();
            this.buttYellow = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.buttRedTest = new System.Windows.Forms.Button();
            this.buttGreenTest = new System.Windows.Forms.Button();
            this.buttBlueTest = new System.Windows.Forms.Button();
            this.buttYellowTest = new System.Windows.Forms.Button();
            this.buttOrangeTest = new System.Windows.Forms.Button();
            this.buttPurpleTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttRed
            // 
            this.buttRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttRed.Location = new System.Drawing.Point(12, 429);
            this.buttRed.Name = "buttRed";
            this.buttRed.Size = new System.Drawing.Size(248, 88);
            this.buttRed.TabIndex = 0;
            this.buttRed.Text = "Red";
            this.buttRed.UseVisualStyleBackColor = true;
            this.buttRed.Click += new System.EventHandler(this.buttRed_Click);
            // 
            // buttGreen
            // 
            this.buttGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttGreen.Location = new System.Drawing.Point(266, 429);
            this.buttGreen.Name = "buttGreen";
            this.buttGreen.Size = new System.Drawing.Size(248, 88);
            this.buttGreen.TabIndex = 1;
            this.buttGreen.Text = "Green";
            this.buttGreen.UseVisualStyleBackColor = true;
            this.buttGreen.Click += new System.EventHandler(this.buttGreen_Click);
            // 
            // buttBlue
            // 
            this.buttBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttBlue.Location = new System.Drawing.Point(520, 429);
            this.buttBlue.Name = "buttBlue";
            this.buttBlue.Size = new System.Drawing.Size(248, 88);
            this.buttBlue.TabIndex = 2;
            this.buttBlue.Text = "Blue";
            this.buttBlue.UseVisualStyleBackColor = true;
            this.buttBlue.Click += new System.EventHandler(this.buttBlue_Click);
            // 
            // labScore
            // 
            this.labScore.AutoSize = true;
            this.labScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labScore.Location = new System.Drawing.Point(497, 9);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(163, 55);
            this.labScore.TabIndex = 3;
            this.labScore.Text = "Score:";
            // 
            // labScoreNum
            // 
            this.labScoreNum.AutoSize = true;
            this.labScoreNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labScoreNum.Location = new System.Drawing.Point(666, 9);
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
            this.labQuestionNum.Location = new System.Drawing.Point(416, 624);
            this.labQuestionNum.Name = "labQuestionNum";
            this.labQuestionNum.Size = new System.Drawing.Size(51, 55);
            this.labQuestionNum.TabIndex = 9;
            this.labQuestionNum.Text = "0";
            // 
            // labQuestion
            // 
            this.labQuestion.AutoSize = true;
            this.labQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQuestion.Location = new System.Drawing.Point(205, 624);
            this.labQuestion.Name = "labQuestion";
            this.labQuestion.Size = new System.Drawing.Size(216, 55);
            this.labQuestion.TabIndex = 8;
            this.labQuestion.Text = "Question";
            this.labQuestion.Click += new System.EventHandler(this.labQuestion_Click);
            // 
            // labQuestionTotal
            // 
            this.labQuestionTotal.AutoSize = true;
            this.labQuestionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQuestionTotal.Location = new System.Drawing.Point(634, 624);
            this.labQuestionTotal.Name = "labQuestionTotal";
            this.labQuestionTotal.Size = new System.Drawing.Size(51, 55);
            this.labQuestionTotal.TabIndex = 11;
            this.labQuestionTotal.Text = "0";
            // 
            // labQuestion2
            // 
            this.labQuestion2.AutoSize = true;
            this.labQuestion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQuestion2.Location = new System.Drawing.Point(484, 624);
            this.labQuestion2.Name = "labQuestion2";
            this.labQuestion2.Size = new System.Drawing.Size(144, 55);
            this.labQuestion2.TabIndex = 10;
            this.labQuestion2.Text = "out of";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // buttClose
            // 
            this.buttClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttClose.Location = new System.Drawing.Point(12, 624);
            this.buttClose.Name = "buttClose";
            this.buttClose.Size = new System.Drawing.Size(99, 55);
            this.buttClose.TabIndex = 12;
            this.buttClose.Text = "Quit";
            this.buttClose.UseVisualStyleBackColor = true;
            this.buttClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttPurple
            // 
            this.buttPurple.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttPurple.Location = new System.Drawing.Point(519, 522);
            this.buttPurple.Name = "buttPurple";
            this.buttPurple.Size = new System.Drawing.Size(248, 88);
            this.buttPurple.TabIndex = 15;
            this.buttPurple.Text = "Purple";
            this.buttPurple.UseVisualStyleBackColor = true;
            this.buttPurple.Click += new System.EventHandler(this.buttPurple_Click);
            // 
            // buttOrange
            // 
            this.buttOrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttOrange.Location = new System.Drawing.Point(265, 522);
            this.buttOrange.Name = "buttOrange";
            this.buttOrange.Size = new System.Drawing.Size(248, 88);
            this.buttOrange.TabIndex = 14;
            this.buttOrange.Text = "Orange";
            this.buttOrange.UseVisualStyleBackColor = true;
            this.buttOrange.Click += new System.EventHandler(this.buttOrange_Click);
            // 
            // buttYellow
            // 
            this.buttYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttYellow.Location = new System.Drawing.Point(11, 522);
            this.buttYellow.Name = "buttYellow";
            this.buttYellow.Size = new System.Drawing.Size(248, 88);
            this.buttYellow.TabIndex = 13;
            this.buttYellow.Text = "Yellow";
            this.buttYellow.UseVisualStyleBackColor = true;
            this.buttYellow.Click += new System.EventHandler(this.buttYellow_Click);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // buttRedTest
            // 
            this.buttRedTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttRedTest.Location = new System.Drawing.Point(204, 486);
            this.buttRedTest.Name = "buttRedTest";
            this.buttRedTest.Size = new System.Drawing.Size(56, 31);
            this.buttRedTest.TabIndex = 16;
            this.buttRedTest.Text = "Test";
            this.buttRedTest.UseVisualStyleBackColor = true;
            // 
            // buttGreenTest
            // 
            this.buttGreenTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttGreenTest.Location = new System.Drawing.Point(457, 485);
            this.buttGreenTest.Name = "buttGreenTest";
            this.buttGreenTest.Size = new System.Drawing.Size(56, 31);
            this.buttGreenTest.TabIndex = 17;
            this.buttGreenTest.Text = "Test";
            this.buttGreenTest.UseVisualStyleBackColor = true;
            // 
            // buttBlueTest
            // 
            this.buttBlueTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttBlueTest.Location = new System.Drawing.Point(710, 486);
            this.buttBlueTest.Name = "buttBlueTest";
            this.buttBlueTest.Size = new System.Drawing.Size(56, 31);
            this.buttBlueTest.TabIndex = 18;
            this.buttBlueTest.Text = "Test";
            this.buttBlueTest.UseVisualStyleBackColor = true;
            // 
            // buttYellowTest
            // 
            this.buttYellowTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttYellowTest.Location = new System.Drawing.Point(204, 579);
            this.buttYellowTest.Name = "buttYellowTest";
            this.buttYellowTest.Size = new System.Drawing.Size(56, 31);
            this.buttYellowTest.TabIndex = 19;
            this.buttYellowTest.Text = "Test";
            this.buttYellowTest.UseVisualStyleBackColor = true;
            // 
            // buttOrangeTest
            // 
            this.buttOrangeTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttOrangeTest.Location = new System.Drawing.Point(457, 579);
            this.buttOrangeTest.Name = "buttOrangeTest";
            this.buttOrangeTest.Size = new System.Drawing.Size(56, 31);
            this.buttOrangeTest.TabIndex = 20;
            this.buttOrangeTest.Text = "Test";
            this.buttOrangeTest.UseVisualStyleBackColor = true;
            // 
            // buttPurpleTest
            // 
            this.buttPurpleTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttPurpleTest.Location = new System.Drawing.Point(710, 579);
            this.buttPurpleTest.Name = "buttPurpleTest";
            this.buttPurpleTest.Size = new System.Drawing.Size(56, 31);
            this.buttPurpleTest.TabIndex = 21;
            this.buttPurpleTest.Text = "Test";
            this.buttPurpleTest.UseVisualStyleBackColor = true;
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 689);
            this.ControlBox = false;
            this.Controls.Add(this.buttPurpleTest);
            this.Controls.Add(this.buttOrangeTest);
            this.Controls.Add(this.buttYellowTest);
            this.Controls.Add(this.buttBlueTest);
            this.Controls.Add(this.buttGreenTest);
            this.Controls.Add(this.buttRedTest);
            this.Controls.Add(this.buttPurple);
            this.Controls.Add(this.buttOrange);
            this.Controls.Add(this.buttYellow);
            this.Controls.Add(this.buttClose);
            this.Controls.Add(this.labQuestionTotal);
            this.Controls.Add(this.labQuestion2);
            this.Controls.Add(this.labQuestionNum);
            this.Controls.Add(this.labQuestion);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labTimeNum);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.labScoreNum);
            this.Controls.Add(this.labScore);
            this.Controls.Add(this.buttBlue);
            this.Controls.Add(this.buttGreen);
            this.Controls.Add(this.buttRed);
            this.Name = "FrmGame";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttRed;
        private System.Windows.Forms.Button buttGreen;
        private System.Windows.Forms.Button buttBlue;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Label labScoreNum;
        private System.Windows.Forms.Label labTimeNum;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labQuestionNum;
        private System.Windows.Forms.Label labQuestion;
        private System.Windows.Forms.Label labQuestionTotal;
        private System.Windows.Forms.Label labQuestion2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button buttClose;
        private System.Windows.Forms.Button buttPurple;
        private System.Windows.Forms.Button buttOrange;
        private System.Windows.Forms.Button buttYellow;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button buttRedTest;
        private System.Windows.Forms.Button buttGreenTest;
        private System.Windows.Forms.Button buttBlueTest;
        private System.Windows.Forms.Button buttYellowTest;
        private System.Windows.Forms.Button buttOrangeTest;
        private System.Windows.Forms.Button buttPurpleTest;
    }
}