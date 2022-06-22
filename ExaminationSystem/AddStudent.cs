using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework;
using ExaminationSystem.General;
using ExaminationSystem.BL;
using System.IO;
using System.Data.SqlClient;

namespace ExaminationSystem
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

       

        private void stfnametxtbox_OnValueChanged(object sender, EventArgs e)
        {

        }



        #region Student Textboxes


        private void stidtxtbox_Enter(object sender, EventArgs e)
        {
            if (stidtxtbox.Text == "Student ID")
            {
                stidtxtbox.Text = "";

                stidtxtbox.ForeColor = Color.White;
            }
        }

        private void stidtxtbox_Leave(object sender, EventArgs e)
        {
            if (stidtxtbox.Text == "")
            {
                stidtxtbox.Text = "Student ID";

                stidtxtbox.ForeColor = Color.Gainsboro;
            }
        }

       

        private void stfnametxtbox_Enter(object sender, EventArgs e)
        {
            if (stfnametxtbox.Text == "Student First Name")
            {
                stfnametxtbox.Text = "";

                stfnametxtbox.ForeColor = Color.White;
            }
        }

        private void stfnametxtbox_Leave(object sender, EventArgs e)
        {
            if (stfnametxtbox.Text == "")
            {
                stfnametxtbox.Text = "Student First Name";

                stfnametxtbox.ForeColor = Color.Gainsboro;
            }
        }

        private void stlnametxtbox_Enter(object sender, EventArgs e)
        {
            if (stlnametxtbox.Text == "Student Last Name")
            {
                stlnametxtbox.Text = "";

                stlnametxtbox.ForeColor = Color.White;
            }
        }

        private void stlnametxtbox_Leave(object sender, EventArgs e)
        {
            if (stlnametxtbox.Text == "")
            {
                stlnametxtbox.Text = "Student Last Name";

                stlnametxtbox.ForeColor = Color.Gainsboro;
            }

        }

        private void staddtxtbox_Enter(object sender, EventArgs e)
        {
            if (staddtxtbox.Text == "Student Address")
            {
                staddtxtbox.Text = "";

                staddtxtbox.ForeColor = Color.White;
            }
        }

        private void staddtxtbox_Leave(object sender, EventArgs e)
        {
            if (staddtxtbox.Text == "")
            {
                staddtxtbox.Text = "Student Address";

                staddtxtbox.ForeColor = Color.Gainsboro;
            }

        }

        private void stdobtxtbox_Enter(object sender, EventArgs e)
        {
            if (stdobtxtbox.Text == "Student Birth Date")
            {
                stdobtxtbox.Text = "";

                stdobtxtbox.ForeColor = Color.White;
            }
        }

        private void stdobtxtbox_Leave(object sender, EventArgs e)
        {

            if (stdobtxtbox.Text == "")
            {
                stdobtxtbox.Text = "Student Birth Date";

                stdobtxtbox.ForeColor = Color.Gainsboro;
            }
        }

        private void stpasstxtbox_Enter(object sender, EventArgs e)
        {
            if (stpasstxtbox.Text == "Student Pass")
            {
                stpasstxtbox.Text = "";

                stpasstxtbox.ForeColor = Color.White;
            }
        }

        private void stpasstxtbox_Leave(object sender, EventArgs e)
        {
            if (stpasstxtbox.Text == "")
            {
                stpasstxtbox.Text = "Student Pass";

                stpasstxtbox.ForeColor = Color.Gainsboro;
            }
        }

        private void stphonetxtbox_Enter(object sender, EventArgs e)
        {
            if (stphonetxtbox.Text == "Student Phone")
            {
                stphonetxtbox.Text = "";

                stphonetxtbox.ForeColor = Color.White;
            }
        }

        private void stphonetxtbox_Leave(object sender, EventArgs e)
        {
            if (stphonetxtbox.Text == "")
            {
                stphonetxtbox.Text = "Student Phone";

                stphonetxtbox.ForeColor = Color.Gainsboro;
            }
        }

        private void stdepttxtbox_Enter(object sender, EventArgs e)
        {
            if (stdepttxtbox.Text == "Department ID")
            {
                stdepttxtbox.Text = "";

                stdepttxtbox.ForeColor = Color.White;
            }
        }

        private void stdepttxtbox_Leave(object sender, EventArgs e)
        {
            if (stdepttxtbox.Text == "")
            {
                stdepttxtbox.Text = "Department ID";

                stdepttxtbox.ForeColor = Color.Gainsboro;
            }
        }

        /*private void stsocialtxtbox_Enter(object sender, EventArgs e)
        {
            if (stsocialtxtbox.Text == "Student Social Link")
            {
                stsocialtxtbox.Text = "";

                stsocialtxtbox.ForeColor = Color.White;
            }

        }*/

        /*private void stsocialtxtbox_Leave(object sender, EventArgs e)
        {
            if(stsocialtxtbox.Text == "")
            {
                stsocialtxtbox.Text = "Student Social Link";

                stsocialtxtbox.ForeColor = Color.Gainsboro;
            }
        }*/

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "select image(*. JpG; *.png; *.Gif)| *. JpG; *.png; *.Gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        #endregion

        #region close, minimize, maximize buttons
        private void Closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizebutton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            WindowsSizeControl.DoMaximize(this, btn);
        }

        private void minimizebutton_Click(object sender, EventArgs e)
        {
            WindowsSizeControl.Minimize(this);
        }
        #endregion

        private void stdepttxtbox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void stphonetxtbox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void stsocialtxtbox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void stidtxtbox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Staff form = new Staff();
            form.Show();
            this.Close();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

            DataTable tabel = new DataTable();
            tabel = AddDeptFormBL.GetDepts();
            //set default value
            DataRow itemrow = tabel.NewRow();
            itemrow[1] = "Select Department";
            tabel.Rows.InsertAt(itemrow, 0);
            cbdepts.DataSource = tabel;
            cbdepts.DisplayMember = "Dept_Name";
            cbdepts.ValueMember = "Dept_ID";
            stdepttxtbox.Hide();



            //AddDeptFormBL.GetDepts();
            dgvstudents.DataSource = AddStudentsFormBL.GetStudentsForStaff(cbdepts.Text);
            stidtxtbox.Hide();
        }

        private void Dgvstudents_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            stidtxtbox.Text = dgvstudents.Rows[e.RowIndex].Cells[0].Value.ToString();
            stfnametxtbox.Text = dgvstudents.Rows[e.RowIndex].Cells[1].Value.ToString();
            stlnametxtbox.Text= dgvstudents.Rows[e.RowIndex].Cells[2].Value.ToString();
            staddtxtbox.Text= dgvstudents.Rows[e.RowIndex].Cells[3].Value.ToString();
            stdobtxtbox.Text= DateTime.Parse(dgvstudents.Rows[e.RowIndex].Cells[4].Value.ToString()).ToShortDateString();
            stpasstxtbox.Text= dgvstudents.Rows[e.RowIndex].Cells[5].Value.ToString();
            stphonetxtbox.Text= dgvstudents.Rows[e.RowIndex].Cells[6].Value.ToString();
            stdepttxtbox.Text= dgvstudents.Rows[e.RowIndex].Cells[7].Value.ToString();

            
            DataSet ds = new DataSet();
            ds = AddStudentsFormBL.GetStudPic(int.Parse(stidtxtbox.Text));
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
                pictureBox2.Image= Image.FromStream(mem);
            }
            
        }

        private void BunifuThinButton24_Click(object sender, EventArgs e)
        {
            stidtxtbox.Text = "";
            stidtxtbox_Leave(this.stidtxtbox, e);
            stfnametxtbox.Text = "";
            stfnametxtbox_Leave(this.stfnametxtbox, e);
            stlnametxtbox.Text = "";
            stlnametxtbox_Leave(this.stlnametxtbox, e);
            staddtxtbox.Text = "";
            staddtxtbox_Leave(this.staddtxtbox,e);
            stdobtxtbox.Text = "";
            stdobtxtbox_Leave(this.stdobtxtbox, e);
            stpasstxtbox.Text = "";
            stpasstxtbox_Leave(this.stpasstxtbox, e);
            stphonetxtbox.Text = "";
            stphonetxtbox_Leave(this.stphonetxtbox, e);
            stdepttxtbox.Text = "";
            stdepttxtbox_Leave(this.stdepttxtbox, e);
            pictureBox2.Image = null;
            AddStudent_Load(this, e);
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            DateTime _date;
            //int _St_Pass;
            if (!DateTime.TryParse(stdobtxtbox.Text, out _date))
            {
                MessageBox.Show("You Must Enter Date", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(pictureBox2.Image == null)
            {
                MessageBox.Show("You Must Enter Studnet Pic", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to Add Student? ", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    int _result;
                    MemoryStream memost = new MemoryStream();
                    pictureBox2.Image.Save(memost, pictureBox2.Image.RawFormat);
                    _result = AddStudentsFormBL.AddNewStudent(stfnametxtbox.Text, stlnametxtbox.Text, staddtxtbox.Text, DateTime.Parse(stdobtxtbox.Text), stpasstxtbox.Text, stphonetxtbox.Text, cbdepts.Text, memost);
                    if (_result > 0)
                    {
                        MessageBox.Show("Student Add Successfully", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BunifuThinButton24_Click(this.bunifuThinButton24, e);
                        AddStudent_Load(this, e);
                    }
                    else
                    {
                        MessageBox.Show("failed To Add Student", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } 
        }

        private void BunifuThinButton23_Click(object sender, EventArgs e)
        {
            DateTime _date;
            if (!DateTime.TryParse(stdobtxtbox.Text, out _date))
            {
                MessageBox.Show("You Must Enter Date");
            }
            else if (pictureBox2.Image == null)
            {
                MessageBox.Show("You Must Enter Studnet Pic", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to Add Student? ", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    int _result;
                    MemoryStream memost = new MemoryStream();
                    pictureBox2.Image.Save(memost, pictureBox2.Image.RawFormat);
                    //cmd1.Parameters.AddWithValue("profileimage", memost.ToArray());
                    _result = AddStudentsFormBL.UpdateStudent(int.Parse(stidtxtbox.Text), stfnametxtbox.Text, stlnametxtbox.Text, staddtxtbox.Text, DateTime.Parse(stdobtxtbox.Text), stpasstxtbox.Text, stphonetxtbox.Text, cbdepts.Text, memost);
                    if (_result > 0)
                    {
                        MessageBox.Show("Student Information Updated Successfully", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BunifuThinButton24_Click(this.bunifuThinButton24, e);
                        AddStudent_Load(this, e);
                    }
                    else
                    {
                        MessageBox.Show("failed To Update Student Informations", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttons1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Staff main = new Staff();
            main.Show();
            this.Close();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G4F0I9B;Initial Catalog=Examination_SystemDB;Integrated Security=True");
            //SqlCommand cmd1 = new SqlCommand("update studentimage set St_ID=@st_id, ST_image=@st_image", conn);
            //cmd1.Parameters.AddWithValue("@ST_ID",textBox1.Text);
            //MemoryStream memost = new MemoryStream();
            //pictureBox2.Image.Save(memost, pictureBox2.Image.RawFormat);
            //cmd1.Parameters.AddWithValue("ST_image", memost.ToArray());
            //conn.Open();
            //cmd1.ExecuteNonQuery();
            //conn.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Cbdepts_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvstudents.DataSource = AddStudentsFormBL.GetStudentsForStaff(cbdepts.Text);
        }
    }
}
