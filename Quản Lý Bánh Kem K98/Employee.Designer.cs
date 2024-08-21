namespace Quản_Lý_Quán_Bánh_Kem_K98
{
    partial class Employee
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
            txtUsername = new TextBox();
            btnCheckIn = new Button();
            label1 = new Label();
            lbError = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(347, 201);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Location = new Point(347, 252);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(125, 29);
            btnCheckIn.TabIndex = 1;
            btnCheckIn.Text = "Check In";
            btnCheckIn.UseVisualStyleBackColor = true;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 208);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 2;
            label1.Text = "Ten dang nhap";
            label1.Click += label1_Click;
            // 
            // lbError
            // 
            lbError.AutoSize = true;
            lbError.Location = new Point(350, 297);
            lbError.Name = "lbError";
            lbError.Size = new Size(0, 20);
            lbError.TabIndex = 3;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbError);
            Controls.Add(label1);
            Controls.Add(btnCheckIn);
            Controls.Add(txtUsername);
            Name = "Employee";
            Text = "Employee";
            Load += Employee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private Button btnCheckIn;
        private Label label1;
        private Label lbError;
    }
}