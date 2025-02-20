using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Lab2
{
    public partial class frmLab2B : Form
    {
        public frmLab2B()
        {
            InitializeComponent();
        }

        private void rdoSunny_CheckedChanged(object sender, EventArgs e)
        {
            picCloudy.Visible = false;
            picRainy.Visible = false;
            picSnowy.Visible = false;
            picSuny.Visible = true;
            lblMessage.Text = "It’s going to be a cloudy day today, " + txtName.Text + ".";
        }

        private void rdoSnowy_CheckedChanged(object sender, EventArgs e)
        {
            picCloudy.Visible = false;
            picRainy.Visible = false;
            picSnowy.Visible = true;
            picSuny.Visible = false;
            lblMessage.Text = "It’s going to be a snowy day today, " + txtName.Text + ".";
        }

        private void rdoRainy_CheckedChanged(object sender, EventArgs e)
        {
            picCloudy.Visible = false;
            picRainy.Visible = true;
            picSnowy.Visible = false;
            picSuny.Visible = false;
            lblMessage.Text = "It’s going to be a rainy day today, " + txtName.Text + ".";
        }

        private void rdoCloudy_CheckedChanged(object sender, EventArgs e)
        {
            picCloudy.Visible = true;
            picRainy.Visible = false;
            picSnowy.Visible = false;
            picSuny.Visible = false;
            lblMessage.Text = "It’s going to be a cloudy day today, " + txtName.Text + ".";
        }

    }
}
