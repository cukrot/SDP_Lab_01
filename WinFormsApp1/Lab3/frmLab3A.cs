using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Lab3
{
    public partial class frmLab3A : Form
    {
        public frmLab3A()
        {
            InitializeComponent();
        }

        private void btnCast_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show($"Do you vote for \n{cboMovie.SelectedItem.ToString()}",
                "Vote Movie", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes) {
                MessageBox.Show("You are welcomed");
            }
            else
            {
                MessageBox.Show("Cancel Voting");
            }
        }
    }
}
