using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using ExaminationSystem.General;

namespace ExaminationSystem
{
    public partial class Form2 : Form
    {
       
       


        public Form2()
        {
            InitializeComponent();
        }



        private void panelcenter_Paint(object sender, PaintEventArgs e)
        {

        }
        private void movesidepanel(Button btn)
        {
            sidepanel.Top = btn.Top;
            sidepanel.Height = btn.Height;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttons1_Click(object sender, EventArgs e)
        {
            movesidepanel(buttons1);
            this.Close();
            Exam takeexam = new Exam();
            takeexam.Show();


        }

        private void buttons3_Click(object sender, EventArgs e)
        {
            movesidepanel(buttons3);
            GradesForm form = new GradesForm();
            form.Show();
            this.Close();
        }

        private void buttons4_Click(object sender, EventArgs e)
        {
            movesidepanel(buttons4);
            StudentInfo stinfo = new StudentInfo();
            stinfo.Show();
            this.Close();

        }

        private void buttons5_Click(object sender, EventArgs e)
        {
            movesidepanel(buttons5);
            studyonline stonline = new studyonline();
            stonline.Show();
            this.Close();
        }

        private void buttons6_Click(object sender, EventArgs e)
        {
            movesidepanel(buttons6);
            this.DialogResult = DialogResult.OK;
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
        #region Mouse Hover and leave coding
        private void buttons1_MouseHover(object sender, EventArgs e)
        {
            label4.Text = "Click to Start an Exam; The Exam Consist 10 Questions of MSQ and T or F.";
            //pictureBox1.Image = Image.FromFile("D:\\Bi Track - Mansroua Branch\\Grad-Project\\Project Icons\\homeForm\\2136911.png");
           
        }

        private void buttons1_MouseLeave(object sender, EventArgs e)
        {
            label4.Text = "";
            //pictureBox1.Image = Image.FromFile("D:\\Bi Track - Mansroua Branch\\Grad-Project\\Project Icons\\homeForm\\gddgsd-min.JPG");
        }

        private void buttons3_MouseHover(object sender, EventArgs e)
        {
            label4.Text = "Click to View the Result of Your Taken Exams and Grades.";
            //pictureBox1.Image = Image.FromFile("D:\\Bi Track - Mansroua Branch\\Grad-Project\\Project Icons\\homeForm\\2953969.png");
        }

        private void buttons3_MouseLeave(object sender, EventArgs e)
        {
            label4.Text = "";
            //pictureBox1.Image = Image.FromFile("D:\\Bi Track - Mansroua Branch\\Grad-Project\\Project Icons\\homeForm\\gddgsd-min.JPG");
        }

        private void buttons4_MouseHover(object sender, EventArgs e)
        {
            label4.Text = "Click to View Your Profile and Registered Information.";
            //pictureBox1.Image = Image.FromFile("D:\\Bi Track - Mansroua Branch\\Grad-Project\\Project Icons\\homeForm\\4022487.JPG");
        }

        private void buttons4_MouseLeave(object sender, EventArgs e)
        {
            label4.Text = "";
            //pictureBox1.Image = Image.FromFile("D:\\Bi Track - Mansroua Branch\\Grad-Project\\Project Icons\\homeForm\\gddgsd-min.JPG");
        }

        private void buttons5_MouseHover(object sender, EventArgs e)
        {
            label4.Text = "Click to Take Online Courses and Improve Your Skills.";
            //pictureBox1.Image = Image.FromFile("D:\\Bi Track - Mansroua Branch\\Grad-Project\\Project Icons\\homeForm\\4738370.JPG");
        }

        private void buttons5_MouseLeave(object sender, EventArgs e)
        {
            label4.Text = "";
            //pictureBox1.Image = Image.FromFile("D:\\Bi Track - Mansroua Branch\\Grad-Project\\Project Icons\\homeForm\\gddgsd-min.JPG");
        }

        private void buttons6_MouseHover(object sender, EventArgs e)
        {
            label4.Text = "Click to Sign Out and Back to Login Page.";
            //pictureBox1.Image = Image.FromFile("D:\\Bi Track - Mansroua Branch\\Grad-Project\\Project Icons\\homeForm\\5961144.JPG");
        }

        private void buttons6_MouseLeave(object sender, EventArgs e)
        {
            label4.Text = "";
            //pictureBox1.Image = Image.FromFile("D:\\Bi Track - Mansroua Branch\\Grad-Project\\Project Icons\\homeForm\\gddgsd-min.JPG");
        }
        #endregion

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

            label5.Text = "Welcome " + LoggedinUser.userfname +" "+ LoggedinUser.userlname +" !";
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //date
            label3.Text = DateTime.Now.ToLongDateString();
        }

        private void datelabel_Click(object sender, EventArgs e)
        {

        }

        private void panelleftside_Paint(object sender, PaintEventArgs e)
        {

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
            WindowsSizeControl.DoMaximize(this,btn);
        }
        #endregion

        private void sidepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
