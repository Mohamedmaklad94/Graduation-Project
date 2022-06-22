namespace ExaminationSystem
{
    partial class TimerTest
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
            this.lblscreen = new System.Windows.Forms.Label();
            this.countdowntimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblscreen
            // 
            this.lblscreen.AutoSize = true;
            this.lblscreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscreen.Location = new System.Drawing.Point(365, 68);
            this.lblscreen.Name = "lblscreen";
            this.lblscreen.Size = new System.Drawing.Size(0, 24);
            this.lblscreen.TabIndex = 0;
            // 
            // countdowntimer
            // 
            this.countdowntimer.Interval = 1000;
            this.countdowntimer.Tick += new System.EventHandler(this.Countdowntimer_Tick);
            // 
            // TimerTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblscreen);
            this.Name = "TimerTest";
            this.Text = "TimerTest";
            this.Load += new System.EventHandler(this.TimerTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblscreen;
        private System.Windows.Forms.Timer countdowntimer;
    }
}