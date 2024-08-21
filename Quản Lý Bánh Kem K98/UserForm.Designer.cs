namespace Quản_Lý_Quán_Bánh_Kem_K98
{
    partial class UserForm
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
            txtTenHo = new TextBox();
            btnExit = new Button();
            btnReset = new Button();
            label2 = new Label();
            txtTen = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtDiaChi = new TextBox();
            label9 = new Label();
            label3 = new Label();
            txtID = new TextBox();
            pfp = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            btnSave = new Button();
            btnChooseImage = new Button();
            btnCloseAll = new Button();
            ((System.ComponentModel.ISupportInitialize)pfp).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(107, 22);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // txtTenHo
            // 
            txtTenHo.Location = new Point(142, 67);
            txtTenHo.Name = "txtTenHo";
            txtTenHo.Size = new Size(125, 27);
            txtTenHo.TabIndex = 1;
            txtTenHo.TextChanged += txtTenHo_TextChanged;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(377, 476);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(99, 33);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(37, 476);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(99, 33);
            btnReset.TabIndex = 2;
            btnReset.Text = "Edit";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 139);
            label2.Name = "label2";
            label2.Size = new Size(105, 22);
            label2.TabIndex = 0;
            label2.Text = "Last Name";
            label2.Click += label1_Click;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(139, 136);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(125, 27);
            txtTen.TabIndex = 1;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 332);
            label7.Name = "label7";
            label7.Size = new Size(84, 22);
            label7.TabIndex = 0;
            label7.Text = "Birthday";
            label7.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(9, 205);
            label8.Name = "label8";
            label8.Size = new Size(83, 22);
            label8.TabIndex = 0;
            label8.Text = "Address";
            label8.Click += label1_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(139, 202);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(125, 27);
            txtDiaChi.TabIndex = 1;
            txtDiaChi.TextChanged += txtDiaChi_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(64, 64, 64);
            label9.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(223, 9);
            label9.Name = "label9";
            label9.Size = new Size(103, 22);
            label9.TabIndex = 0;
            label9.Text = "User Form";
            label9.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 266);
            label3.Name = "label3";
            label3.Size = new Size(29, 22);
            label3.TabIndex = 0;
            label3.Text = "ID";
            label3.Click += label1_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(139, 263);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 1;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // pfp
            // 
            pfp.BackColor = SystemColors.Control;
            pfp.BorderStyle = BorderStyle.FixedSingle;
            pfp.Location = new Point(323, 67);
            pfp.Name = "pfp";
            pfp.Size = new Size(189, 204);
            pfp.SizeMode = PictureBoxSizeMode.Zoom;
            pfp.TabIndex = 3;
            pfp.TabStop = false;
            pfp.Click += pfp_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(9, 377);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(342, 24);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(211, 476);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(99, 33);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChooseImage.Location = new Point(348, 266);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(139, 33);
            btnChooseImage.TabIndex = 2;
            btnChooseImage.Text = "ChooseImages";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // btnCloseAll
            // 
            btnCloseAll.BackColor = Color.Transparent;
            btnCloseAll.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseAll.ForeColor = Color.Black;
            btnCloseAll.Location = new Point(510, -2);
            btnCloseAll.Name = "btnCloseAll";
            btnCloseAll.Size = new Size(43, 31);
            btnCloseAll.TabIndex = 8;
            btnCloseAll.Text = "X";
            btnCloseAll.UseVisualStyleBackColor = false;
            btnCloseAll.Click += btnCloseAll_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.output_onlinepngtools;
            ClientSize = new Size(551, 521);
            Controls.Add(btnCloseAll);
            Controls.Add(dateTimePicker1);
            Controls.Add(pfp);
            Controls.Add(btnSave);
            Controls.Add(btnReset);
            Controls.Add(btnChooseImage);
            Controls.Add(btnExit);
            Controls.Add(txtDiaChi);
            Controls.Add(label8);
            Controls.Add(txtTen);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(txtTenHo);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserForm";
            Text = "MainForm";
            Load += EmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)pfp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTenHo;
        private Button btnExit;
        private Button btnReset;
        private Label label2;
        private TextBox txtTen;
        private Label label7;
        private Label label8;
        private TextBox txtDiaChi;
        private Label label9;
        private Label label3;
        private TextBox txtID;
        private PictureBox pfp;
        private DateTimePicker dateTimePicker1;
        private Button btnSave;
        private Button btnChooseImage;
        private Button btnCloseAll;
    }
}