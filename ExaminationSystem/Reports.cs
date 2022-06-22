using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExaminationSystem.General;
using Microsoft.Reporting.WinForms;


namespace ExaminationSystem
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        private void movesidepanel(Button btn)
        {
            sidepanel.Top = btn.Top;
            sidepanel.Height = btn.Height;

        }

        private void Reports_Load(object sender, EventArgs e)
        {
            label5.Text = "Welcome " + LoggedinUser.userfname + " " + LoggedinUser.userlname + " !";
            reportViewer1.Visible = false;
            reportViewer2.Visible = false;
            reportViewer3.Visible = false;
            reportViewer4.Visible = false;
            reportViewer5.Visible = false;
            reportViewer6.Visible = false;

            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        #region reports buttons

        private void buttons8_Click(object sender, EventArgs e)
        {
            movesidepanel(buttons8);
            reportViewer1.Visible = true;
            if (reportViewer1.Visible == true)
            {
                this.reportViewer1.RefreshReport();
                this.reportViewer6.Hide();
                this.reportViewer5.Hide();
                this.reportViewer4.Hide();
                this.reportViewer3.Hide();
                this.reportViewer2.Hide();
            }

        }

        private void buttons1_Click(object sender, EventArgs e)
        {
            movesidepanel(buttons1);

            reportViewer2.Visible = true;
            if (reportViewer2.Visible == true)
            {
                this.reportViewer2.RefreshReport();
                this.reportViewer6.Hide();
                this.reportViewer5.Hide();
                this.reportViewer4.Hide();
                this.reportViewer3.Hide();
                this.reportViewer1.Hide();
            }

        }

        private void buttons3_Click(object sender, EventArgs e)
        {
            movesidepanel(buttons3);
            reportViewer3.Visible = true;
            if (reportViewer3.Visible == true)
            {
                this.reportViewer3.RefreshReport();
                this.reportViewer6.Hide();
                this.reportViewer5.Hide();
                this.reportViewer4.Hide();
                this.reportViewer2.Hide();
                this.reportViewer1.Hide();
            }
        }

        private void buttons4_Click(object sender, EventArgs e)
        {
            movesidepanel(buttons4);
            reportViewer4.Visible = true;
            if (reportViewer4.Visible == true)
            {
                this.reportViewer4.RefreshReport();
                this.reportViewer6.Hide();
                this.reportViewer5.Hide();
                this.reportViewer2.Hide();
                this.reportViewer3.Hide();
                this.reportViewer1.Hide();
            }
        }

        private void buttons5_Click(object sender, EventArgs e)
        {
            movesidepanel(buttons5);
            reportViewer5.Visible = true;
            if (reportViewer5.Visible == true)
            {
                this.reportViewer5.RefreshReport();
                this.reportViewer6.Hide();
                this.reportViewer2.Hide();
                this.reportViewer4.Hide();
                this.reportViewer3.Hide();
                this.reportViewer1.Hide();
            }
        }

        private void buttons6_Click(object sender, EventArgs e)
        {
            movesidepanel(buttons6);
            reportViewer6.Visible = true;
            if (reportViewer6.Visible == true)
            {
                this.reportViewer6.RefreshReport();
                this.reportViewer2.Hide();
                this.reportViewer5.Hide();
                this.reportViewer4.Hide();
                this.reportViewer3.Hide();
                this.reportViewer1.Hide();
            }
           
        }
        #endregion

        #region close, minimize, maximize buttons
        private void buttons2_Click(object sender, EventArgs e)
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
        #endregion

        #region Mouse Hover and leaves  
        private void buttons8_MouseHover(object sender, EventArgs e)
        {
            label4.Text = "Click to View The Report of Students Information According to Department No..";
        }

        private void buttons8_MouseLeave(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void buttons1_MouseHover(object sender, EventArgs e)
        {
            label4.Text = "Click to View The Grades Report of The Student in All Courses According to His ID..";
        }

        private void buttons1_MouseLeave(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void buttons3_MouseHover(object sender, EventArgs e)
        {
            label4.Text = "Click to View the Report of Instructor and the Name of the Courses he Teaches and the Number of students per course..";
        }

        private void buttons3_MouseLeave(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void buttons4_MouseHover(object sender, EventArgs e)
        {
            label4.Text = "Click to View the Report of Courses and Which Topic's the Course Belong to..";
        }

        private void buttons4_MouseLeave(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void buttons5_MouseHover(object sender, EventArgs e)
        {
            label4.Text = "Click to View the Questions per Selected Exam..";
        }

        private void buttons5_MouseLeave(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void buttons6_MouseHover(object sender, EventArgs e)
        {
            label4.Text = "Click to View the Questions in the Selected Exam with the Student Answers..";
        }

        private void buttons6_MouseLeave(object sender, EventArgs e)
        {
            label4.Text = "";
        }
        #endregion

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttons9_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Staff main = new Staff();
            main.Show();
            this.Close();
        }

        private void Buttons9_Click_1(object sender, EventArgs e)
        {
            Staff form = new Staff();
            form.Show();
            this.Close();
        }
    }
}
