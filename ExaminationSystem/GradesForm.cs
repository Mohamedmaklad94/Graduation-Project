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
    public partial class GradesForm : Form
    {
        public GradesForm()
        {
            InitializeComponent();
        }

        private void GradesForm_Load(object sender, EventArgs e)
        {

            label5.Text = LoggedinUser.userfname + " " + LoggedinUser.userlname +", Welcome to Grades System Page!";
            dgvgrades.DataSource = GradesFormBL.GetStudGrades(Form1.userid2);
            cbcourses.Hide();


            /*DataTable tabel = new DataTable();
            tabel = GradesFormBL.GetStudCourses(Form1.userid2);
            //set default value
            DataRow itemrow = tabel.NewRow();
            itemrow[1] = "All Courses Grades";
            tabel.Rows.InsertAt(itemrow, 0);
            cbcourses.DataSource = tabel;
            cbcourses.DisplayMember = "Crs_Name";
            cbcourses.ValueMember = "Crs_ID";*/
        }

        #region close, minimize, maximize buttons
        private void buttons2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttons3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Form2 main = new Form2();
            main.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost/ReportServer/Pages/ReportViewer.aspx?%2fReport+Project4%2fReport2&rs:Command=Render");
        }

        private void buttons2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maxbtn_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            WindowsSizeControl.DoMaximize(this, btn);
        }

        private void buttons7_Click_1(object sender, EventArgs e)
        {
            WindowsSizeControl.Minimize(this);
        }

        private void Cbcourses_SelectedValueChanged(object sender, EventArgs e)
        {
            /*if (cbcourses.Text == "All Courses Grades")
            {
                labelexamdate.Text = "";
                labelinstructor.Text = "";
                dgvgrades.DataSource = GradesFormBL.GetStudGrades(Form1.userid2);
            }*/
            //else
            //{
            //    string[] _grades = new string[4];
            //    _grades= GradesFormBL.GetStudGrades(Form1.userid2,cbcourses.Text).Rows[0].ItemArray.Select(x => x.ToString()).ToArray();
            //    labelexamdate.Text = DateTime.Parse(_grades[1]).ToShortDateString();
            //    labelinstructor.Text = _grades[2];
            //    DataTable _temp = new DataTable();
            //    _temp = GradesFormBL.GetStudGrades(Form1.userid2, cbcourses.Text);
            //    _temp.Columns.Remove(_temp.Columns[1]);
            //    _temp.Columns.Remove(_temp.Columns[1]);
            //    //dgvgrades.DataSource = GradesFormBL.GetStudGrades(Form1.userid2, cbcourses.Text).Columns[2];
            //    dgvgrades.DataSource = _temp;
            //}
        }

        private void Dgvgrades_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string _Crs_Name = dgvgrades.Rows[e.RowIndex].Cells[0].Value.ToString();
            string[] _grades = new string[4];
            _grades= GradesFormBL.GetStudGrades(Form1.userid2, _Crs_Name).Rows[0].ItemArray.Select(x => x.ToString()).ToArray();

            lblcrsname.Text = _grades[0];
            labelexamdate.Text = DateTime.Parse(_grades[1]).ToShortDateString();
            labelinstructor.Text = _grades[2];
            lblcrsgrade.Text = _grades[3];
        }
    }
}
