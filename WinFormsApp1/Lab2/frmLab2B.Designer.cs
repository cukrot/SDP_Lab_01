namespace WinFormsApp1.Lab2
{
    partial class frmLab2B
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
            label1 = new Label();
            lblMessage = new Label();
            txtName = new TextBox();
            groupBox1 = new GroupBox();
            rdoSunny = new RadioButton();
            rdoSnowy = new RadioButton();
            rdoRainy = new RadioButton();
            rdoCloudy = new RadioButton();
            picCloudy = new PictureBox();
            picRainy = new PictureBox();
            picSnowy = new PictureBox();
            picSuny = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCloudy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRainy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSnowy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSuny).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 74);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter your name here";
            // 
            // lblMessage
            // 
            lblMessage.BorderStyle = BorderStyle.Fixed3D;
            lblMessage.Location = new Point(68, 306);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(443, 83);
            lblMessage.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(194, 71);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoSunny);
            groupBox1.Controls.Add(rdoSnowy);
            groupBox1.Controls.Add(rdoRainy);
            groupBox1.Controls.Add(rdoCloudy);
            groupBox1.Location = new Point(61, 137);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(205, 134);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose";
            // 
            // rdoSunny
            // 
            rdoSunny.AutoSize = true;
            rdoSunny.Location = new Point(7, 97);
            rdoSunny.Name = "rdoSunny";
            rdoSunny.Size = new Size(58, 19);
            rdoSunny.TabIndex = 3;
            rdoSunny.TabStop = true;
            rdoSunny.Text = "Sunny";
            rdoSunny.UseVisualStyleBackColor = true;
            rdoSunny.CheckedChanged += rdoSunny_CheckedChanged;
            // 
            // rdoSnowy
            // 
            rdoSnowy.AutoSize = true;
            rdoSnowy.Location = new Point(7, 72);
            rdoSnowy.Name = "rdoSnowy";
            rdoSnowy.Size = new Size(60, 19);
            rdoSnowy.TabIndex = 2;
            rdoSnowy.TabStop = true;
            rdoSnowy.Text = "Snowy";
            rdoSnowy.UseVisualStyleBackColor = true;
            rdoSnowy.CheckedChanged += rdoSnowy_CheckedChanged;
            // 
            // rdoRainy
            // 
            rdoRainy.AutoSize = true;
            rdoRainy.Location = new Point(7, 47);
            rdoRainy.Name = "rdoRainy";
            rdoRainy.Size = new Size(54, 19);
            rdoRainy.TabIndex = 1;
            rdoRainy.TabStop = true;
            rdoRainy.Text = "Rainy";
            rdoRainy.UseVisualStyleBackColor = true;
            rdoRainy.CheckedChanged += rdoRainy_CheckedChanged;
            // 
            // rdoCloudy
            // 
            rdoCloudy.AutoSize = true;
            rdoCloudy.Location = new Point(7, 22);
            rdoCloudy.Name = "rdoCloudy";
            rdoCloudy.Size = new Size(63, 19);
            rdoCloudy.TabIndex = 0;
            rdoCloudy.TabStop = true;
            rdoCloudy.Text = "Cloudy";
            rdoCloudy.UseVisualStyleBackColor = true;
            rdoCloudy.CheckedChanged += rdoCloudy_CheckedChanged;
            // 
            // picCloudy
            // 
            picCloudy.Image = Properties.Resources.cloud316;
            picCloudy.Location = new Point(308, 137);
            picCloudy.Name = "picCloudy";
            picCloudy.Size = new Size(64, 64);
            picCloudy.TabIndex = 4;
            picCloudy.TabStop = false;
            // 
            // picRainy
            // 
            picRainy.Image = Properties.Resources.raindrops2;
            picRainy.Location = new Point(378, 137);
            picRainy.Name = "picRainy";
            picRainy.Size = new Size(64, 64);
            picRainy.TabIndex = 5;
            picRainy.TabStop = false;
            // 
            // picSnowy
            // 
            picSnowy.Image = Properties.Resources.snow263;
            picSnowy.Location = new Point(308, 209);
            picSnowy.Name = "picSnowy";
            picSnowy.Size = new Size(64, 64);
            picSnowy.TabIndex = 6;
            picSnowy.TabStop = false;
            // 
            // picSuny
            // 
            picSuny.Image = Properties.Resources.sky;
            picSuny.Location = new Point(378, 209);
            picSuny.Name = "picSuny";
            picSuny.Size = new Size(64, 64);
            picSuny.TabIndex = 7;
            picSuny.TabStop = false;
            // 
            // frmLab2B
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picSuny);
            Controls.Add(picSnowy);
            Controls.Add(picRainy);
            Controls.Add(picCloudy);
            Controls.Add(groupBox1);
            Controls.Add(txtName);
            Controls.Add(lblMessage);
            Controls.Add(label1);
            Name = "frmLab2B";
            Text = "frmLab2B";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCloudy).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRainy).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSnowy).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSuny).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblMessage;
        private TextBox txtName;
        private GroupBox groupBox1;
        private RadioButton rdoSunny;
        private RadioButton rdoSnowy;
        private RadioButton rdoRainy;
        private RadioButton rdoCloudy;
        private PictureBox picCloudy;
        private PictureBox picRainy;
        private PictureBox picSnowy;
        private PictureBox picSuny;
    }
}