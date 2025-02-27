namespace WinFormsApp1.Lab3
{
    partial class frmLab3A
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
            cboMovie = new ComboBox();
            lblCast = new Label();
            btnCast = new Button();
            SuspendLayout();
            // 
            // cboMovie
            // 
            cboMovie.FormattingEnabled = true;
            cboMovie.Items.AddRange(new object[] { "The Godfather", "Terminator", "Back to the Future", "Matrix" });
            cboMovie.Location = new Point(72, 134);
            cboMovie.Name = "cboMovie";
            cboMovie.Size = new Size(121, 23);
            cboMovie.TabIndex = 0;
            // 
            // lblCast
            // 
            lblCast.Location = new Point(72, 74);
            lblCast.Name = "lblCast";
            lblCast.Size = new Size(189, 20);
            lblCast.TabIndex = 1;
            lblCast.Text = "My Choice of Best Movie Series";
            // 
            // btnCast
            // 
            btnCast.Location = new Point(72, 266);
            btnCast.Name = "btnCast";
            btnCast.Size = new Size(169, 23);
            btnCast.TabIndex = 2;
            btnCast.Text = "Cast Your Vote";
            btnCast.UseVisualStyleBackColor = true;
            btnCast.Click += btnCast_Click;
            // 
            // frmLab3A
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 351);
            Controls.Add(btnCast);
            Controls.Add(lblCast);
            Controls.Add(cboMovie);
            Name = "frmLab3A";
            Text = "frmLab3A";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboMovie;
        private Label lblCast;
        private Button btnCast;
    }
}