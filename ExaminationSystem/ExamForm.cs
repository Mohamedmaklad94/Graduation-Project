using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExaminationSystem.BL;
using ExaminationSystem.General;

namespace ExaminationSystem
{
    public partial class ExamForm : Form
    {
        // Exam time
        int _ticks = 2 * 60;
        int[] answers = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
        
        public ExamForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        /*public static void DisplayQuestion(int _St_ID, int _Exam_No, int _Counter)
        {
            lblquestion.Text = QuestCounter + ExamFormBL.GetQuestion(2, 1, QuestCounter).Rows[0][0].ToString();
        }*/

        public int QuestCounter = 1;

        private void ExamForm_Load(object sender, EventArgs e)
        {
            lblquestion.Text = QuestCounter + " - " + ExamFormBL.GetQuestion(Form1.userid2, Exam.ExamNo, QuestCounter).Rows[0][0].ToString();
            if (ExamFormBL.GetQuestion(Form1.userid2, Exam.ExamNo, QuestCounter).Rows[0][1].ToString() == "MCQ")
            {
                rbchoice1.Show();
                rbchoice2.Show();
                rbchoice3.Show();
                rbchoice4.Show();
                rbchoice1.Text = ExamFormBL.GetChoices(Form1.userid2, Exam.ExamNo , QuestCounter).Rows[0][0].ToString();
                rbchoice2.Text = ExamFormBL.GetChoices(Form1.userid2, Exam.ExamNo , QuestCounter).Rows[1][0].ToString();
                rbchoice3.Text = ExamFormBL.GetChoices(Form1.userid2, Exam.ExamNo , QuestCounter).Rows[2][0].ToString();
                rbchoice4.Text = ExamFormBL.GetChoices(Form1.userid2, Exam.ExamNo , QuestCounter).Rows[3][0].ToString();
            }
            else
            {
                rbchoice1.Text = "True";
                rbchoice2.Text = "False";
                rbchoice3.Hide();
                rbchoice4.Hide();
            }


            // New Part For Back Button 
            if (answers[QuestCounter - 1] == -1)
            {
                rbchoice1.Checked = rbchoice2.Checked = rbchoice3.Checked = rbchoice4.Checked = false;
            }
            else if (answers[QuestCounter - 1] == 1)
            {
                rbchoice1.Checked = true;
            }
            else if (answers[QuestCounter - 1] == 2)
            {
                rbchoice2.Checked = true;
            }
            else if (answers[QuestCounter - 1] == 3)
            {
                rbchoice3.Checked = true;
            }
            else if (answers[QuestCounter - 1] == 4)
            {
                rbchoice4.Checked = true;
            }
        }



        private void Btnanswer_Click(object sender, EventArgs e)
        {
            //int _result;
            //if (rbchoice1.Checked) _result = 1;
            //else if (rbchoice2.Checked) _result = 2;
            //else if (rbchoice3.Checked) _result = 3;
            //else if (rbchoice4.Checked) _result = 4;
            //else _result = -1;
            //ExamFormBL.AnswerQuestion(Form1.userid2, Exam.ExamNo, QuestCounter, _result);
            //QuestCounter++;
            //rbchoice1.Checked = rbchoice2.Checked = rbchoice3.Checked = rbchoice4.Checked = false;
            //if (QuestCounter != 11)
            //{
            //    ExamForm_Load(this, e);
            //}
            //else
            //{
            //    ExamFormBL.CorrectExam(Form1.userid2, Exam.ExamNo);
            //    MessageBox.Show("Exam Has Been Finished. ");
            //    Form2 form = new Form2();
            //    form.Show();
            //    this.Close();
            //}
        }

        private void buttons1_Click(object sender, EventArgs e)
        {
            
            int _result;
            if (rbchoice1.Checked) _result = 1;
            else if (rbchoice2.Checked) _result = 2;
            else if (rbchoice3.Checked) _result = 3;
            else if (rbchoice4.Checked) _result = 4;
            else _result = -1;
            ExamFormBL.AnswerQuestion(Form1.userid2, Exam.ExamNo, QuestCounter, _result);
            answers[QuestCounter - 1] = _result;

            if (QuestCounter != 10)
            {
                QuestCounter++;
                rbchoice1.Checked = rbchoice2.Checked = rbchoice3.Checked = rbchoice4.Checked = false;
                ExamForm_Load(this, e);
            }
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks--;
            counttimelabel.Text = _ticks / 60 + ":" + ((_ticks % 60) >= 10 ? (_ticks % 60).ToString() : "0" + (_ticks % 60));
            if (_ticks == 0)
            {
                timer1.Stop();
                ExamFormBL.CorrectExam(Form1.userid2, Exam.ExamNo);
                MessageBox.Show("your time has over.","Time Finished",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Form2 form = new Form2();
                form.Show();
                this.Close();
            }
        }

        #region close, minimize, maximize buttons
        private void buttons2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to exit exam? ", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                ExamFormBL.CorrectExam(Form1.userid2, Exam.ExamNo);
                Application.Exit();
            } 
        }

        private void buttons7_Click(object sender, EventArgs e)
        {
            WindowsSizeControl.Minimize(this);
        }

        private void maxbtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            WindowsSizeControl.DoMaximize(this, btn);
        }
        #endregion

        private void ExamForm_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            ExamFormBL.CorrectExam(Form1.userid2, Exam.ExamNo);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            //if (QuestCounter != 1)
            //{
            //    int _result;
            //    if (rbchoice1.Checked) _result = 1;
            //    else if (rbchoice2.Checked) _result = 2;
            //    else if (rbchoice3.Checked) _result = 3;
            //    else if (rbchoice4.Checked) _result = 4;
            //    else _result = -1;
            //    int _result3 = ExamFormBL.AnswerQuestion(Form1.userid2, Exam.ExamNo, QuestCounter, _result);
            //    answers[QuestCounter - 1] = _result;
            //    QuestCounter--;
            //    ExamForm_Load(this, e);
            //}
        }

        private void Btnfinish_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Are you sure to finish exam? ", "Alert", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    ExamFormBL.CorrectExam(Form1.userid2, Exam.ExamNo);
            //    Form2 form = new Form2();
            //    form.Show();
            //    this.Close();
            //}
            /*else if (dialogResult == DialogResult.No)
            {
                //do something else
            }*/
            
        }

        private void buttons3_Click(object sender, EventArgs e)
        {
            if (QuestCounter != 1)
            {
                int _result;
                if (rbchoice1.Checked) _result = 1;
                else if (rbchoice2.Checked) _result = 2;
                else if (rbchoice3.Checked) _result = 3;
                else if (rbchoice4.Checked) _result = 4;
                else _result = -1;
                int _result3 = ExamFormBL.AnswerQuestion(Form1.userid2, Exam.ExamNo, QuestCounter, _result);
                answers[QuestCounter - 1] = _result;
                QuestCounter--;
                ExamForm_Load(this, e);
            }
        }

        private void buttons4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to finish exam? ", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                ExamFormBL.CorrectExam(Form1.userid2, Exam.ExamNo);
                Form2 form = new Form2();
                form.Show();
                this.Close();
            }
        }
    }
}
