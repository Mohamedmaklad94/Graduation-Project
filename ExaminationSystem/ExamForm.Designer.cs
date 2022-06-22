namespace ExaminationSystem
{
    partial class ExamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamForm));
            this.lblquestion = new System.Windows.Forms.Label();
            this.rbchoice1 = new System.Windows.Forms.RadioButton();
            this.rbchoice2 = new System.Windows.Forms.RadioButton();
            this.rbchoice3 = new System.Windows.Forms.RadioButton();
            this.rbchoice4 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttons7 = new ExaminationSystem.buttons();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.counttimelabel = new System.Windows.Forms.Label();
            this.buttons2 = new ExaminationSystem.buttons();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttons1 = new ExaminationSystem.buttons();
            this.buttons3 = new ExaminationSystem.buttons();
            this.buttons4 = new ExaminationSystem.buttons();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblquestion
            // 
            this.lblquestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblquestion.AutoSize = true;
            this.lblquestion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquestion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblquestion.Location = new System.Drawing.Point(12, 92);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(154, 24);
            this.lblquestion.TabIndex = 0;
            this.lblquestion.Text = "Question Here";
            // 
            // rbchoice1
            // 
            this.rbchoice1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbchoice1.AutoSize = true;
            this.rbchoice1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbchoice1.ForeColor = System.Drawing.Color.Firebrick;
            this.rbchoice1.Location = new System.Drawing.Point(67, 302);
            this.rbchoice1.Name = "rbchoice1";
            this.rbchoice1.Size = new System.Drawing.Size(132, 28);
            this.rbchoice1.TabIndex = 2;
            this.rbchoice1.TabStop = true;
            this.rbchoice1.Text = "rbchoice1";
            this.rbchoice1.UseVisualStyleBackColor = true;
            // 
            // rbchoice2
            // 
            this.rbchoice2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbchoice2.AutoSize = true;
            this.rbchoice2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbchoice2.ForeColor = System.Drawing.Color.Firebrick;
            this.rbchoice2.Location = new System.Drawing.Point(67, 356);
            this.rbchoice2.Name = "rbchoice2";
            this.rbchoice2.Size = new System.Drawing.Size(132, 28);
            this.rbchoice2.TabIndex = 3;
            this.rbchoice2.TabStop = true;
            this.rbchoice2.Text = "rbchoice2";
            this.rbchoice2.UseVisualStyleBackColor = true;
            // 
            // rbchoice3
            // 
            this.rbchoice3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbchoice3.AutoSize = true;
            this.rbchoice3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbchoice3.ForeColor = System.Drawing.Color.Firebrick;
            this.rbchoice3.Location = new System.Drawing.Point(67, 410);
            this.rbchoice3.Name = "rbchoice3";
            this.rbchoice3.Size = new System.Drawing.Size(132, 28);
            this.rbchoice3.TabIndex = 4;
            this.rbchoice3.TabStop = true;
            this.rbchoice3.Text = "rbchoice3";
            this.rbchoice3.UseVisualStyleBackColor = true;
            // 
            // rbchoice4
            // 
            this.rbchoice4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbchoice4.AutoSize = true;
            this.rbchoice4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbchoice4.ForeColor = System.Drawing.Color.Firebrick;
            this.rbchoice4.Location = new System.Drawing.Point(67, 464);
            this.rbchoice4.Name = "rbchoice4";
            this.rbchoice4.Size = new System.Drawing.Size(132, 28);
            this.rbchoice4.TabIndex = 5;
            this.rbchoice4.TabStop = true;
            this.rbchoice4.Text = "rbchoice4";
            this.rbchoice4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.buttons7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.counttimelabel);
            this.panel1.Controls.Add(this.buttons2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 59);
            this.panel1.TabIndex = 6;
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
            this.buttons7.Location = new System.Drawing.Point(1214, 0);
            this.buttons7.Name = "buttons7";
            this.buttons7.Size = new System.Drawing.Size(27, 26);
            this.buttons7.TabIndex = 11;
            this.buttons7.TextColor = System.Drawing.Color.White;
            this.buttons7.UseVisualStyleBackColor = false;
            this.buttons7.Click += new System.EventHandler(this.buttons7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // counttimelabel
            // 
            this.counttimelabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.counttimelabel.AutoSize = true;
            this.counttimelabel.BackColor = System.Drawing.Color.Firebrick;
            this.counttimelabel.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counttimelabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.counttimelabel.Location = new System.Drawing.Point(561, 9);
            this.counttimelabel.Name = "counttimelabel";
            this.counttimelabel.Size = new System.Drawing.Size(0, 42);
            this.counttimelabel.TabIndex = 2;
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
            this.buttons2.Location = new System.Drawing.Point(1247, 0);
            this.buttons2.Name = "buttons2";
            this.buttons2.Size = new System.Drawing.Size(25, 26);
            this.buttons2.TabIndex = 10;
            this.buttons2.TextColor = System.Drawing.Color.White;
            this.buttons2.UseVisualStyleBackColor = false;
            this.buttons2.Click += new System.EventHandler(this.buttons2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.lblquestion);
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1272, 219);
            this.panel2.TabIndex = 7;
            // 
            // buttons1
            // 
            this.buttons1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttons1.BackColor = System.Drawing.Color.Firebrick;
            this.buttons1.backgroundColor = System.Drawing.Color.Firebrick;
            this.buttons1.Bordercolor = System.Drawing.Color.White;
            this.buttons1.Borderradius = 40;
            this.buttons1.Bordersize = 0;
            this.buttons1.FlatAppearance.BorderSize = 0;
            this.buttons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttons1.Image = ((System.Drawing.Image)(resources.GetObject("buttons1.Image")));
            this.buttons1.Location = new System.Drawing.Point(967, 556);
            this.buttons1.Name = "buttons1";
            this.buttons1.Size = new System.Drawing.Size(113, 41);
            this.buttons1.TabIndex = 1;
            this.buttons1.TextColor = System.Drawing.Color.WhiteSmoke;
            this.buttons1.UseVisualStyleBackColor = false;
            this.buttons1.Click += new System.EventHandler(this.buttons1_Click);
            // 
            // buttons3
            // 
            this.buttons3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttons3.BackColor = System.Drawing.Color.Firebrick;
            this.buttons3.backgroundColor = System.Drawing.Color.Firebrick;
            this.buttons3.Bordercolor = System.Drawing.Color.White;
            this.buttons3.Borderradius = 40;
            this.buttons3.Bordersize = 0;
            this.buttons3.FlatAppearance.BorderSize = 0;
            this.buttons3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttons3.Image = ((System.Drawing.Image)(resources.GetObject("buttons3.Image")));
            this.buttons3.Location = new System.Drawing.Point(811, 556);
            this.buttons3.Name = "buttons3";
            this.buttons3.Size = new System.Drawing.Size(113, 41);
            this.buttons3.TabIndex = 10;
            this.buttons3.TextColor = System.Drawing.Color.WhiteSmoke;
            this.buttons3.UseVisualStyleBackColor = false;
            this.buttons3.Click += new System.EventHandler(this.buttons3_Click);
            // 
            // buttons4
            // 
            this.buttons4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttons4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttons4.backgroundColor = System.Drawing.Color.WhiteSmoke;
            this.buttons4.Bordercolor = System.Drawing.Color.Firebrick;
            this.buttons4.Borderradius = 40;
            this.buttons4.Bordersize = 1;
            this.buttons4.FlatAppearance.BorderSize = 0;
            this.buttons4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttons4.ForeColor = System.Drawing.Color.Firebrick;
            this.buttons4.Location = new System.Drawing.Point(1131, 556);
            this.buttons4.Name = "buttons4";
            this.buttons4.Size = new System.Drawing.Size(129, 41);
            this.buttons4.TabIndex = 11;
            this.buttons4.Text = "Submit Exam";
            this.buttons4.TextColor = System.Drawing.Color.Firebrick;
            this.buttons4.UseVisualStyleBackColor = false;
            this.buttons4.Click += new System.EventHandler(this.buttons4_Click);
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1272, 611);
            this.Controls.Add(this.buttons4);
            this.Controls.Add(this.buttons3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rbchoice4);
            this.Controls.Add(this.rbchoice3);
            this.Controls.Add(this.rbchoice2);
            this.Controls.Add(this.rbchoice1);
            this.Controls.Add(this.buttons1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExamForm";
            this.Load += new System.EventHandler(this.ExamForm_Load);
            this.Leave += new System.EventHandler(this.ExamForm_Leave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblquestion;
        private System.Windows.Forms.RadioButton rbchoice1;
        private System.Windows.Forms.RadioButton rbchoice2;
        private System.Windows.Forms.RadioButton rbchoice3;
        private System.Windows.Forms.RadioButton rbchoice4;
        private System.Windows.Forms.Panel panel1;
        private buttons buttons1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label counttimelabel;
        private System.Windows.Forms.Timer timer1;
        private buttons buttons7;
        private buttons buttons2;
        private System.Windows.Forms.Panel panel2;
        private buttons buttons3;
        private buttons buttons4;
    }
}