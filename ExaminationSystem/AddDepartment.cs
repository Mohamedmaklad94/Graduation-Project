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
    public partial class AddDepartment : Form
    {
        public AddDepartment()
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

        private void buttons1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Staff main = new Staff();
            main.Show();
            this.Close();
        }

        private void AddDepartment_Load(object sender, EventArgs e)
        {
            dgvdepts.DataSource = AddDeptFormBL.GetDepts();
            btndeptid.Hide();
        }

        private void Dgvdepts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btndeptid.Text=dgvdepts.Rows[e.RowIndex].Cells[0].Value.ToString();
            btndeptname.Text = dgvdepts.Rows[e.RowIndex].Cells[1].Value.ToString();
            btndeptdesc.Text = dgvdepts.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void Buttons3_Click(object sender, EventArgs e)
        {
            if(btndeptname.Text == "Department Name")
            {
                MessageBox.Show("Please Write Department Name", "Department Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (btndeptdesc.Text== "Department Description")
            {
                MessageBox.Show("Please Write Department Description", "Department Description", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to Add Department? ", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    AddDeptFormBL.AddNewDept(btndeptname.Text, btndeptdesc.Text);
                    AddDepartment_Load(this, e);
                }
            }
            
            
        }
        #region Buttons Colors
        private void Btndeptname_Enter(object sender, EventArgs e)
        {
            if (btndeptname.Text == "Department Name")
            {
                btndeptname.Text = "";

                btndeptname.ForeColor = Color.White;
            }
        }

        private void Btndeptname_Leave(object sender, EventArgs e)
        {
            if (btndeptname.Text == "")
            {
                btndeptname.Text = "Department Name";

                btndeptname.ForeColor = Color.Gainsboro;
            }
        }

        private void Btndeptdesc_Enter(object sender, EventArgs e)
        {
            if (btndeptdesc.Text == "Department Description")
            {
                btndeptdesc.Text = "";

                btndeptdesc.ForeColor = Color.White;
            }
        }

        private void Btndeptdesc_Leave(object sender, EventArgs e)
        {
            if (btndeptdesc.Text == "")
            {
                btndeptdesc.Text = "Department Description";

                btndeptdesc.ForeColor = Color.Gainsboro;
            }
        }

        private void Btndeptid_Enter(object sender, EventArgs e)
        {

            if (btndeptid.Text == "Department ID")
            {
                btndeptid.Text = "";

                btndeptid.ForeColor = Color.White;
            }
        }

        private void Btndeptid_Leave(object sender, EventArgs e)
        {
            if (btndeptid.Text == "")
            {
                btndeptid.Text = "Department ID";

                btndeptid.ForeColor = Color.Gainsboro;
            }
        }


        #endregion

        private void Btnedit_Click(object sender, EventArgs e)
        {
            if (btndeptname.Text == "Department Name")
            {
                MessageBox.Show("Please Write Department Name", "Department Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (btndeptdesc.Text == "Department Description")
            {
                MessageBox.Show("Please Write Department Description", "Department Description", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to Edit Department? ", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    AddDeptFormBL.UpdateDept(int.Parse(btndeptid.Text),btndeptname.Text, btndeptdesc.Text);
                    AddDepartment_Load(this, e);
                }
            }
        }
    }
}
