using ExaminationSystem.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExaminationSystem.BL;


namespace ExaminationSystem
{
    public partial class Exam : Form
    {

        
        public Exam()
        {
            InitializeComponent();
        }

        //public static string courseName;

        public string courseName { get; set; }

        public static int ExamNo { get; set; }


        private void Exam_Load(object sender, EventArgs e)
        {
            label5.Text = "Welcome " + LoggedinUser.userfname + " " + LoggedinUser.userlname + " !";

            DataTable tabel = new DataTable();
            tabel = PreExamFormBL.GetCourses();
            //set default value
            DataRow itemrow = tabel.NewRow();
            itemrow[1] = "Select Course";
            tabel.Rows.InsertAt(itemrow, 0);
            cbcourses.DataSource = tabel;
            cbcourses.DisplayMember = "Crs_Name";
            cbcourses.ValueMember = "Crs_ID";
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

       

        private void datelabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label3.Text = DateTime.Now.ToString();
            //datelabel.Text = DateTime.Now.ToLongDateString();
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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //date
            label3.Text = DateTime.Now.ToLongDateString();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        /*private void buttons1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "1")
            {


                string getext = cbcourses.SelectedText.ToString();
                MessageBox.Show("You've Selected " + cbcourses.Text + " Course", "NOTE", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                //MessageBox.show
            }
        }*/

        private void buttons4_Click(object sender, EventArgs e)
        {
            if (cbcourses.Text == "Select Course")
            {
                MessageBox.Show("Please select course first", "Select Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                courseName = cbcourses.Text;
                ExamNo = int.Parse(PreExamFormBL.GetExamNo().Rows[0][0].ToString())+1;
                int result = PreExamFormBL.GenerateExam(Form1.userid2, courseName, ExamNo);
                if (result > 0)
                {
                    //MessageBox.Show("Exmam has been generted", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ExamForm form = new ExamForm();
                    form.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You have examed this before", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbcourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelleftside_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttons1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Form2 main = new Form2();
            main.Show();
            this.Close();
        }

        /*private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buttons3_Click(object sender, EventArgs e)
        {

        }*/
    }
}
