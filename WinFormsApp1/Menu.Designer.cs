using WinFormsApp1.Lab2;
using WinFormsApp1.Lab3;
namespace WinFormsApp1
{
    partial class Menu
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
            cboLabs = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 36F);
            label1.Location = new Point(90, 94);
            label1.Name = "label1";
            label1.Size = new Size(269, 70);
            label1.TabIndex = 0;
            label1.Text = "SDP Labs";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboLabs
            // 
            cboLabs.FormattingEnabled = true;
            cboLabs.Location = new Point(157, 184);
            cboLabs.Name = "cboLabs";
            cboLabs.Size = new Size(121, 23);
            cboLabs.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(184, 260);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Open";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 403);
            Controls.Add(button1);
            Controls.Add(cboLabs);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox cboLabs;
        private Button button1;
    }
}