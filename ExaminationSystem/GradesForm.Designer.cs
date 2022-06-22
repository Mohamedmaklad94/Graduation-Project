namespace ExaminationSystem
{
    partial class GradesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradesForm));
            this.dgvgrades = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelexamdate = new System.Windows.Forms.Label();
            this.crsteacherlabel = new System.Windows.Forms.Label();
            this.examtakendatelabel = new System.Windows.Forms.Label();
            this.labelinstructor = new System.Windows.Forms.Label();
            this.cbcourses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttons3 = new ExaminationSystem.buttons();
            this.buttons2 = new ExaminationSystem.buttons();
            this.buttons7 = new ExaminationSystem.buttons();
            this.lblcrsgrade = new System.Windows.Forms.Label();
            this.lblcrsname = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrades)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvgrades
            // 
            this.dgvgrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvgrades.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvgrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgrades.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvgrades.Location = new System.Drawing.Point(0, 308);
            this.dgvgrades.Name = "dgvgrades";
            this.dgvgrades.Size = new System.Drawing.Size(1046, 255);
            this.dgvgrades.TabIndex = 0;
            this.dgvgrades.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgvgrades_RowHeaderMouseClick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(313, 244);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 17);
            this.linkLabel1.TabIndex = 39;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(34, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "You Can Download Your Full Grades From ";
            // 
            // labelexamdate
            // 
            this.labelexamdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelexamdate.AutoSize = true;
            this.labelexamdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelexamdate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelexamdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelexamdate.Location = new System.Drawing.Point(834, 89);
            this.labelexamdate.Name = "labelexamdate";
            this.labelexamdate.Size = new System.Drawing.Size(0, 24);
            this.labelexamdate.TabIndex = 37;
            this.labelexamdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // crsteacherlabel
            // 
            this.crsteacherlabel.AutoSize = true;
            this.crsteacherlabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crsteacherlabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.crsteacherlabel.Location = new System.Drawing.Point(617, 134);
            this.crsteacherlabel.Name = "crsteacherlabel";
            this.crsteacherlabel.Size = new System.Drawing.Size(186, 24);
            this.crsteacherlabel.TabIndex = 36;
            this.crsteacherlabel.Text = "Course Instructor:";
            // 
            // examtakendatelabel
            // 
            this.examtakendatelabel.AutoSize = true;
            this.examtakendatelabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examtakendatelabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.examtakendatelabel.Location = new System.Drawing.Point(638, 89);
            this.examtakendatelabel.Name = "examtakendatelabel";
            this.examtakendatelabel.Size = new System.Drawing.Size(128, 24);
            this.examtakendatelabel.TabIndex = 34;
            this.examtakendatelabel.Text = "Exam Date:";
            // 
            // labelinstructor
            // 
            this.labelinstructor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelinstructor.AutoSize = true;
            this.labelinstructor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelinstructor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinstructor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelinstructor.Location = new System.Drawing.Point(834, 134);
            this.labelinstructor.Name = "labelinstructor";
            this.labelinstructor.Size = new System.Drawing.Size(0, 24);
            this.labelinstructor.TabIndex = 35;
            this.labelinstructor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbcourses
            // 
            this.cbcourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcourses.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcourses.FormattingEnabled = true;
            this.cbcourses.Location = new System.Drawing.Point(37, 6);
            this.cbcourses.Name = "cbcourses";
            this.cbcourses.Size = new System.Drawing.Size(13, 32);
            this.cbcourses.TabIndex = 12;
            this.cbcourses.SelectedValueChanged += new System.EventHandler(this.Cbcourses_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(420, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Student Grades";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.buttons2);
            this.panel1.Controls.Add(this.buttons7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 41);
            this.panel1.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.lblcrsgrade);
            this.panel2.Controls.Add(this.lblcrsname);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbcourses);
            this.panel2.Controls.Add(this.labelinstructor);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.labelexamdate);
            this.panel2.Controls.Add(this.buttons3);
            this.panel2.Controls.Add(this.examtakendatelabel);
            this.panel2.Controls.Add(this.crsteacherlabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1046, 267);
            this.panel2.TabIndex = 41;
            // 
            // buttons3
            // 
            this.buttons3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttons3.BackColor = System.Drawing.Color.Lavender;
            this.buttons3.backgroundColor = System.Drawing.Color.Lavender;
            this.buttons3.Bordercolor = System.Drawing.Color.PaleVioletRed;
            this.buttons3.Borderradius = 30;
            this.buttons3.Bordersize = 0;
            this.buttons3.FlatAppearance.BorderSize = 0;
            this.buttons3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttons3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttons3.Location = new System.Drawing.Point(909, 224);
            this.buttons3.Name = "buttons3";
            this.buttons3.Size = new System.Drawing.Size(125, 37);
            this.buttons3.TabIndex = 38;
            this.buttons3.Text = "Back";
            this.buttons3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttons3.UseVisualStyleBackColor = false;
            this.buttons3.Click += new System.EventHandler(this.buttons3_Click);
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
            this.buttons2.Location = new System.Drawing.Point(1022, 0);
            this.buttons2.Name = "buttons2";
            this.buttons2.Size = new System.Drawing.Size(25, 26);
            this.buttons2.TabIndex = 6;
            this.buttons2.TextColor = System.Drawing.Color.White;
            this.buttons2.UseVisualStyleBackColor = false;
            this.buttons2.Click += new System.EventHandler(this.buttons2_Click_1);
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
            this.buttons7.Location = new System.Drawing.Point(989, 0);
            this.buttons7.Name = "buttons7";
            this.buttons7.Size = new System.Drawing.Size(27, 26);
            this.buttons7.TabIndex = 7;
            this.buttons7.TextColor = System.Drawing.Color.White;
            this.buttons7.UseVisualStyleBackColor = false;
            this.buttons7.Click += new System.EventHandler(this.buttons7_Click_1);
            // 
            // lblcrsgrade
            // 
            this.lblcrsgrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcrsgrade.AutoSize = true;
            this.lblcrsgrade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblcrsgrade.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcrsgrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblcrsgrade.Location = new System.Drawing.Point(326, 134);
            this.lblcrsgrade.Name = "lblcrsgrade";
            this.lblcrsgrade.Size = new System.Drawing.Size(0, 24);
            this.lblcrsgrade.TabIndex = 41;
            this.lblcrsgrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblcrsname
            // 
            this.lblcrsname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcrsname.AutoSize = true;
            this.lblcrsname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblcrsname.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcrsname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblcrsname.Location = new System.Drawing.Point(326, 89);
            this.lblcrsname.Name = "lblcrsname";
            this.lblcrsname.Size = new System.Drawing.Size(0, 24);
            this.lblcrsname.TabIndex = 43;
            this.lblcrsname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(130, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 24);
            this.label6.TabIndex = 40;
            this.label6.Text = "Course Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(130, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 24);
            this.label7.TabIndex = 42;
            this.label7.Text = "Course Grade:";
            // 
            // GradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1046, 563);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvgrades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GradesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GradesForm";
            this.Load += new System.EventHandler(this.GradesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrades)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvgrades;
        private System.Windows.Forms.ComboBox cbcourses;
        private System.Windows.Forms.Label labelexamdate;
        private System.Windows.Forms.Label crsteacherlabel;
        private System.Windows.Forms.Label examtakendatelabel;
        private System.Windows.Forms.Label labelinstructor;
        private buttons buttons3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private buttons buttons7;
        private buttons buttons2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblcrsgrade;
        private System.Windows.Forms.Label lblcrsname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}