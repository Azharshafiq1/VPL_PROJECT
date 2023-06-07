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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlo_Click(object sender, EventArgs e)
        {
            String Username = txtusername.Text;
            String Userpassword = txtuserpassword.Text;
            errorProvider1.Clear();
             
            if (Username == "")
            {
                errorProvider1.SetError(txtusername, "abay oo name likh");
            }

            else if(Userpassword == "")
            {
                errorProvider1.SetError(txtusername, "abay oo password likh");
            }

            else
            {
                if (Username.ToUpper() == "ADMIN" && Userpassword.ToUpper() == "PAPA")
                {
                    //MessageBox.Show("your password is valid");
                    main mf = new main();
                    mf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("your password is incorrect");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtusername.Text = txtuserpassword.Text = "";
        }
    }
}
