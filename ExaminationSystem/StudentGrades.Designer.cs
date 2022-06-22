
namespace ExaminationSystem
{
    partial class StudentGrades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentGrades));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvgrades = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbcourses = new System.Windows.Forms.ComboBox();
            this.buttons1 = new ExaminationSystem.buttons();
            this.buttons7 = new ExaminationSystem.buttons();
            this.buttons2 = new ExaminationSystem.buttons();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrades)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttons7);
            this.panel1.Controls.Add(this.buttons2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 38);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(370, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Students Grade";
            // 
            // dgvgrades
            // 
            this.dgvgrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvgrades.BackgroundColor = System.Drawing.Color.White;
            this.dgvgrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgrades.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvgrades.Location = new System.Drawing.Point(0, 300);
            this.dgvgrades.Name = "dgvgrades";
            this.dgvgrades.Size = new System.Drawing.Size(992, 270);
            this.dgvgrades.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.buttons1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbcourses);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 262);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select a Course to View Student Grades:";
            // 
            // cbcourses
            // 
            this.cbcourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcourses.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcourses.FormattingEnabled = true;
            this.cbcourses.Location = new System.Drawing.Point(499, 47);
            this.cbcourses.Name = "cbcourses";
            this.cbcourses.Size = new System.Drawing.Size(396, 30);
            this.cbcourses.TabIndex = 7;
            this.cbcourses.SelectedValueChanged += new System.EventHandler(this.Cbcourses_SelectedValueChanged);
            // 
            // buttons1
            // 
            this.buttons1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttons1.backgroundColor = System.Drawing.Color.WhiteSmoke;
            this.buttons1.Bordercolor = System.Drawing.Color.PaleVioletRed;
            this.buttons1.Borderradius = 30;
            this.buttons1.Bordersize = 0;
            this.buttons1.FlatAppearance.BorderSize = 0;
            this.buttons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttons1.ForeColor = System.Drawing.Color.Firebrick;
            this.buttons1.Location = new System.Drawing.Point(845, 213);
            this.buttons1.Name = "buttons1";
            this.buttons1.Size = new System.Drawing.Size(125, 43);
            this.buttons1.TabIndex = 11;
            this.buttons1.Text = "Back";
            this.buttons1.TextColor = System.Drawing.Color.Firebrick;
            this.buttons1.UseVisualStyleBackColor = false;
            this.buttons1.Click += new System.EventHandler(this.buttons1_Click);
            // 
            // buttons7
            // 
            this.buttons7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttons7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttons7.backgroundColor = System.Drawing.Color.WhiteSmoke;
            this.buttons7.Bordercolor = System.Drawing.Color.PaleVioletRed;
            this.buttons7.Borderradius = 0;
            this.buttons7.Bordersize = 0;
            this.buttons7.FlatAppearance.BorderSize = 0;
            this.buttons7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons7.ForeColor = System.Drawing.Color.White;
            this.buttons7.Image = ((System.Drawing.Image)(resources.GetObject("buttons7.Image")));
            this.buttons7.Location = new System.Drawing.Point(931, 0);
            this.buttons7.Name = "buttons7";
            this.buttons7.Size = new System.Drawing.Size(27, 26);
            this.buttons7.TabIndex = 6;
            this.buttons7.TextColor = System.Drawing.Color.White;
            this.buttons7.UseVisualStyleBackColor = false;
            this.buttons7.Click += new System.EventHandler(this.buttons7_Click);
            // 
            // buttons2
            // 
            this.buttons2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttons2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttons2.backgroundColor = System.Drawing.Color.WhiteSmoke;
            this.buttons2.Bordercolor = System.Drawing.Color.PaleVioletRed;
            this.buttons2.Borderradius = 0;
            this.buttons2.Bordersize = 0;
            this.buttons2.FlatAppearance.BorderSize = 0;
            this.buttons2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons2.ForeColor = System.Drawing.Color.White;
            this.buttons2.Image = ((System.Drawing.Image)(resources.GetObject("buttons2.Image")));
            this.buttons2.Location = new System.Drawing.Point(964, 0);
            this.buttons2.Name = "buttons2";
            this.buttons2.Size = new System.Drawing.Size(25, 26);
            this.buttons2.TabIndex = 5;
            this.buttons2.TextColor = System.Drawing.Color.White;
            this.buttons2.UseVisualStyleBackColor = false;
            this.buttons2.Click += new System.EventHandler(this.buttons2_Click);
            // 
            // StudentGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvgrades);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentGrades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentGrades";
            this.Load += new System.EventHandler(this.StudentGrades_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrades)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private buttons buttons7;
        private buttons buttons2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvgrades;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbcourses;
        private buttons buttons1;
    }
}