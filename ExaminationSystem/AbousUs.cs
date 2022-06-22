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
    public partial class AbousUs : Form
    {
        public AbousUs()
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

        private void buttons3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/mahmoud-abdelhakm-437b94229/");
        }

        private void buttons4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/mohamed-maklad-899537230/");
        }

        private void buttons6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/hanan-othman-9466391b0/"); 
        }

        private void buttons5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/abdelmalek-anas/"); 
        }

        private void buttons9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://web.facebook.com/muhammadatef1994"); 
        }

        private void buttons8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://web.facebook.com/mahmoud.abdelhakam.5");
        }

        private void buttons10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://web.facebook.com/abdelmalek.anas.26"); 
        }

        private void buttons11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://web.facebook.com/profile.php?id=100029180856628&_rdc=1&_rdr");
        }

        private void buttons2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttons7_Click(object sender, EventArgs e)
        {
            WindowsSizeControl.Minimize(this);
        }
    }
}
