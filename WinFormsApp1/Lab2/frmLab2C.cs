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
    public partial class frmLab2C : Form
    {
        public frmLab2C()
        {
            InitializeComponent();
        }

        private void frmLab2C_Load(object sender, EventArgs e)
        {
            lstStudents.Items.Add("Mary Chu");
            lstStudents.Items.Add("Peter Lee");
            lstStudents.Items.Add("Johnson Chan");
            lstStudents.Items.Add("Alex Leung");
        }

        private void lblDelete_DoubleClick(object sender, EventArgs e)
        {
            String str = (String)lstStudents.SelectedItem;
            lstStudents.Items.Remove(lstStudents.SelectedItem);
            lblMessage.Text = "The following item is deleted: " + str;
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0)
            {
                lstStudents.Items.Add(txtName.Text);
            }
        }

        private void lstStudents_DoubleClick(object sender, EventArgs e)
        {
            String str = (String)lstStudents.SelectedItem;
            lblMessage.Text = "The following item is selected: " + str;
        }
    }
}
