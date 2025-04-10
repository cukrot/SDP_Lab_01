namespace WinFormsApp1.Lab6
{
    partial class frmLab6
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
            btnReg = new Button();
            btnLogin = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnReg
            // 
            btnReg.Location = new Point(86, 70);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(75, 23);
            btnReg.TabIndex = 0;
            btnReg.Text = "Register";
            btnReg.UseVisualStyleBackColor = true;
            btnReg.Click += btnReg_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(86, 127);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(86, 193);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // frmLab6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 309);
            Controls.Add(btnLogout);
            Controls.Add(btnLogin);
            Controls.Add(btnReg);
            Name = "frmLab6";
            Text = "frmLab6";
            ResumeLayout(false);
        }

        #endregion

        private Button btnReg;
        private Button btnLogin;
        private Button btnLogout;
    }
}