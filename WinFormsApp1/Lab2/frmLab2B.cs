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
            updatePic(picSuny, rdoSunny);
        }

        private void rdoSnowy_CheckedChanged(object sender, EventArgs e)
        {
            updatePic(picSnowy, rdoSnowy);
        }

        private void rdoRainy_CheckedChanged(object sender, EventArgs e)
        {
            updatePic(picRainy, rdoRainy);
        }

        private void rdoCloudy_CheckedChanged(object sender, EventArgs e)
        {
            updatePic(picCloudy, rdoCloudy);
        }

        private void updatePic(PictureBox pic, RadioButton rd)
        {
            picCloudy.Visible = false;
            picRainy.Visible = false;
            picSnowy.Visible = false;
            picSuny.Visible = true;
            pic.Visible = true;
            String str = rd.Text;
            lblMessage.Text = "It’s going to be a "+ str +" today, " + txtName.Text + ".";
        }

    }
}
