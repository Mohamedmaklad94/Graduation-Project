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
using ExaminationSystem.BL;


namespace ExaminationSystem
{
    public partial class StudentGrades : Form
    {
        public StudentGrades()
        {
            InitializeComponent();
        }

        private void buttons2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttons7_Click(object sender, EventArgs e)
        {
            WindowsSizeControl.Minimize(this);
        }

        private void cbcourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StudentGrades_Load(object sender, EventArgs e)
        {
            DataTable tabel = new DataTable();
            tabel = AddQuestionsFormBL.GetCoursesForStaff(Form1.userid2);
            //set default value
            DataRow itemrow = tabel.NewRow();
            itemrow[1] = "Select Course";
            tabel.Rows.InsertAt(itemrow, 0);
            cbcourses.DataSource = tabel;
            cbcourses.DisplayMember = "Crs_Name";
            cbcourses.ValueMember = "Crs_ID";

            
            
        }

        private void buttons1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Staff staffhome = new Staff();
            staffhome.Show();
            this.Close();
        }

        private void Cbcourses_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvgrades.DataSource = StaffGradeFormBL.GetGradesStuff(cbcourses.Text);
        }
    }
}
