using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;



namespace ExaminationSystem.General
{
    static class WindowsSizeControl
    {

        static bool isMax = false , isFull = false;
        static Point old_loc, default_loc;
        static Size old_size, default_size;

        public static void SetIntial (Form form)
        {
            old_loc = form.Location;
            old_size = form.Size;
            default_loc = form.Location;
            default_size = form.Size;

        }

        public static void Exit()
        {
            Application.Exit();
        }

        public static void Minimize(Form form)
        {
            if (form.WindowState == FormWindowState.Minimized)
                form.WindowState = FormWindowState.Normal;
            else if (form.WindowState == FormWindowState.Normal)
                form.WindowState = FormWindowState.Minimized;

        }
        public static void DoMaximize(Form form,Button maxbtn)
        {
            if(isMax == false) //app not maximized , then maximize it
            {
                old_loc = new Point(form.Location.X , form.Location.Y);
                old_size = new Size(form.Size.Width, form.Size.Height);
                Maximize(form);
                isMax = true;
                isFull = false;
                maxbtn.Text = "";
            }

            else // app is currently maximized, restore it to normal
            {
               form.Location = old_loc;
               form.Size = old_size;
                isMax = false;
                isFull = false;
            }
        }

        static void Maximize(Form form)
        {
            int x = SystemInformation.WorkingArea.Width;
            int y = SystemInformation.WorkingArea.Height;
            form.WindowState = FormWindowState.Normal;
            form.Location = new Point(0, 0);
            form.Size = new Size(x, y);

        }
        
    }
}
