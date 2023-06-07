using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer cm = new customer();
            cm.Show();
            cm.MdiParent = this;
            cm.Hide();
        }

        private void otToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stopwatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb sw = new lb();
            sw.MdiParent = this;
            sw.Show();
            sw.Hide();
        }
    }
}
