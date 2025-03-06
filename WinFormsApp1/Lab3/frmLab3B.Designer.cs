namespace WinFormsApp1.Lab3
{
    partial class frmLab3B
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
            lblAmount = new Label();
            lblRate = new Label();
            lblValue = new Label();
            lblMillion = new Label();
            lblValue2 = new Label();
            lblMillion2 = new Label();
            txtAmount = new TextBox();
            txtRate = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(54, 56);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(51, 15);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "Amount";
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(54, 101);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(121, 15);
            lblRate.TabIndex = 1;
            lblRate.Text = "Interest Rate (Annual)";
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Location = new Point(54, 203);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(107, 15);
            lblValue.TabIndex = 2;
            lblValue.Text = "Value after 10 years";
            // 
            // lblMillion
            // 
            lblMillion.AutoSize = true;
            lblMillion.Location = new Point(54, 250);
            lblMillion.Name = "lblMillion";
            lblMillion.Size = new Size(106, 15);
            lblMillion.TabIndex = 3;
            lblMillion.Text = "Years to reach $1M";
            // 
            // lblValue2
            // 
            lblValue2.BorderStyle = BorderStyle.Fixed3D;
            lblValue2.Location = new Point(179, 203);
            lblValue2.Name = "lblValue2";
            lblValue2.Size = new Size(100, 23);
            lblValue2.TabIndex = 4;
            lblValue2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMillion2
            // 
            lblMillion2.BorderStyle = BorderStyle.Fixed3D;
            lblMillion2.Location = new Point(179, 250);
            lblMillion2.Name = "lblMillion2";
            lblMillion2.Size = new Size(100, 23);
            lblMillion2.TabIndex = 5;
            lblMillion2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(179, 56);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(100, 23);
            txtAmount.TabIndex = 6;
            txtAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(179, 101);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(100, 23);
            txtRate.TabIndex = 7;
            txtRate.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(54, 153);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(225, 23);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Start Calculation";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // frmLab3B
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 360);
            Controls.Add(btnCalculate);
            Controls.Add(txtRate);
            Controls.Add(txtAmount);
            Controls.Add(lblMillion2);
            Controls.Add(lblValue2);
            Controls.Add(lblMillion);
            Controls.Add(lblValue);
            Controls.Add(lblRate);
            Controls.Add(lblAmount);
            Name = "frmLab3B";
            Text = "frmLab3B";
            Load += frmLab3B_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAmount;
        private Label lblRate;
        private Label lblValue;
        private Label lblMillion;
        private Label lblValue2;
        private Label lblMillion2;
        private TextBox txtAmount;
        private TextBox txtRate;
        private Button btnCalculate;
    }
}