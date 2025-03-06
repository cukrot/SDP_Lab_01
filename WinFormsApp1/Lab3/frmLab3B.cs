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
    public partial class frmLab3B : Form
    {
        private int amount;
        private double r;
        public frmLab3B()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            amount = Convert.ToInt32(txtAmount.Text);
            r = Convert.ToDouble(txtRate.Text);
            double value10 = amount * Math.Pow((1 + r), 10);
            double target = amount;
            int year = 0;
            while (target < 1000000 && year < 100)
            {
                target = amount * Math.Pow((1 + r), year);
                year++;
            }
            lblValue2.Text = value10.ToString();
            if (year > 100)
            {
                lblMillion2.Text = ">100";
            }
            else
            {
                lblMillion2.Text = year.ToString();
            }
        }

        private void frmLab3B_Load(object sender, EventArgs e)
        {
            amount = 0;
            r = 0;
        }
    }
}
