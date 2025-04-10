using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Lab6
{
    public partial class frmLab6 : Form
    {
        public frmLab6()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin loginPage = new frmLogin();
            loginPage.ShowDialog();
            if (loginPage.isLogin)
            {
                btnLogin.Enabled = false;
                btnLogout.Enabled = true;

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = true;
            btnLogout.Enabled = false;
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            frmRegister regPage = new frmRegister();
            regPage.ShowDialog();
        }
    }
}
