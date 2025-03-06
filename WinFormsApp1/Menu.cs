using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Lab2;
using WinFormsApp1.Lab3;

namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            cboLabs.Items.Add("Lab1");
            cboLabs.Items.Add("Lab 2A");
            cboLabs.Items.Add("Lab 2B");
            cboLabs.Items.Add("Lab 2C");
            cboLabs.Items.Add("Lab 3A");
            cboLabs.Items.Add("Lab 3B");
            cboLabs.Items.Add("Lab 3C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (cboLabs.SelectedItem.ToString()){
                case "Lab1":
                    Form1 lab1 = new Form1();
                    lab1.Show();
                    break;
                case "Lab 2A":
                    frmLab2A lab2A = new frmLab2A();
                    lab2A.Show();
                    break;
                case "Lab 2B":
                    frmLab2B lab2B = new frmLab2B();
                    lab2B.Show();
                    break;
                case "Lab 2C":
                    frmLab2C lab2C = new frmLab2C();
                    lab2C.Show();
                    break;
                case "Lab 3A":
                    frmLab3A lab3A = new frmLab3A();
                    lab3A.Show();
                    break;
                case "Lab 3B":
                    frmLab3B lab3B = new frmLab3B();
                    lab3B.Show();
                    break;
                case "Lab 3C":
                    frmLab3C lab3C = new frmLab3C();
                    lab3C.Show();
                    break;
            }
        }
    }
}
