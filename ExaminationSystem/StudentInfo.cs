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
using System.IO;
using System.Data.SqlClient;

namespace ExaminationSystem
{
    public partial class StudentInfo : Form
    {
        public StudentInfo()
        {
            InitializeComponent();
        }

        private void buttons1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Form2 main = new Form2();
            main.Show();
            this.Close();
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

        private void webbutton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://identity.iti.gov.eg/Account/Login?");
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = AddStudentsFormBL.GetStudPic(Form1.userid2);

            ////if (ds.Tables[0].Rows.Count > 0)
            ////{
            //MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["ST_pic"]);
            ////pictureBox2.Image = new Bitmap(ms);

            ////}

            if (ds.Tables[0].Rows.Count == 1)
            {
                Byte[] data = new Byte[0];
                data = (Byte[])(ds.Tables[0].Rows[0]["ST_pic"]);
                MemoryStream mem = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(mem);
            }

            string[] _info = new string[8];
            _info = StudInfoFormBL.GetStudInfo(Form1.userid2).Rows[0].ItemArray.Select(x => x.ToString()).ToArray();
            labelid.Text = _info[0];
            labelfname.Text = _info[1];
            labellname.Text = _info[2];
            labeladd.Text = _info[3];
            labeldob.Text = DateTime.Parse(_info[4]).ToShortDateString();
            labelpass.Text = _info[5];
            labelphone.Text = _info[6];
            labeldept.Text = _info[7];
        }
    }
}
