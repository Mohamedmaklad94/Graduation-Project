
namespace ExaminationSystem
{
    partial class AddDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDepartment));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btndeptdesc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btndeptname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btndeptid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgvdepts = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttons2 = new ExaminationSystem.buttons();
            this.buttons7 = new ExaminationSystem.buttons();
            this.btnedit = new ExaminationSystem.buttons();
            this.buttons3 = new ExaminationSystem.buttons();
            this.buttons1 = new ExaminationSystem.buttons();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdepts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttons2);
            this.panel2.Controls.Add(this.buttons7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1117, 38);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(445, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Departments";
            // 
            // btndeptdesc
            // 
            this.btndeptdesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btndeptdesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btndeptdesc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btndeptdesc.ForeColor = System.Drawing.Color.Gainsboro;
            this.btndeptdesc.HintForeColor = System.Drawing.Color.Empty;
            this.btndeptdesc.HintText = "";
            this.btndeptdesc.isPassword = false;
            this.btndeptdesc.LineFocusedColor = System.Drawing.Color.Red;
            this.btndeptdesc.LineIdleColor = System.Drawing.Color.White;
            this.btndeptdesc.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.btndeptdesc.LineThickness = 3;
            this.btndeptdesc.Location = new System.Drawing.Point(34, 192);
            this.btndeptdesc.Margin = new System.Windows.Forms.Padding(4);
            this.btndeptdesc.Name = "btndeptdesc";
            this.btndeptdesc.Size = new System.Drawing.Size(589, 33);
            this.btndeptdesc.TabIndex = 6;
            this.btndeptdesc.Text = "Department Description";
            this.btndeptdesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btndeptdesc.Enter += new System.EventHandler(this.Btndeptdesc_Enter);
            this.btndeptdesc.Leave += new System.EventHandler(this.Btndeptdesc_Leave);
            // 
            // btndeptname
            // 
            this.btndeptname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btndeptname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btndeptname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btndeptname.ForeColor = System.Drawing.Color.Gainsboro;
            this.btndeptname.HintForeColor = System.Drawing.Color.Empty;
            this.btndeptname.HintText = "";
            this.btndeptname.isPassword = false;
            this.btndeptname.LineFocusedColor = System.Drawing.Color.Red;
            this.btndeptname.LineIdleColor = System.Drawing.Color.White;
            this.btndeptname.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.btndeptname.LineThickness = 3;
            this.btndeptname.Location = new System.Drawing.Point(34, 123);
            this.btndeptname.Margin = new System.Windows.Forms.Padding(4);
            this.btndeptname.Name = "btndeptname";
            this.btndeptname.Size = new System.Drawing.Size(589, 33);
            this.btndeptname.TabIndex = 5;
            this.btndeptname.Text = "Department Name";
            this.btndeptname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btndeptname.Enter += new System.EventHandler(this.Btndeptname_Enter);
            this.btndeptname.Leave += new System.EventHandler(this.Btndeptname_Leave);
            // 
            // btndeptid
            // 
            this.btndeptid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btndeptid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btndeptid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btndeptid.ForeColor = System.Drawing.Color.Gainsboro;
            this.btndeptid.HintForeColor = System.Drawing.Color.Empty;
            this.btndeptid.HintText = "";
            this.btndeptid.isPassword = false;
            this.btndeptid.LineFocusedColor = System.Drawing.Color.Red;
            this.btndeptid.LineIdleColor = System.Drawing.Color.White;
            this.btndeptid.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.btndeptid.LineThickness = 3;
            this.btndeptid.Location = new System.Drawing.Point(34, 54);
            this.btndeptid.Margin = new System.Windows.Forms.Padding(4);
            this.btndeptid.Name = "btndeptid";
            this.btndeptid.Size = new System.Drawing.Size(589, 33);
            this.btndeptid.TabIndex = 3;
            this.btndeptid.Text = "Department ID";
            this.btndeptid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btndeptid.Enter += new System.EventHandler(this.Btndeptid_Enter);
            this.btndeptid.Leave += new System.EventHandler(this.Btndeptid_Leave);
            // 
            // dgvdepts
            // 
            this.dgvdepts.BackgroundColor = System.Drawing.Color.White;
            this.dgvdepts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdepts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvdepts.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvdepts.Location = new System.Drawing.Point(0, 276);
            this.dgvdepts.Name = "dgvdepts";
            this.dgvdepts.Size = new System.Drawing.Size(1117, 290);
            this.dgvdepts.TabIndex = 4;
            this.dgvdepts.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgvdepts_RowHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.buttons3);
            this.panel1.Controls.Add(this.buttons1);
            this.panel1.Controls.Add(this.btndeptdesc);
            this.panel1.Controls.Add(this.btndeptname);
            this.panel1.Controls.Add(this.btndeptid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 566);
            this.panel1.TabIndex = 3;
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
            this.buttons2.Location = new System.Drawing.Point(1092, 0);
            this.buttons2.Name = "buttons2";
            this.buttons2.Size = new System.Drawing.Size(25, 26);
            this.buttons2.TabIndex = 15;
            this.buttons2.TextColor = System.Drawing.Color.White;
            this.buttons2.UseVisualStyleBackColor = false;
            this.buttons2.Click += new System.EventHandler(this.buttons2_Click);
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
            this.buttons7.Location = new System.Drawing.Point(1059, 0);
            this.buttons7.Name = "buttons7";
            this.buttons7.Size = new System.Drawing.Size(27, 26);
            this.buttons7.TabIndex = 16;
            this.buttons7.TextColor = System.Drawing.Color.White;
            this.buttons7.UseVisualStyleBackColor = false;
            this.buttons7.Click += new System.EventHandler(this.buttons7_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnedit.backgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnedit.Bordercolor = System.Drawing.Color.PaleVioletRed;
            this.btnedit.Borderradius = 30;
            this.btnedit.Bordersize = 0;
            this.btnedit.FlatAppearance.BorderSize = 0;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.Firebrick;
            this.btnedit.Location = new System.Drawing.Point(830, 227);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(125, 43);
            this.btnedit.TabIndex = 13;
            this.btnedit.Text = "Edit";
            this.btnedit.TextColor = System.Drawing.Color.Firebrick;
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.Btnedit_Click);
            // 
            // buttons3
            // 
            this.buttons3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttons3.backgroundColor = System.Drawing.Color.WhiteSmoke;
            this.buttons3.Bordercolor = System.Drawing.Color.PaleVioletRed;
            this.buttons3.Borderradius = 30;
            this.buttons3.Bordersize = 0;
            this.buttons3.FlatAppearance.BorderSize = 0;
            this.buttons3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttons3.ForeColor = System.Drawing.Color.Firebrick;
            this.buttons3.Location = new System.Drawing.Point(699, 227);
            this.buttons3.Name = "buttons3";
            this.buttons3.Size = new System.Drawing.Size(125, 43);
            this.buttons3.TabIndex = 12;
            this.buttons3.Text = "Add";
            this.buttons3.TextColor = System.Drawing.Color.Firebrick;
            this.buttons3.UseVisualStyleBackColor = false;
            this.buttons3.Click += new System.EventHandler(this.Buttons3_Click);
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
            this.buttons1.Location = new System.Drawing.Point(961, 227);
            this.buttons1.Name = "buttons1";
            this.buttons1.Size = new System.Drawing.Size(125, 43);
            this.buttons1.TabIndex = 11;
            this.buttons1.Text = "Cancel";
            this.buttons1.TextColor = System.Drawing.Color.Firebrick;
            this.buttons1.UseVisualStyleBackColor = false;
            this.buttons1.Click += new System.EventHandler(this.buttons1_Click);
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1117, 566);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvdepts);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddDepartment";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDepartment";
            this.Load += new System.EventHandler(this.AddDepartment_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdepts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private buttons buttons2;
        private buttons buttons7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btndeptdesc;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btndeptname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btndeptid;
        private System.Windows.Forms.DataGridView dgvdepts;
        private System.Windows.Forms.Panel panel1;
        private buttons buttons3;
        private buttons buttons1;
        private buttons btnedit;
    }
}