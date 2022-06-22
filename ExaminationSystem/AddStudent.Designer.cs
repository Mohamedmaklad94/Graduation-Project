using Bunifu.Framework;

namespace ExaminationSystem
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbdepts = new System.Windows.Forms.ComboBox();
            this.buttons1 = new ExaminationSystem.buttons();
            this.Closebutton = new System.Windows.Forms.Button();
            this.minimizebutton = new System.Windows.Forms.Button();
            this.Maximizebutton = new System.Windows.Forms.Button();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.stdepttxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.stphonetxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.stpasstxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.stdobtxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.staddtxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.stlnametxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.stfnametxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.stidtxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvstudents = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudents)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.cbdepts);
            this.panel2.Controls.Add(this.buttons1);
            this.panel2.Controls.Add(this.Closebutton);
            this.panel2.Controls.Add(this.minimizebutton);
            this.panel2.Controls.Add(this.Maximizebutton);
            this.panel2.Controls.Add(this.bunifuThinButton24);
            this.panel2.Controls.Add(this.bunifuThinButton23);
            this.panel2.Controls.Add(this.bunifuThinButton22);
            this.panel2.Controls.Add(this.stdepttxtbox);
            this.panel2.Controls.Add(this.stphonetxtbox);
            this.panel2.Controls.Add(this.stpasstxtbox);
            this.panel2.Controls.Add(this.stdobtxtbox);
            this.panel2.Controls.Add(this.staddtxtbox);
            this.panel2.Controls.Add(this.stlnametxtbox);
            this.panel2.Controls.Add(this.stfnametxtbox);
            this.panel2.Controls.Add(this.stidtxtbox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bunifuThinButton21);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1106, 233);
            this.panel2.TabIndex = 40;
            // 
            // cbdepts
            // 
            this.cbdepts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdepts.FormattingEnabled = true;
            this.cbdepts.Location = new System.Drawing.Point(720, 114);
            this.cbdepts.Name = "cbdepts";
            this.cbdepts.Size = new System.Drawing.Size(193, 28);
            this.cbdepts.TabIndex = 46;
            this.cbdepts.SelectedValueChanged += new System.EventHandler(this.Cbdepts_SelectedValueChanged);
            // 
            // buttons1
            // 
            this.buttons1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttons1.backgroundColor = System.Drawing.Color.WhiteSmoke;
            this.buttons1.Bordercolor = System.Drawing.Color.PaleVioletRed;
            this.buttons1.Borderradius = 40;
            this.buttons1.Bordersize = 0;
            this.buttons1.FlatAppearance.BorderSize = 0;
            this.buttons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttons1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttons1.ForeColor = System.Drawing.Color.Firebrick;
            this.buttons1.Location = new System.Drawing.Point(774, 185);
            this.buttons1.Name = "buttons1";
            this.buttons1.Size = new System.Drawing.Size(150, 40);
            this.buttons1.TabIndex = 45;
            this.buttons1.Text = "Back";
            this.buttons1.TextColor = System.Drawing.Color.Firebrick;
            this.buttons1.UseVisualStyleBackColor = false;
            this.buttons1.Click += new System.EventHandler(this.buttons1_Click);
            // 
            // Closebutton
            // 
            this.Closebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Closebutton.Image = ((System.Drawing.Image)(resources.GetObject("Closebutton.Image")));
            this.Closebutton.Location = new System.Drawing.Point(1076, 0);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(30, 32);
            this.Closebutton.TabIndex = 44;
            this.Closebutton.UseVisualStyleBackColor = true;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // minimizebutton
            // 
            this.minimizebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizebutton.Image = ((System.Drawing.Image)(resources.GetObject("minimizebutton.Image")));
            this.minimizebutton.Location = new System.Drawing.Point(1004, 0);
            this.minimizebutton.Name = "minimizebutton";
            this.minimizebutton.Size = new System.Drawing.Size(30, 32);
            this.minimizebutton.TabIndex = 43;
            this.minimizebutton.UseVisualStyleBackColor = true;
            this.minimizebutton.Click += new System.EventHandler(this.minimizebutton_Click);
            // 
            // Maximizebutton
            // 
            this.Maximizebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximizebutton.Image = ((System.Drawing.Image)(resources.GetObject("Maximizebutton.Image")));
            this.Maximizebutton.Location = new System.Drawing.Point(1040, 0);
            this.Maximizebutton.Name = "Maximizebutton";
            this.Maximizebutton.Size = new System.Drawing.Size(30, 32);
            this.Maximizebutton.TabIndex = 42;
            this.Maximizebutton.UseVisualStyleBackColor = true;
            this.Maximizebutton.Click += new System.EventHandler(this.Maximizebutton_Click);
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.Red;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuThinButton24.BackColor = System.Drawing.Color.Firebrick;
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "Reset";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.Firebrick;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton24.Location = new System.Drawing.Point(616, 189);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(125, 39);
            this.bunifuThinButton24.TabIndex = 14;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.BunifuThinButton24_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.Red;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuThinButton23.BackColor = System.Drawing.Color.Firebrick;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Edit";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.Firebrick;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton23.Location = new System.Drawing.Point(451, 189);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(125, 39);
            this.bunifuThinButton23.TabIndex = 13;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.BunifuThinButton23_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Red;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuThinButton22.BackColor = System.Drawing.Color.Firebrick;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "New Student";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Firebrick;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton22.Location = new System.Drawing.Point(264, 189);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(125, 39);
            this.bunifuThinButton22.TabIndex = 12;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.BunifuThinButton22_Click);
            // 
            // stdepttxtbox
            // 
            this.stdepttxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stdepttxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stdepttxtbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdepttxtbox.ForeColor = System.Drawing.Color.Gainsboro;
            this.stdepttxtbox.HintForeColor = System.Drawing.Color.Empty;
            this.stdepttxtbox.HintText = "";
            this.stdepttxtbox.isPassword = false;
            this.stdepttxtbox.LineFocusedColor = System.Drawing.Color.White;
            this.stdepttxtbox.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.stdepttxtbox.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.stdepttxtbox.LineThickness = 4;
            this.stdepttxtbox.Location = new System.Drawing.Point(887, 113);
            this.stdepttxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.stdepttxtbox.Name = "stdepttxtbox";
            this.stdepttxtbox.Size = new System.Drawing.Size(193, 29);
            this.stdepttxtbox.TabIndex = 10;
            this.stdepttxtbox.Text = "Department ID";
            this.stdepttxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stdepttxtbox.OnValueChanged += new System.EventHandler(this.stdepttxtbox_OnValueChanged);
            this.stdepttxtbox.Enter += new System.EventHandler(this.stdepttxtbox_Enter);
            this.stdepttxtbox.Leave += new System.EventHandler(this.stdepttxtbox_Leave);
            // 
            // stphonetxtbox
            // 
            this.stphonetxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stphonetxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stphonetxtbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stphonetxtbox.ForeColor = System.Drawing.Color.Gainsboro;
            this.stphonetxtbox.HintForeColor = System.Drawing.Color.Empty;
            this.stphonetxtbox.HintText = "";
            this.stphonetxtbox.isPassword = false;
            this.stphonetxtbox.LineFocusedColor = System.Drawing.Color.White;
            this.stphonetxtbox.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.stphonetxtbox.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.stphonetxtbox.LineThickness = 4;
            this.stphonetxtbox.Location = new System.Drawing.Point(720, 50);
            this.stphonetxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.stphonetxtbox.Name = "stphonetxtbox";
            this.stphonetxtbox.Size = new System.Drawing.Size(193, 29);
            this.stphonetxtbox.TabIndex = 9;
            this.stphonetxtbox.Text = "Student Phone";
            this.stphonetxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stphonetxtbox.OnValueChanged += new System.EventHandler(this.stphonetxtbox_OnValueChanged);
            this.stphonetxtbox.Enter += new System.EventHandler(this.stphonetxtbox_Enter);
            this.stphonetxtbox.Leave += new System.EventHandler(this.stphonetxtbox_Leave);
            // 
            // stpasstxtbox
            // 
            this.stpasstxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stpasstxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stpasstxtbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stpasstxtbox.ForeColor = System.Drawing.Color.Gainsboro;
            this.stpasstxtbox.HintForeColor = System.Drawing.Color.Empty;
            this.stpasstxtbox.HintText = "";
            this.stpasstxtbox.isPassword = false;
            this.stpasstxtbox.LineFocusedColor = System.Drawing.Color.White;
            this.stpasstxtbox.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.stpasstxtbox.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.stpasstxtbox.LineThickness = 4;
            this.stpasstxtbox.Location = new System.Drawing.Point(462, 152);
            this.stpasstxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.stpasstxtbox.Name = "stpasstxtbox";
            this.stpasstxtbox.Size = new System.Drawing.Size(193, 29);
            this.stpasstxtbox.TabIndex = 8;
            this.stpasstxtbox.Text = "Student Pass";
            this.stpasstxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stpasstxtbox.Enter += new System.EventHandler(this.stpasstxtbox_Enter);
            this.stpasstxtbox.Leave += new System.EventHandler(this.stpasstxtbox_Leave);
            // 
            // stdobtxtbox
            // 
            this.stdobtxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stdobtxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stdobtxtbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdobtxtbox.ForeColor = System.Drawing.Color.Gainsboro;
            this.stdobtxtbox.HintForeColor = System.Drawing.Color.Empty;
            this.stdobtxtbox.HintText = "";
            this.stdobtxtbox.isPassword = false;
            this.stdobtxtbox.LineFocusedColor = System.Drawing.Color.White;
            this.stdobtxtbox.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.stdobtxtbox.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.stdobtxtbox.LineThickness = 4;
            this.stdobtxtbox.Location = new System.Drawing.Point(462, 99);
            this.stdobtxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.stdobtxtbox.Name = "stdobtxtbox";
            this.stdobtxtbox.Size = new System.Drawing.Size(193, 29);
            this.stdobtxtbox.TabIndex = 7;
            this.stdobtxtbox.Text = "Student Birth Date";
            this.stdobtxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stdobtxtbox.Enter += new System.EventHandler(this.stdobtxtbox_Enter);
            this.stdobtxtbox.Leave += new System.EventHandler(this.stdobtxtbox_Leave);
            // 
            // staddtxtbox
            // 
            this.staddtxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.staddtxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.staddtxtbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staddtxtbox.ForeColor = System.Drawing.Color.Gainsboro;
            this.staddtxtbox.HintForeColor = System.Drawing.Color.Empty;
            this.staddtxtbox.HintText = "";
            this.staddtxtbox.isPassword = false;
            this.staddtxtbox.LineFocusedColor = System.Drawing.Color.White;
            this.staddtxtbox.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.staddtxtbox.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.staddtxtbox.LineThickness = 4;
            this.staddtxtbox.Location = new System.Drawing.Point(462, 50);
            this.staddtxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.staddtxtbox.Name = "staddtxtbox";
            this.staddtxtbox.Size = new System.Drawing.Size(193, 29);
            this.staddtxtbox.TabIndex = 6;
            this.staddtxtbox.Text = "Student Address";
            this.staddtxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.staddtxtbox.Enter += new System.EventHandler(this.staddtxtbox_Enter);
            this.staddtxtbox.Leave += new System.EventHandler(this.staddtxtbox_Leave);
            // 
            // stlnametxtbox
            // 
            this.stlnametxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stlnametxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stlnametxtbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stlnametxtbox.ForeColor = System.Drawing.Color.Gainsboro;
            this.stlnametxtbox.HintForeColor = System.Drawing.Color.Empty;
            this.stlnametxtbox.HintText = "";
            this.stlnametxtbox.isPassword = false;
            this.stlnametxtbox.LineFocusedColor = System.Drawing.Color.White;
            this.stlnametxtbox.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.stlnametxtbox.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.stlnametxtbox.LineThickness = 4;
            this.stlnametxtbox.Location = new System.Drawing.Point(196, 152);
            this.stlnametxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.stlnametxtbox.Name = "stlnametxtbox";
            this.stlnametxtbox.Size = new System.Drawing.Size(193, 29);
            this.stlnametxtbox.TabIndex = 5;
            this.stlnametxtbox.Text = "Student Last Name";
            this.stlnametxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stlnametxtbox.Enter += new System.EventHandler(this.stlnametxtbox_Enter);
            this.stlnametxtbox.Leave += new System.EventHandler(this.stlnametxtbox_Leave);
            // 
            // stfnametxtbox
            // 
            this.stfnametxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stfnametxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stfnametxtbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stfnametxtbox.ForeColor = System.Drawing.Color.Gainsboro;
            this.stfnametxtbox.HintForeColor = System.Drawing.Color.Empty;
            this.stfnametxtbox.HintText = "";
            this.stfnametxtbox.isPassword = false;
            this.stfnametxtbox.LineFocusedColor = System.Drawing.Color.White;
            this.stfnametxtbox.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.stfnametxtbox.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.stfnametxtbox.LineThickness = 4;
            this.stfnametxtbox.Location = new System.Drawing.Point(196, 99);
            this.stfnametxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.stfnametxtbox.Name = "stfnametxtbox";
            this.stfnametxtbox.Size = new System.Drawing.Size(193, 29);
            this.stfnametxtbox.TabIndex = 4;
            this.stfnametxtbox.Text = "Student First Name";
            this.stfnametxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stfnametxtbox.OnValueChanged += new System.EventHandler(this.stfnametxtbox_OnValueChanged);
            this.stfnametxtbox.Enter += new System.EventHandler(this.stfnametxtbox_Enter);
            this.stfnametxtbox.Leave += new System.EventHandler(this.stfnametxtbox_Leave);
            // 
            // stidtxtbox
            // 
            this.stidtxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stidtxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stidtxtbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stidtxtbox.ForeColor = System.Drawing.Color.Gainsboro;
            this.stidtxtbox.HintForeColor = System.Drawing.Color.Empty;
            this.stidtxtbox.HintText = "";
            this.stidtxtbox.isPassword = false;
            this.stidtxtbox.LineFocusedColor = System.Drawing.Color.White;
            this.stidtxtbox.LineIdleColor = System.Drawing.Color.Gainsboro;
            this.stidtxtbox.LineMouseHoverColor = System.Drawing.Color.DarkRed;
            this.stidtxtbox.LineThickness = 4;
            this.stidtxtbox.Location = new System.Drawing.Point(196, 50);
            this.stidtxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.stidtxtbox.Name = "stidtxtbox";
            this.stidtxtbox.Size = new System.Drawing.Size(193, 29);
            this.stidtxtbox.TabIndex = 3;
            this.stidtxtbox.Text = "Student ID";
            this.stidtxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stidtxtbox.OnValueChanged += new System.EventHandler(this.stidtxtbox_OnValueChanged);
            this.stidtxtbox.Enter += new System.EventHandler(this.stidtxtbox_Enter);
            this.stidtxtbox.Leave += new System.EventHandler(this.stidtxtbox_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(342, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Red;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Firebrick;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Change";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.Location = new System.Drawing.Point(51, 179);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(75, 36);
            this.bunifuThinButton21.TabIndex = 1;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Location = new System.Drawing.Point(14, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dgvstudents
            // 
            this.dgvstudents.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvstudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvstudents.Location = new System.Drawing.Point(0, 233);
            this.dgvstudents.Name = "dgvstudents";
            this.dgvstudents.Size = new System.Drawing.Size(1106, 297);
            this.dgvstudents.TabIndex = 41;
            this.dgvstudents.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgvstudents_RowHeaderMouseClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // AddStudent
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1106, 530);
            this.Controls.Add(this.dgvstudents);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private buttons maxbtn;
        private buttons buttons7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private buttons buttons2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelleftside;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvstudents;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox stidtxtbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox stlnametxtbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox stfnametxtbox;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuMaterialTextbox stdepttxtbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox stphonetxtbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox stpasstxtbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox stdobtxtbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox staddtxtbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Closebutton;
        private System.Windows.Forms.Button minimizebutton;
        private System.Windows.Forms.Button Maximizebutton;
        private buttons buttons1;
        private System.Windows.Forms.ComboBox cbdepts;
    }
}