namespace WinFormsApp1.Lab2
{
    partial class frmLab2C
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
            lstStudents = new ListBox();
            txtName = new TextBox();
            btnAdd = new Button();
            lblDelete = new Label();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 15;
            lstStudents.Location = new Point(92, 58);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(120, 94);
            lstStudents.TabIndex = 0;
            lstStudents.SelectedIndexChanged += lstStudents_SelectedIndexChanged;
            lstStudents.DoubleClick += lstStudents_DoubleClick;
            // 
            // txtName
            // 
            txtName.Location = new Point(306, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(264, 23);
            txtName.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(315, 129);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add an item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblDelete
            // 
            lblDelete.AutoSize = true;
            lblDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDelete.Location = new Point(315, 210);
            lblDelete.Name = "lblDelete";
            lblDelete.Size = new Size(137, 15);
            lblDelete.TabIndex = 3;
            lblDelete.Text = "[Double click to delete]";
            lblDelete.DoubleClick += lblDelete_DoubleClick;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = SystemColors.ActiveCaption;
            lblMessage.BorderStyle = BorderStyle.Fixed3D;
            lblMessage.Location = new Point(78, 348);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(492, 44);
            lblMessage.TabIndex = 4;
            // 
            // frmLab2C
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMessage);
            Controls.Add(lblDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtName);
            Controls.Add(lstStudents);
            Name = "frmLab2C";
            Text = "frmLab2C";
            Load += frmLab2C_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstStudents;
        private TextBox txtName;
        private Button btnAdd;
        private Label lblDelete;
        private Label lblMessage;
    }
}