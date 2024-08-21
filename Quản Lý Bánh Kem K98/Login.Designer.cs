namespace Quản_Lý_Quán_Bánh_Kem_K98
{
    partial class Login
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
            txtTenDangNhap = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtMatKhau = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btnTenDangNhap = new Button();
            btnClear = new Button();
            ForOwnerChecker = new CheckBox();
            ToRegister = new Label();
            CheckPassword = new CheckBox();
            btnCloseAll = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(56, 220);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(256, 27);
            txtTenDangNhap.TabIndex = 5;
            txtTenDangNhap.TextChanged += txtTenDangNhap_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(56, 193);
            label2.Name = "label2";
            label2.Size = new Size(85, 18);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(56, 277);
            label1.Name = "label1";
            label1.Size = new Size(83, 18);
            label1.TabIndex = 4;
            label1.Text = "Password";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(56, 314);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(256, 27);
            txtMatKhau.TabIndex = 5;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(139, 112);
            label3.Name = "label3";
            label3.Size = new Size(59, 18);
            label3.TabIndex = 4;
            label3.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.birthday_cake_1021x1024__1_;
            pictureBox1.Location = new Point(130, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnTenDangNhap
            // 
            btnTenDangNhap.BackColor = Color.FromArgb(64, 64, 64);
            btnTenDangNhap.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTenDangNhap.ForeColor = Color.White;
            btnTenDangNhap.Location = new Point(39, 446);
            btnTenDangNhap.Name = "btnTenDangNhap";
            btnTenDangNhap.Size = new Size(285, 44);
            btnTenDangNhap.TabIndex = 7;
            btnTenDangNhap.Text = "Login";
            btnTenDangNhap.UseVisualStyleBackColor = false;
            btnTenDangNhap.Click += btnTenDangNhap_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(64, 64, 64);
            btnClear.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(39, 523);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(285, 44);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // ForOwnerChecker
            // 
            ForOwnerChecker.AutoSize = true;
            ForOwnerChecker.BackColor = Color.Transparent;
            ForOwnerChecker.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 128);
            ForOwnerChecker.ForeColor = Color.Black;
            ForOwnerChecker.Location = new Point(203, 357);
            ForOwnerChecker.Name = "ForOwnerChecker";
            ForOwnerChecker.Size = new Size(99, 20);
            ForOwnerChecker.TabIndex = 8;
            ForOwnerChecker.Text = "For Owner";
            ForOwnerChecker.UseVisualStyleBackColor = false;
            ForOwnerChecker.CheckedChanged += ForOwnerChecker_CheckedChanged;
            // 
            // ToRegister
            // 
            ToRegister.AutoSize = true;
            ToRegister.BackColor = Color.Transparent;
            ToRegister.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            ToRegister.ForeColor = Color.Black;
            ToRegister.Location = new Point(82, 581);
            ToRegister.Name = "ToRegister";
            ToRegister.Size = new Size(162, 18);
            ToRegister.TabIndex = 4;
            ToRegister.Text = "Create New Account";
            ToRegister.Click += ToRegister_Click;
            // 
            // CheckPassword
            // 
            CheckPassword.AutoSize = true;
            CheckPassword.BackColor = Color.Transparent;
            CheckPassword.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 128);
            CheckPassword.ForeColor = Color.Black;
            CheckPassword.Location = new Point(182, 399);
            CheckPassword.Name = "CheckPassword";
            CheckPassword.Size = new Size(138, 20);
            CheckPassword.TabIndex = 8;
            CheckPassword.Text = "Show Password";
            CheckPassword.UseVisualStyleBackColor = false;
            CheckPassword.CheckedChanged += CheckPassword_CheckedChanged;
            // 
            // btnCloseAll
            // 
            btnCloseAll.BackColor = Color.Transparent;
            btnCloseAll.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseAll.ForeColor = Color.Black;
            btnCloseAll.Location = new Point(326, 0);
            btnCloseAll.Name = "btnCloseAll";
            btnCloseAll.Size = new Size(43, 31);
            btnCloseAll.TabIndex = 7;
            btnCloseAll.Text = "X";
            btnCloseAll.UseVisualStyleBackColor = false;
            btnCloseAll.Click += btnCloseAll_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.output_onlinepngtools;
            ClientSize = new Size(368, 645);
            Controls.Add(CheckPassword);
            Controls.Add(ForOwnerChecker);
            Controls.Add(btnClear);
            Controls.Add(btnCloseAll);
            Controls.Add(btnTenDangNhap);
            Controls.Add(pictureBox1);
            Controls.Add(txtMatKhau);
            Controls.Add(ToRegister);
            Controls.Add(label1);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenDangNhap;
        private Label label2;
        private Label label1;
        private TextBox txtMatKhau;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnTenDangNhap;
        private Button btnClear;
        private CheckBox ForOwnerChecker;
        private Label ToRegister;
        private CheckBox CheckPassword;
        private Button btnCloseAll;
    }
}