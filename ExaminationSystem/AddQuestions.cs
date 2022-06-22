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
    public partial class AddQuestions : Form
    {
        public AddQuestions()
        {
            InitializeComponent();
        }

         
        //public static string courseName;

        public string courseName { get; set; }

        private void AddQuestions_Load(object sender, EventArgs e)
        {
            
            comboBox1.Items.Clear();
            comboBox1.Items.Add("MCQ");
            comboBox1.Items.Add("T F");
            comboBox2.Items.Clear();

            DataTable tabel = new DataTable();
            tabel = AddQuestionsFormBL.GetCoursesForStaff(Form1.userid2);
            //set default value
            DataRow itemrow = tabel.NewRow();
            itemrow[1] = "Select Course";
            tabel.Rows.InsertAt(itemrow, 0);
            cbcourses.DataSource = tabel;
            cbcourses.DisplayMember = "Crs_Name";
            cbcourses.ValueMember = "Crs_ID";
            questbtn.Hide();
        }

        #region close, minimize, maximize buttons
        private void buttons2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maxbtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            WindowsSizeControl.DoMaximize(this, btn);
        }

        private void buttons7_Click(object sender, EventArgs e)
        {
            WindowsSizeControl.Minimize(this);
        }
        #endregion

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Staff mainstaff = new Staff();
            mainstaff.Show();
            this.Close();
        }

        private void questbtn_Enter(object sender, EventArgs e)
        {
            if (questbtn.Text == "Question ID")
            {
                questbtn.Text = "";

                questbtn.ForeColor = Color.White;
            }
        }

        private void questbtn_Leave(object sender, EventArgs e)
        {
            if (questbtn.Text == "")
            {
                questbtn.Text = "Question ID";

                questbtn.ForeColor = Color.Gainsboro;
            }
        }

        private void questcontbtn_Enter(object sender, EventArgs e)
        {
            if (questcontbtn.Text == "Question Content")
            {
                questcontbtn.Text = "";

                questcontbtn.ForeColor = Color.White;
            }
        }

        private void questcontbtn_Leave(object sender, EventArgs e)
        {
            if (questcontbtn.Text == "")
            {
                questcontbtn.Text = "Question Content";

                questcontbtn.ForeColor = Color.Gainsboro;
            }
        }

        private void questybebtn_Enter(object sender, EventArgs e)
        {
            if (questybebtn.Text == "Question Type")
            {
                questybebtn.Text = "";

                questybebtn.ForeColor = Color.White;
            }
        }

        private void questybebtn_Leave(object sender, EventArgs e)
        {
            if (questybebtn.Text == "")
            {
                questybebtn.Text = "Question Type";

                questybebtn.ForeColor = Color.Gainsboro;
            }
        }

        private void option1btn_Enter(object sender, EventArgs e)
        {
            if (option1btn.Text == "Option 1")
            {
                option1btn.Text = "";

                option1btn.ForeColor = Color.White;
            }
        }

        private void option1btn_Leave(object sender, EventArgs e)
        {
            if (option1btn.Text == "")
            {
                option1btn.Text = "Option 1";

                option1btn.ForeColor = Color.Gainsboro;
            }
        }

        private void option2btn_Enter(object sender, EventArgs e)
        {
            if (option2btn.Text == "Option 2")
            {
                option2btn.Text = "";

                option2btn.ForeColor = Color.White;
            }
        }

        private void option2btn_Leave(object sender, EventArgs e)
        {
            if (option2btn.Text == "")
            {
                option2btn.Text = "Option 2";

                option2btn.ForeColor = Color.Gainsboro;
            }
        }

        private void option3btn_Enter(object sender, EventArgs e)
        {
            if (option3btn.Text == "Option 3")
            {
                option3btn.Text = "";

                option3btn.ForeColor = Color.White;
            }
        }

        private void option3btn_Leave(object sender, EventArgs e)
        {
            if (option3btn.Text == "")
            {
                option3btn.Text = "Option 3";

                option3btn.ForeColor = Color.Gainsboro;
            }
        }

        private void option4btn_Enter(object sender, EventArgs e)
        {
            if (option4btn.Text == "Option 4")
            {
                option4btn.Text = "";

                option4btn.ForeColor = Color.White;
            }
        }

        private void option4btn_Leave(object sender, EventArgs e)
        {
            if (option4btn.Text == "")
            {
                option4btn.Text = "Option 4";

                option4btn.ForeColor = Color.Gainsboro;
            }
        }

        private void Cbcourses_SelectedValueChanged(object sender, EventArgs e)
        {
             dgvquestions.DataSource = AddQuestionsFormBL.GetQuestionsForStaff(cbcourses.Text);
        }

        private void Dgvquestions_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            questbtn.Text = dgvquestions.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBox1.Text = dgvquestions.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox2.Text = dgvquestions.Rows[e.RowIndex].Cells[2].Value.ToString();

            questcontbtn.Text = dgvquestions.Rows[e.RowIndex].Cells[3].Value.ToString();

            if (dgvquestions.Rows[e.RowIndex].Cells[1].Value.ToString() == "MCQ")
            {
                option1btn.Show();
                option2btn.Show();
                option3btn.Show();
                option4btn.Show();
                option1btn.Text = dgvquestions.Rows[e.RowIndex].Cells[4].Value.ToString();
                option2btn.Text = dgvquestions.Rows[e.RowIndex].Cells[5].Value.ToString();
                option3btn.Text = dgvquestions.Rows[e.RowIndex].Cells[6].Value.ToString();
                option4btn.Text = dgvquestions.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            else
            {
                option1btn.Hide();
                option2btn.Hide();
                option3btn.Hide();
                option4btn.Hide();
            }

        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (cbcourses.Text == "Select Course")
            {
                MessageBox.Show("Please Select Course Firsrt", "Select course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(comboBox1.Text == "MCQ" || comboBox1.Text == "T F"))
            {
                MessageBox.Show("Please Select Question Type", "Select Question Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(comboBox2.Text == "1" || comboBox2.Text == "2" || comboBox2.Text == "3" || comboBox2.Text == "4"))
            {
                MessageBox.Show("Please Select Correct Answer", "Select Correct answer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (questcontbtn.Text == "Question Content")
            {
                MessageBox.Show("Please Write Question Content", "Question Content", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (option1btn.Text == "Option 1")
            {
                MessageBox.Show("Please Write Choice 1", "Choices", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (option2btn.Text == "Option 2")
            {
                MessageBox.Show("Please Write Choice 2", "Choices", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (option3btn.Text == "Option 3")
            {
                MessageBox.Show("Please Write Choice 3", "Choices", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (option4btn.Text == "Option 4")
            {
                MessageBox.Show("Please Write Choice 4", "Choices", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to Add Question? ", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    AddQuestionsFormBL.AddNewQuestion(comboBox1.Text, int.Parse(comboBox2.Text), questcontbtn.Text, cbcourses.Text, option1btn.Text, option2btn.Text, option3btn.Text, option4btn.Text);
                    BunifuThinButton23_Click(this.bunifuThinButton23, e);
                    //Cbcourses_SelectedValueChanged(this.dgvquestions, e);

                }
            }
        }

        private void BunifuThinButton23_Click(object sender, EventArgs e)
        {
            questbtn.Text = "";
            questbtn_Leave(this.questbtn, e);
            questcontbtn.Text = "";
            questcontbtn_Leave(this.questcontbtn, e);
            questybebtn.Text = "";
            questybebtn_Leave(this.questybebtn, e);
            option1btn.Text = "";
            option1btn_Leave(this.option1btn, e);
            option2btn.Text = "";
            option2btn_Leave(this.option2btn, e);
            option3btn.Text = "";
            option3btn_Leave(this.option3btn, e);
            option4btn.Text = "";
            option4btn_Leave(this.option4btn, e);
            AddQuestions_Load(this, e);
        }

        private void questybebtn_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttons1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Staff mainstaff = new Staff();
            mainstaff.Show();
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

            
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            
        }

        private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "MCQ")
            {
                option1btn.Show();
                option2btn.Show();
                option3btn.Show();
                option4btn.Show();
                comboBox2.Items.Clear();
                comboBox2.Items.Add("1");
                comboBox2.Items.Add("2");
                comboBox2.Items.Add("3");
                comboBox2.Items.Add("4");

            }
            else if (comboBox1.Text == "T F")
            {
                option1btn.Hide();
                option2btn.Hide();
                option3btn.Hide();
                option4btn.Hide();
                comboBox2.Items.Clear();
                comboBox2.Items.Add("1");
                comboBox2.Items.Add("2");
            }
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (cbcourses.Text == "Select Course")
            {
                MessageBox.Show("Please Select Course Firsrt", "Select course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(comboBox1.Text == "MCQ" || comboBox1.Text == "T F"))
            {
                MessageBox.Show("Please Select Question Type", "Select Question Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(comboBox2.Text == "1" || comboBox2.Text == "2" || comboBox2.Text == "3" || comboBox2.Text == "4"))
            {
                MessageBox.Show("Please Select Correct Answer", "Select Correct answer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to Edit Question? ", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    AddQuestionsFormBL.UpdateQuestion(int.Parse(questbtn.Text), comboBox1.Text, int.Parse(comboBox2.Text), questcontbtn.Text, cbcourses.Text, option1btn.Text, option2btn.Text, option3btn.Text, option4btn.Text);
                    BunifuThinButton23_Click(this.bunifuThinButton23, e);
                    //Cbcourses_SelectedValueChanged(this.dgvquestions, e);
                }
            }
        }

        private void BunifuThinButton24_Click(object sender, EventArgs e)
        {
            //if (cbcourses.Text == "Select Course")
            //{
            //    MessageBox.Show("Please Select Course Firsrt", "Select course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else if (!(comboBox1.Text == "MCQ" || comboBox1.Text == "T F"))
            //{
            //    MessageBox.Show("Please Select Question Type", "Select Question Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else if (!(comboBox2.Text == "1" || comboBox2.Text == "2" || comboBox2.Text == "3" || comboBox2.Text == "4"))
            //{
            //    MessageBox.Show("Please Select Correct Answer", "Select Correct answer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            if (questbtn.Text== "Question ID")
            {
                MessageBox.Show("Please Select Question First", "Select Question", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to Delete Question " + questbtn.Text + " ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    AddQuestionsFormBL.DeleteQuestion(int.Parse(questbtn.Text));
                    BunifuThinButton23_Click(this.bunifuThinButton23, e);
                    //Cbcourses_SelectedValueChanged(this.dgvquestions, e);
                }
            }
        }

        private void cbcourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
