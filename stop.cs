using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class lb : Form
    {
        private int ours, minutes, seconds;
        public lb()
        {
            InitializeComponent();

            ours = minutes = seconds = 0;
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            seconds++;
            if(seconds > 59)
            {
                seconds = 0;
                minutes++;
            }

           if (minutes > 59)
            {
                minutes = 0;
                ours++;
            }

            lbours.Text = ours.ToString();
            lbminutes.Text = ours.ToString();
            lbseconds.Text = ours.ToString();

            Private String tosls(int value)
                {
                if(value > 9)
                {
                    return ValueTuple.tostrin();
                    else 
                        return 0 + value
                }
            }
        }
    }
}
