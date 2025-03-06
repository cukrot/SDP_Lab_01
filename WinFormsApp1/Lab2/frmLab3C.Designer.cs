namespace WinFormsApp1.Lab2
{
    partial class frmLab3C
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listShop = new ListBox();
            listCart = new ListBox();
            btnMoveToCart = new Button();
            btnMoveToShop = new Button();
            btnAddFruit = new Button();
            btnCount = new Button();
            btcClear = new Button();
            lblFruit = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // listShop
            // 
            listShop.FormattingEnabled = true;
            listShop.ItemHeight = 15;
            listShop.Items.AddRange(new object[] { "Apple", "Banana", "Grape", "Orange", "Peach", "Pear", "Pineapple" });
            listShop.Location = new Point(20, 27);
            listShop.Name = "listShop";
            listShop.SelectionMode = SelectionMode.MultiExtended;
            listShop.Size = new Size(120, 154);
            listShop.TabIndex = 0;
            // 
            // listCart
            // 
            listCart.FormattingEnabled = true;
            listCart.ItemHeight = 15;
            listCart.Location = new Point(314, 27);
            listCart.Name = "listCart";
            listCart.Size = new Size(120, 154);
            listCart.TabIndex = 1;
            // 
            // btnMoveToCart
            // 
            btnMoveToCart.Location = new Point(188, 27);
            btnMoveToCart.Name = "btnMoveToCart";
            btnMoveToCart.Size = new Size(75, 23);
            btnMoveToCart.TabIndex = 2;
            btnMoveToCart.Text = "-->";
            btnMoveToCart.UseVisualStyleBackColor = true;
            btnMoveToCart.Click += btnMoveToCart_Click;
            // 
            // btnMoveToShop
            // 
            btnMoveToShop.Location = new Point(188, 90);
            btnMoveToShop.Name = "btnMoveToShop";
            btnMoveToShop.Size = new Size(75, 23);
            btnMoveToShop.TabIndex = 3;
            btnMoveToShop.Text = "<--";
            btnMoveToShop.UseVisualStyleBackColor = true;
            btnMoveToShop.Click += btnMoveToShop_Click;
            // 
            // btnAddFruit
            // 
            btnAddFruit.Location = new Point(65, 297);
            btnAddFruit.Name = "btnAddFruit";
            btnAddFruit.Size = new Size(75, 23);
            btnAddFruit.TabIndex = 4;
            btnAddFruit.Text = "AddFruit";
            btnAddFruit.UseVisualStyleBackColor = true;
            btnAddFruit.Click += btnAddFruit_Click;
            // 
            // btnCount
            // 
            btnCount.Location = new Point(235, 297);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(95, 48);
            btnCount.TabIndex = 5;
            btnCount.Text = "Count Shop + Cart";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // btcClear
            // 
            btcClear.Location = new Point(359, 297);
            btcClear.Name = "btcClear";
            btcClear.Size = new Size(95, 48);
            btcClear.TabIndex = 6;
            btcClear.Text = "Clear Cart";
            btcClear.UseVisualStyleBackColor = true;
            btcClear.Click += btcClear_Click;
            // 
            // lblFruit
            // 
            lblFruit.AutoSize = true;
            lblFruit.Location = new Point(20, 231);
            lblFruit.Name = "lblFruit";
            lblFruit.Size = new Size(53, 15);
            lblFruit.TabIndex = 7;
            lblFruit.Text = "AddFruit";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 228);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            // 
            // frmLab3C
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 386);
            Controls.Add(textBox1);
            Controls.Add(lblFruit);
            Controls.Add(btcClear);
            Controls.Add(btnCount);
            Controls.Add(btnAddFruit);
            Controls.Add(btnMoveToShop);
            Controls.Add(btnMoveToCart);
            Controls.Add(listCart);
            Controls.Add(listShop);
            Name = "frmLab3C";
            Text = "frmLab3C";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listShop;
        private ListBox listCart;
        private Button btnMoveToCart;
        private Button btnMoveToShop;
        private Button btnAddFruit;
        private Button btnCount;
        private Button btcClear;
        private Label lblFruit;
        private TextBox textBox1;
    }
}