using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;

namespace WinFormsApp1.Lab6
{
    public partial class frmLogin : Form
    {
        public bool isLogin = false;
        public frmLogin()
        {
            InitializeComponent();
            isLogin = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("ict1911")
            && txtPassword.Text.Equals("ictuser"))
            {
                isLogin = true;
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect user name or password. "
                            + "Please try again.");
                isLogin = false;
                txtUsername.Text = "";
                txtPassword.Text = "";

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
