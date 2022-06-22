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
using ExaminationSystem.General;
using ExaminationSystem.BL;

namespace ExaminationSystem
{
    public partial class Form1 : Form
        
    {

        public static int userid2;
        //public static string userid;

        public Form1()
        {
            InitializeComponent();
        }

        private void paneltop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void iti_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutus_Click(object sender, EventArgs e)
        {
            this.Close();
            AbousUs abut = new AbousUs();
            abut.Show();
        }

        private void rateus_Click(object sender, EventArgs e)
        {
            
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            //userid = textBox1.Text;

            if (int.TryParse(textBox1.Text,out userid2))
            {
                if (stradibtn.Checked)
                {
                    DataTable dt = new DataTable();
                    dt = Form1BL.StudLogin(int.Parse(textBox1.Text.Trim()), textBox2.Text.Trim());

                    //userid = textBox1.Text;

                    if (dt.Rows.Count == 1)
                    {
                        userid2 = int.Parse(textBox1.Text);
                        DataRow userrow = dt.Rows[0];
                        LoggedinUser.userfname = userrow["ST_Fname"].ToString();
                        LoggedinUser.userlname = userrow["ST_Lname"].ToString();

                        this.Hide();
                        Form2 stmain = new Form2();
                        stmain.Show();

                    }
                    else
                    {
                        MessageBox.Show("Invaild User ID or Password", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (insradiobtn.Checked)
                {
                    DataTable dt = new DataTable();
                    dt = Form1BL.InsLogin(int.Parse(textBox1.Text.Trim()), textBox2.Text.Trim());

                    //userid = textBox1.Text;

                    if (dt.Rows.Count == 1)
                    {
                        userid2 = int.Parse(textBox1.Text);
                        DataRow userrow = dt.Rows[0];
                        LoggedinUser.userfname = userrow["INS_Name"].ToString();
                        this.Hide();
                        Staff insmain = new Staff();
                        insmain.Show();

                    }
                    else
                    {
                        MessageBox.Show("Invaild User ID or Password", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else

                    MessageBox.Show("Please Choose User Type", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invaild User ID or Password", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://iti.gov.eg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://facebook.com/ITI.eg");

        }

        private void linkedbutton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://linkedin.com/school/information-technology-institute-iti-/");

        }

        private void twitterbutton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/iti_channel");

        }
    }
}
