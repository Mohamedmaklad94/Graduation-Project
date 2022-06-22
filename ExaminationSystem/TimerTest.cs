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


    public partial class TimerTest : Form
    {
        // number of seconds
        int quick = 130;
        public TimerTest()
        {
            InitializeComponent();
        }

        private void TimerTest_Load(object sender, EventArgs e)
        {
            countdowntimer.Start();
        }

        private void Countdowntimer_Tick(object sender, EventArgs e)
        {
            quick--;
            lblscreen.Text = quick / 60 + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
            if (quick == 0)
            {
                countdowntimer.Stop();
            }
        }
    }
}
