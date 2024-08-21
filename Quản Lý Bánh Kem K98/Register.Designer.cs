namespace Quản_Lý_Quán_Bánh_Kem_K98
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            txtMatKhau = new TextBox();
            label1 = new Label();
            txtTenDangNhap = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtNhapLaiMatKhau = new TextBox();
            checkPassword = new CheckBox();
            button2 = new Button();
            btnDangKy = new Button();
            label6 = new Label();
            txtHoTen = new TextBox();
            OpenLogin = new Label();
            btnCloseAll = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.birthday_cake_1021x1024__1_;
            pictureBox1.Location = new Point(131, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(39, 290);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(256, 27);
            txtMatKhau.TabIndex = 10;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(39, 253);
            label1.Name = "label1";
            label1.Size = new Size(89, 24);
            label1.TabIndex = 7;
            label1.Text = "Password";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(39, 210);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(256, 27);
            txtTenDangNhap.TabIndex = 11;
            txtTenDangNhap.TextChanged += txtTenDangNhap_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(131, 75);
            label3.Name = "label3";
            label3.Size = new Size(80, 24);
            label3.TabIndex = 8;
            label3.Text = "Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(39, 183);
            label2.Name = "label2";
            label2.Size = new Size(96, 24);
            label2.TabIndex = 9;
            label2.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(39, 326);
            label4.Name = "label4";
            label4.Size = new Size(157, 24);
            label4.TabIndex = 9;
            label4.Text = "Repeat Password";
            label4.Click += label4_Click;
            // 
            // txtNhapLaiMatKhau
            // 
            txtNhapLaiMatKhau.Location = new Point(39, 353);
            txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            txtNhapLaiMatKhau.PasswordChar = '*';
            txtNhapLaiMatKhau.Size = new Size(256, 27);
            txtNhapLaiMatKhau.TabIndex = 11;
            txtNhapLaiMatKhau.TextChanged += txtNhapLaiMatKhau_TextChanged;
            // 
            // checkPassword
            // 
            checkPassword.AutoSize = true;
            checkPassword.BackColor = Color.Transparent;
            checkPassword.Font = new Font("FOT-Yuruka Std UB", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 128);
            checkPassword.ForeColor = Color.Black;
            checkPassword.Location = new Point(173, 397);
            checkPassword.Name = "checkPassword";
            checkPassword.Size = new Size(142, 25);
            checkPassword.TabIndex = 16;
            checkPassword.Text = "Show Password";
            checkPassword.UseVisualStyleBackColor = false;
            checkPassword.CheckedChanged += checkPassword_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(30, 487);
            button2.Name = "button2";
            button2.Size = new Size(285, 44);
            button2.TabIndex = 14;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.FromArgb(64, 64, 64);
            btnDangKy.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(30, 424);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(285, 44);
            btnDangKy.TabIndex = 15;
            btnDangKy.Text = "Register";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(39, 114);
            label6.Name = "label6";
            label6.Size = new Size(60, 24);
            label6.TabIndex = 9;
            label6.Text = "Name";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.Click += label4_Click;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(39, 141);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(256, 27);
            txtHoTen.TabIndex = 11;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // OpenLogin
            // 
            OpenLogin.AutoSize = true;
            OpenLogin.BackColor = Color.Transparent;
            OpenLogin.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            OpenLogin.ForeColor = Color.Black;
            OpenLogin.Location = new Point(39, 548);
            OpenLogin.Name = "OpenLogin";
            OpenLogin.Size = new Size(272, 24);
            OpenLogin.TabIndex = 9;
            OpenLogin.Text = "Already have account? Login";
            OpenLogin.TextAlign = ContentAlignment.TopCenter;
            OpenLogin.Click += OpenLogin_Click;
            // 
            // btnCloseAll
            // 
            btnCloseAll.BackColor = Color.Transparent;
            btnCloseAll.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseAll.ForeColor = Color.Black;
            btnCloseAll.Location = new Point(301, -1);
            btnCloseAll.Name = "btnCloseAll";
            btnCloseAll.Size = new Size(43, 31);
            btnCloseAll.TabIndex = 17;
            btnCloseAll.Text = "X";
            btnCloseAll.UseVisualStyleBackColor = false;
            btnCloseAll.Click += btnCloseAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.output_onlinepngtools;
            ClientSize = new Size(341, 581);
            Controls.Add(btnCloseAll);
            Controls.Add(checkPassword);
            Controls.Add(button2);
            Controls.Add(btnDangKy);
            Controls.Add(pictureBox1);
            Controls.Add(txtMatKhau);
            Controls.Add(label1);
            Controls.Add(txtHoTen);
            Controls.Add(txtNhapLaiMatKhau);
            Controls.Add(OpenLogin);
            Controls.Add(label6);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtMatKhau;
        private Label label1;
        private TextBox txtTenDangNhap;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox txtNhapLaiMatKhau;
        private CheckBox checkPassword;
        private Button button2;
        private Button btnDangKy;
        private Label label6;
        private TextBox txtHoTen;
        private Label OpenLogin;
        private Button btnCloseAll;
    }
}
