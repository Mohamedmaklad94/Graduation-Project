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
    public partial class studyonline : Form
    {
        public studyonline()
        {
            InitializeComponent();
        }

        private void studyonline_Load(object sender, EventArgs e)
        {
            label5.Text = "Welcome " + LoggedinUser.userfname + " " + LoggedinUser.userlname + ", Here is Your Online Learn Corner!";
           

        }
        private void webBrowser1_Navigating(object sender, WebBrowserNavigatedEventArgs e)
        {
            
        }


        

        private void buttons1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Form2 main = new Form2();
            main.Show();
            this.Close();
        }

     

        

       

       

        private void pictureBox5_Click(object sender, EventArgs e)
        {
       
        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.udacity.com/");
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.coursera.org/");
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://maharatech.gov.eg/");
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pluralsight.com/");
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://stackoverflow.com/");
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.edraak.org/");
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kaggle.com/");
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://datavalley.technology/");
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.datacamp.com/");
        }
    }
}
