using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click_Maddness
{
    public partial class Form1 : Form
    {
        // Set attributes
        int Timertime = 50;
        int ButtonClicks = 0;
        bool Switch = false;

        public Form1()
        {
            InitializeComponent();
        }

        // Upon clicking the button, the timer is enabled and the clicks are recorded
        private void btnClickMe_Click(object sender, EventArgs e)
        {
            if (Timertime > 0)
            {
                ButtonClicks += 1;
                lblScore.Text = ButtonClicks.ToString();
                if (!Switch) ;
                {
                    tmrTimer.Enabled = true;
                }
            }
        }

        // Display the timer tick count down
        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            if (Timertime > 0)
            {
                Timertime -= 1;
                lblTimer.Text = Timertime.ToString();
            }
            else
            {
                tmrTimer.Enabled = false;
            }
        }

        // Reset button will reset variables
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (Timertime == 0)
            {
                Timertime = 50;
                ButtonClicks = 0;
                Switch = false;
                lblScore.Text = 0.ToString();
                lblTimer.Text = Timertime.ToString();
            }
        }
    }
}
