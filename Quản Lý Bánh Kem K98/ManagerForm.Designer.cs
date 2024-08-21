namespace Quản_Lý_Quán_Bánh_Kem_K98
{
    partial class ManagerForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Accountdata = new DataGridView();
            btnAdd = new Button();
            label2 = new Label();
            txtHoTen = new TextBox();
            txtUsername = new TextBox();
            txtMatKhau = new TextBox();
            txtDiaChi = new TextBox();
            txtID = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label1 = new Label();
            txtTen = new TextBox();
            label9 = new Label();
            SearchBar = new TextBox();
            dateBirthday = new DateTimePicker();
            label6 = new Label();
            listPosition = new ListBox();
            label10 = new Label();
            btnDelete = new Button();
            btnExit = new Button();
            label11 = new Label();
            label12 = new Label();
            btnSearch = new Button();
            txtTenHo = new TextBox();
            btnAddAccount = new Button();
            btnEdit = new Button();
            btnCloseAll = new Button();
            btnTotal = new Button();
            label13 = new Label();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)Accountdata).BeginInit();
            SuspendLayout();
            // 
            // Accountdata
            // 
            Accountdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Accountdata.Location = new Point(17, 380);
            Accountdata.Name = "Accountdata";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Accountdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            Accountdata.RowHeadersWidth = 51;
            Accountdata.Size = new Size(1101, 221);
            Accountdata.TabIndex = 0;
            Accountdata.CellContentClick += Accountdata_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(477, 261);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(189, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Info";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("FOT-Yuruka Std UB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(477, 306);
            label2.Name = "label2";
            label2.Size = new Size(192, 32);
            label2.TabIndex = 2;
            label2.Text = "Account board";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHoTen.Location = new Point(133, 54);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(181, 37);
            txtHoTen.TabIndex = 4;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(476, 56);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(190, 37);
            txtUsername.TabIndex = 4;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(803, 56);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(324, 37);
            txtMatKhau.TabIndex = 4;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDiaChi.Location = new Point(803, 156);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(324, 37);
            txtDiaChi.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtID.Location = new Point(133, 201);
            txtID.Name = "txtID";
            txtID.Size = new Size(181, 37);
            txtID.TabIndex = 4;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("FOT-Yuruka Std UB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(-2, 59);
            label3.Name = "label3";
            label3.Size = new Size(90, 32);
            label3.TabIndex = 2;
            label3.Text = "Names";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("FOT-Yuruka Std UB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(334, 54);
            label4.Name = "label4";
            label4.Size = new Size(132, 32);
            label4.TabIndex = 2;
            label4.Text = "UserName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("FOT-Yuruka Std UB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(672, 59);
            label5.Name = "label5";
            label5.Size = new Size(121, 32);
            label5.TabIndex = 2;
            label5.Text = "Password";
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("FOT-Yuruka Std UB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(672, 161);
            label7.Name = "label7";
            label7.Size = new Size(106, 32);
            label7.TabIndex = 2;
            label7.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("FOT-Yuruka Std UB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(-2, 206);
            label8.Name = "label8";
            label8.Size = new Size(41, 32);
            label8.TabIndex = 2;
            label8.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("FOT-Yuruka Std UB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(334, 156);
            label1.Name = "label1";
            label1.Size = new Size(136, 32);
            label1.TabIndex = 2;
            label1.Text = "Last Name";
            // 
            // txtTen
            // 
            txtTen.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTen.Location = new Point(476, 156);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(190, 37);
            txtTen.TabIndex = 4;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("FOT-Yuruka Std UB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(-2, 156);
            label9.Name = "label9";
            label9.Size = new Size(139, 32);
            label9.TabIndex = 2;
            label9.Text = "First Name";
            // 
            // SearchBar
            // 
            SearchBar.BackColor = Color.Gray;
            SearchBar.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBar.ForeColor = Color.Transparent;
            SearchBar.Location = new Point(194, 341);
            SearchBar.Name = "SearchBar";
            SearchBar.Size = new Size(327, 37);
            SearchBar.TabIndex = 4;
            SearchBar.TextChanged += SearchBar_TextChanged;
            // 
            // dateBirthday
            // 
            dateBirthday.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateBirthday.Location = new Point(803, 206);
            dateBirthday.Name = "dateBirthday";
            dateBirthday.Size = new Size(324, 37);
            dateBirthday.TabIndex = 6;
            dateBirthday.ValueChanged += dateBirthday_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("FOT-Yuruka Std UB", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(681, 210);
            label6.Name = "label6";
            label6.Size = new Size(106, 28);
            label6.TabIndex = 5;
            label6.Text = "Birthday";
            // 
            // listPosition
            // 
            listPosition.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listPosition.FormattingEnabled = true;
            listPosition.ItemHeight = 24;
            listPosition.Location = new Point(476, 203);
            listPosition.Name = "listPosition";
            listPosition.Size = new Size(190, 52);
            listPosition.TabIndex = 8;
            listPosition.SelectedIndexChanged += listPosition_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("FOT-Yuruka Std UB", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(334, 210);
            label10.Name = "label10";
            label10.Size = new Size(98, 28);
            label10.TabIndex = 7;
            label10.Text = "Position";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(871, 349);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(1024, 349);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Black;
            label11.Font = new Font("FOT-Yuruka Std UB", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 128);
            label11.ForeColor = Color.Transparent;
            label11.Location = new Point(415, 9);
            label11.Name = "label11";
            label11.Size = new Size(335, 32);
            label11.TabIndex = 2;
            label11.Text = "USER ACCOUNT MANAGER";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("FOT-Yuruka Std UB", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(22, 346);
            label12.Name = "label12";
            label12.Size = new Size(174, 28);
            label12.TabIndex = 7;
            label12.Text = "Data Searching";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(527, 345);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(123, 33);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtTenHo
            // 
            txtTenHo.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTenHo.Location = new Point(133, 156);
            txtTenHo.Name = "txtTenHo";
            txtTenHo.Size = new Size(181, 37);
            txtTenHo.TabIndex = 4;
            txtTenHo.TextChanged += txtTenHo_TextChanged;
            // 
            // btnAddAccount
            // 
            btnAddAccount.BackColor = Color.Transparent;
            btnAddAccount.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddAccount.Location = new Point(476, 111);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(190, 29);
            btnAddAccount.TabIndex = 3;
            btnAddAccount.Text = "Add Account";
            btnAddAccount.UseVisualStyleBackColor = false;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(722, 349);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 29);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCloseAll
            // 
            btnCloseAll.BackColor = Color.Transparent;
            btnCloseAll.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseAll.ForeColor = Color.Black;
            btnCloseAll.Location = new Point(1095, -1);
            btnCloseAll.Name = "btnCloseAll";
            btnCloseAll.Size = new Size(43, 31);
            btnCloseAll.TabIndex = 19;
            btnCloseAll.Text = "X";
            btnCloseAll.UseVisualStyleBackColor = false;
            btnCloseAll.Click += btnCloseAll_Click;
            // 
            // btnTotal
            // 
            btnTotal.Font = new Font("FOT-Yuruka Std UB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTotal.Location = new Point(527, 628);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(112, 29);
            btnTotal.TabIndex = 3;
            btnTotal.Text = "To Total";
            btnTotal.UseVisualStyleBackColor = true;
            btnTotal.Click += btnTotal_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("FOT-Yuruka Std UB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label13.Location = new Point(381, 615);
            label13.Name = "label13";
            label13.Size = new Size(154, 44);
            label13.TabIndex = 20;
            label13.Text = ">>>>>>>>>";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("FOT-Yuruka Std UB", 18F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label14.Location = new Point(639, 612);
            label14.Name = "label14";
            label14.Size = new Size(148, 47);
            label14.TabIndex = 20;
            label14.Text = "<<<<<<<<";
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.output_onlinepngtools;
            ClientSize = new Size(1138, 691);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(btnCloseAll);
            Controls.Add(listPosition);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(dateBirthday);
            Controls.Add(label6);
            Controls.Add(txtTenHo);
            Controls.Add(txtID);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTen);
            Controls.Add(SearchBar);
            Controls.Add(txtMatKhau);
            Controls.Add(txtUsername);
            Controls.Add(txtHoTen);
            Controls.Add(btnExit);
            Controls.Add(btnSearch);
            Controls.Add(btnTotal);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAddAccount);
            Controls.Add(btnAdd);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label11);
            Controls.Add(label2);
            Controls.Add(Accountdata);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManagerForm";
            Text = "ManagerForm";
            ((System.ComponentModel.ISupportInitialize)Accountdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataKhachHang;
        private DataGridView Accountdata;
        private Label label1;
        private Button btnAdd;
        private Label label2;
        private TextBox txtHoTen;
        private TextBox txtUsername;
        private TextBox txtMatKhau;
        private TextBox txtDiaChi;
        private TextBox txtID;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private TextBox txtTen;
        private Label label9;
        private TextBox SearchBar;
        private DateTimePicker dateBirthday;
        private Label label6;
        private ListBox listPosition;
        private Label label10;
        private Button btnDelete;
        private Button btnExit;
        private Label label11;
        private Label label12;
        private Button btnSearch;
        private TextBox txtTenHo;
        private Button btnAddAccount;
        private Button btnEdit;
        private Button btnCloseAll;
        private Button btnTotal;
        private Label label13;
        private Label label14;
    }
}