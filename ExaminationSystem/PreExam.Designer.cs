
namespace ExaminationSystem
{
    partial class Exam
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exam));
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttons7 = new ExaminationSystem.buttons();
            this.buttons2 = new ExaminationSystem.buttons();
            this.label5 = new System.Windows.Forms.Label();
            this.panelleftside = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbcourses = new System.Windows.Forms.ComboBox();
            this.btnstartexam = new ExaminationSystem.buttons();
            this.buttons1 = new ExaminationSystem.buttons();
            this.panel3.SuspendLayout();
            this.panelleftside.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.buttons7);
            this.panel3.Controls.Add(this.buttons2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(953, 37);
            this.panel3.TabIndex = 3;
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
            this.buttons7.Location = new System.Drawing.Point(892, 0);
            this.buttons7.Name = "buttons7";
            this.buttons7.Size = new System.Drawing.Size(27, 26);
            this.buttons7.TabIndex = 4;
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
            this.buttons2.Location = new System.Drawing.Point(925, 0);
            this.buttons2.Name = "buttons2";
            this.buttons2.Size = new System.Drawing.Size(25, 26);
            this.buttons2.TabIndex = 3;
            this.buttons2.TextColor = System.Drawing.Color.White;
            this.buttons2.UseVisualStyleBackColor = false;
            this.buttons2.Click += new System.EventHandler(this.buttons2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panelleftside
            // 
            this.panelleftside.BackColor = System.Drawing.Color.Firebrick;
            this.panelleftside.Controls.Add(this.richTextBox1);
            this.panelleftside.Controls.Add(this.panel1);
            this.panelleftside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleftside.Location = new System.Drawing.Point(0, 37);
            this.panelleftside.Name = "panelleftside";
            this.panelleftside.Size = new System.Drawing.Size(260, 441);
            this.panelleftside.TabIndex = 4;
            this.panelleftside.Paint += new System.Windows.Forms.PaintEventHandler(this.panelleftside_Paint);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Firebrick;
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.Location = new System.Drawing.Point(3, 78);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(256, 368);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 80);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Please Note ...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Before Exam ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 478);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(953, 37);
            this.panel4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(726, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // cbcourses
            // 
            this.cbcourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcourses.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcourses.FormattingEnabled = true;
            this.cbcourses.Location = new System.Drawing.Point(315, 103);
            this.cbcourses.Name = "cbcourses";
            this.cbcourses.Size = new System.Drawing.Size(396, 32);
            this.cbcourses.TabIndex = 6;
            this.cbcourses.SelectedIndexChanged += new System.EventHandler(this.cbcourses_SelectedIndexChanged);
            // 
            // btnstartexam
            // 
            this.btnstartexam.BackColor = System.Drawing.Color.Firebrick;
            this.btnstartexam.backgroundColor = System.Drawing.Color.Firebrick;
            this.btnstartexam.Bordercolor = System.Drawing.Color.PaleVioletRed;
            this.btnstartexam.Borderradius = 30;
            this.btnstartexam.Bordersize = 0;
            this.btnstartexam.FlatAppearance.BorderSize = 0;
            this.btnstartexam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstartexam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstartexam.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnstartexam.Location = new System.Drawing.Point(671, 429);
            this.btnstartexam.Name = "btnstartexam";
            this.btnstartexam.Size = new System.Drawing.Size(125, 43);
            this.btnstartexam.TabIndex = 9;
            this.btnstartexam.Text = "Start Exam";
            this.btnstartexam.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnstartexam.UseVisualStyleBackColor = false;
            this.btnstartexam.Click += new System.EventHandler(this.buttons4_Click);
            // 
            // buttons1
            // 
            this.buttons1.BackColor = System.Drawing.Color.Firebrick;
            this.buttons1.backgroundColor = System.Drawing.Color.Firebrick;
            this.buttons1.Bordercolor = System.Drawing.Color.PaleVioletRed;
            this.buttons1.Borderradius = 30;
            this.buttons1.Bordersize = 0;
            this.buttons1.FlatAppearance.BorderSize = 0;
            this.buttons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttons1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttons1.Location = new System.Drawing.Point(816, 429);
            this.buttons1.Name = "buttons1";
            this.buttons1.Size = new System.Drawing.Size(125, 43);
            this.buttons1.TabIndex = 10;
            this.buttons1.Text = "Cancel";
            this.buttons1.TextColor = System.Drawing.Color.WhiteSmoke;
            this.buttons1.UseVisualStyleBackColor = false;
            this.buttons1.Click += new System.EventHandler(this.buttons1_Click);
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 515);
            this.Controls.Add(this.buttons1);
            this.Controls.Add(this.btnstartexam);
            this.Controls.Add(this.panelleftside);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.cbcourses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Exam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam";
            this.Load += new System.EventHandler(this.Exam_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelleftside.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private buttons buttons7;
        private buttons buttons2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelleftside;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbcourses;
        private System.Windows.Forms.Label label4;
        private buttons btnstartexam;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private buttons buttons1;
    }
}