using System;
using System.Drawing;
using System.Windows.Forms;

namespace EDP2
{
    public partial class FrmGame : Form
    {
        private int _score;
        private int _i;
        private int _question;
        private int _totalQuestions = 6;
        private int _answer;
        private int _prevanswer;
        private int _time;
        private int _TestMode = 0;

        public FrmGame()
        {
            InitializeComponent();

            //Attempt at Multi-Thredding
            // Do not use
            //
            //Thread thread = new Thread(labelUpdate);
            //thread.Start();

            if (_TestMode == 1)
            {
                buttRedTest.Visible = true;
                buttGreenTest.Visible = true;
                buttBlueTest.Visible = true;
                buttYellowTest.Visible = true;
                buttOrangeTest.Visible = true;
                buttPurpleTest.Visible = true;
            }
            else
            {
                buttRedTest.Visible = false;
                buttGreenTest.Visible = false;
                buttBlueTest.Visible = false;
                buttYellowTest.Visible = false;
                buttOrangeTest.Visible = false;
                buttPurpleTest.Visible = false;
            }

            //for testing
            //{
            //timer1.Interval = 10000;
            //}

            timer1.Interval = 60000;
            timer1.Start();

            timer2.Interval = 1000;
            timer2.Start();

            timer3.Interval = 10;
            timer3.Start();

            labQuestionTotal.Text = _totalQuestions.ToString();

            ChooseColor();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Button Red
        private void buttRed_Click(object sender, EventArgs e)
        {
            int Selected = 1;
            Checker(Selected);
        }
        
        //Button Green
        private void buttGreen_Click(object sender, EventArgs e)
        {
            int Selected = 2;
            Checker(Selected);
            
        }

        //Button Blue
        private void buttBlue_Click(object sender, EventArgs e)
        {
            int Selected = 3;
            Checker(Selected);
        }

        //Button Yellow
        private void buttYellow_Click(object sender, EventArgs e)
        {
            int Selected = 4;
            Checker(Selected);
        }

        //Button Orange
        private void buttOrange_Click(object sender, EventArgs e)
        {
            int Selected = 5;
            Checker(Selected);
        }

        //Button Purple
        private void buttPurple_Click(object sender, EventArgs e)
        {
            int Selected = 6;
            Checker(Selected);

        }

        public void Checker(int sel)
        {
            if (_answer == 0)
            {
                EndGame("Value returned null. Game must exit", "NULL value");
            }


            switch (sel)
            {
                case 1:
                    if (sel == _answer)
                    {
                        _score = _score + 10;
                    }
                    break;
                case 2:
                    if (sel == _answer)
                    {
                        _score = _score + 10;
                    }
                    break;
                case 3:
                    if (sel == _answer)
                    {
                        _score = _score + 10;
                    }
                    break;
                case 4:
                    if (sel == _answer)
                    {
                        _score = _score + 10;
                    }
                    break;
                case 5:
                    if (sel == _answer)
                    {
                        _score = _score + 10;
                    }
                    break;
                case 6:
                    if (sel == _answer)
                    {
                        _score = _score + 10;
                    }
                    break;
                default:
                    ChooseColor();
                    break;
            }

            //Question number code
            _question ++;

            labQuestionNum.Text = _question.ToString();

            if (_question == _totalQuestions)
            {
                if (_score == _totalQuestions * 10)
                {
                    _score = _score + 40;
                    if (_time < 60)
                    {
                        _score = _score + _time;
                    }
                }

                StopTimers();

                EndGame("You got a score of: " + _score, "Final score");
            }

            _prevanswer = _answer;
            //Goto Choose Color
            ChooseColor();
        }

        //Not needed
        //public void labelUpdate()
        //{
        //    for (int _i = 0; _i <= 60; _i++)
        //    {
        //        //pause for 999 miliseconds
        //        System.Threading.Thread.Sleep(999);
        //
        //        //Gets time remaining
        //        int time = 60 - _i;
        //
        //        //Set the label
        //        labTimeNum.Text = time.ToString();
        //    }
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_score == _totalQuestions * 10)
            {
                _score = _score + 40;
                if (_time < 60)
                {
                    _score = _score + _time;
                }
            }

            StopTimers();

            EndGame("You got a score of: " + _score, "Final score");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (_i <= 60)
            {
                //Some maths
                //Gets time remaining
                _time = 60 - _i;
            
                //Update timer label
                labTimeNum.Text = _time.ToString();

                //Add 1 to _i
                _i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_score == _totalQuestions * 10)
            {
                _score = _score + 40;
                if (_time < 60)
                {
                    _score = _score + _time;
                }
            }

            StopTimers();

            EndGame("You got a score of: " + _score , "Final score");
        }

        public void ChooseColor()
        {
            _answer = 0;
            pictureBox.BackColor = Color.Black;

            System.Threading.Thread.Sleep(500);

            Random rnd = new Random();
            int number = rnd.Next(6);

            switch (number)
            {
                case 0:
                    ChooseColor();
                    break;
                case 1:
                    QuestionChecker(number);
                    pictureBox.BackColor = Color.Red;
                    _answer = 1;
                    break;
                case 2:
                    QuestionChecker(number);
                    pictureBox.BackColor = Color.Green;
                    _answer = 2;
                    break;
                case 3:
                    QuestionChecker(number);
                    pictureBox.BackColor = Color.Blue;
                    _answer = 3;
                    break;
                case 4:
                    QuestionChecker(number);
                    pictureBox.BackColor = Color.Yellow;
                    _answer = 4;
                    break;
                case 5:
                    QuestionChecker(number);
                    pictureBox.BackColor = Color.Orange;
                    _answer = 5;
                    break;
                case 6:
                    QuestionChecker(number);
                    pictureBox.BackColor = Color.Purple;
                    _answer = 6;
                    break;
                default:
                    EndGame("Value returned null. Game must exit", "NULL value");
                    break;
            }
        }

        public void QuestionChecker(int number)
        {
            if (_prevanswer == number)
            {
                ChooseColor();
            }
        }

        public void EndGame(string reason, string title)
        {
            ScoreUpdate();

            MessageBox.Show(reason, title, MessageBoxButtons.OK);
            Close();
        }

        private void UploadToLeaderboard()
        {
            
        }

        private void labQuestion_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            ScoreUpdate();
        }

        private void ScoreUpdate()
        {
            //Update the _score label
            labScoreNum.Text = _score.ToString();
        }

        private void StopTimers()
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
        }
    }
}
