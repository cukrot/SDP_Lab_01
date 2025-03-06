using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Lab2
{
    public partial class frmLab3C : Form
    {
        public frmLab3C()
        {
            InitializeComponent();
        }

        private void btnMoveToCart_Click(object sender, EventArgs e)
        {
            Object [] shopItem;
            if (listShop.SelectedItems.Count > 0) {
                shopItem = listShop.SelectedItems.Cast<object>().ToArray();
                for (int i = 0; i < listShop.SelectedItems.Count; i++) {
                    listShop.Items.Remove(shopItem);
                    listCart.Items.Add(shopItem);
                }
            }
        }

        private void btnMoveToShop_Click(object sender, EventArgs e)
        {

        }

        private void btnAddFruit_Click(object sender, EventArgs e)
        {

        }
        private void btnCount_Click(object sender, EventArgs e)
        {

        }

        private void btcClear_Click(object sender, EventArgs e)
        {

        }


    }
}
