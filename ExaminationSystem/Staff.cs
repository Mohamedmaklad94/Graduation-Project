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

namespace ExaminationSystem
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void buttons6_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.OK;
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void buttons8_Click(object sender, EventArgs e)
        {
            this.Close();
            Reports rep = new Reports();
            rep.Show();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttons1_Click(object sender, EventArgs e)
        {
            this.Close();
            AddQuestions quest = new AddQuestions();
            quest.Show();
        }

        private void buttons4_Click(object sender, EventArgs e)
        {
            this.Close();
            AddStudent addst = new AddStudent();
            addst.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttons3_Click(object sender, EventArgs e)
        {
            StudentGrades stgrades = new StudentGrades();
            stgrades.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {
            label5.Text = "Welcome Eng." + LoggedinUser.userfname + " !";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString();
        }

        private void buttons8_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void buttons8_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "Click to View All Reports.";
            //pictureBox1.Image = Image.FromFile("D:\\Bi Track - Mansroua Branch\\Grad-Project\\Project Icons\\homeForm\\2136911.png");
        }

        private void buttons8_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
            //pictureBox1.Image = Image.FromFile("D:\\Bi Track - Mansroua Branch\\Grad-Project\\Project Icons\\homeForm\\gddgsd-min.JPG");
        }

        private void buttons1_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "Click to Add, Edit, and Delete Questions.";
            //pictureBox1.Image = Image.FromFile("D:\\Bi Track - Mansroua Branch\\Grad-Project\\Project Icons\\homeForm\\2136911.png");
        }

        private void buttons1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
            //pictureBox1.Image = Image.FromFile("D:\\Bi Track - Mansroua Branch\\Grad-Project\\Project Icons\\homeForm\\gddgsd-min.JPG");
        }

        private void buttons3_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "Click to View Student Grades.";
            //pictureBox1.Image = Image.FromFile("D:\\Bi Track - Mansroua Branch\\Grad-Project\\Project Icons\\homeForm\\2136911.png");
        }

        private void buttons3_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
            //pictureBox1.Image = Image.FromFile("D:\\Bi Track - Mansroua Branch\\Grad-Project\\Project Icons\\homeForm\\gddgsd-min.JPG");
        }

        private void buttons4_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "Click to View Student Info.";
            //pictureBox1.Image = Image.FromFile("D:\\Bi Track - Mansroua Branch\\Grad-Project\\Project Icons\\homeForm\\2136911.png");
        }

        private void buttons4_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
            //pictureBox1.Image = Image.FromFile("D:\\Bi Track - Mansroua Branch\\Grad-Project\\Project Icons\\homeForm\\gddgsd-min.JPG");
        }

        private void buttons5_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "Click to View, Add, and Delete Departments.";
            //pictureBox1.Image = Image.FromFile("D:\\Bi Track - Mansroua Branch\\Grad-Project\\Project Icons\\homeForm\\2136911.png");
        }

        private void buttons5_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
            //pictureBox1.Image = Image.FromFile("D:\\Bi Track - Mansroua Branch\\Grad-Project\\Project Icons\\homeForm\\2136911.png");
        }

        private void buttons6_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "Click to Sign Out and Back to Login Page.";
            //pictureBox1.Image = Image.FromFile("D:\\Bi Track - Mansroua Branch\\Grad-Project\\Project Icons\\homeForm\\5961144.JPG");
        }

        private void buttons6_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
            //pictureBox1.Image = Image.FromFile("D:\\Bi Track - Mansroua Branch\\Grad-Project\\Project Icons\\homeForm\\5961144.JPG");
        }

        private void buttons5_Click(object sender, EventArgs e)
        {
            AddDepartment form = new AddDepartment();
            form.Show();
            this.Close();
        }
    }
}
