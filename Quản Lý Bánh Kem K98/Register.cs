using System.Data.SqlClient;

namespace Quản_Lý_Quán_Bánh_Kem_K98
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=WIN-NEQ19HH3LO5\SQLEXPRESS;Initial Catalog=QLyBanhKemK98;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
            this.OpenLogin.Click += new System.EventHandler(this.OpenLogin_Click);
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNhapLaiMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (checkPassword.Checked)
            {
                txtMatKhau.PasswordChar = '\0'; // Hiển thị mật khẩu
                txtNhapLaiMatKhau.PasswordChar = '\0'; // Hiển thị mật khẩu xác nhận
            }
            else
            {
                txtMatKhau.PasswordChar = '*'; // Ẩn mật khẩu
                txtNhapLaiMatKhau.PasswordChar = '*'; // Ẩn mật khẩu xác nhận
            }
        }
        private void txtNhapLaiMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text != txtNhapLaiMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu phải giống nhau");
                txtNhapLaiMatKhau.Focus();
                txtNhapLaiMatKhau.SelectAll();
                Check = false;
            }
        }

        private void txtNhapLaiMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                Check = true; // Để có thể reset lại là true mỗi lần chạy lại khi nhấn Enter
                txtNhapLaiMatKhau_Leave(sender, e);
                //MessageBox.Show(Check.ToString());
                if (Check == true)
                {
                    btnDangKy.PerformClick(); // Gọi lại sự kiện click của Button đăng ký
                }
            }
        }


        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào tài khoản");
                txtTenDangNhap.Focus(); // Đưa con trỏ chuột về lại
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            NguoiDung nd = new NguoiDung(txtHoTen.Text, txtTenDangNhap.Text, txtMatKhau.Text);
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào mật khẩu");
                txtMatKhau.Focus(); // Đưa con trỏ chuột về lại ô mật khẩu
            }
            else if (nd.KiemTraDinhDangMatKhau() == false)
            {
                MessageBox.Show("Mật khẩu sai định dạng");
                txtMatKhau.Focus();
                txtMatKhau.SelectAll();
            }
        }
        bool Check;

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            NguoiDung nd = new NguoiDung(txtHoTen.Text, txtTenDangNhap.Text, txtMatKhau.Text);
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Bạn chưa nhập vào tài khoản.");
                txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Bạn chưa nhập vào mật khẩu.");
                txtMatKhau.Focus();
                return;
            }
            else if (!nd.KiemTraDinhDangMatKhau())
            {
                MessageBox.Show("Mật khẩu không đạt yêu cầu (ít nhất 7 ký tự và bao gồm cả chữ và số).");
                txtMatKhau.Focus();
                txtMatKhau.SelectAll();
                return;
            }

            if (txtMatKhau.Text != txtNhapLaiMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.");
                txtNhapLaiMatKhau.Focus();
                txtNhapLaiMatKhau.SelectAll();
                return;
            }

            using (SqlConnection ketnoi = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO DANGNHAP (TenDn, HoTen, MatKhau) VALUES (@tk, @ht, @mk)";
                SqlCommand cm = new SqlCommand(sql, ketnoi);
                cm.Parameters.AddWithValue("@tk", txtTenDangNhap.Text);
                cm.Parameters.AddWithValue("@ht", txtHoTen.Text);
                cm.Parameters.AddWithValue("@mk", txtMatKhau.Text);

                try
                {
                    ketnoi.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Đăng ký tài khoản thành công");
                    this.Hide();
                    Login login = new Login();
                    login.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đăng ký không thành công! Lỗi: " + ex.Message);
                }
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }
        private bool isPasswordVisible = false;
        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtMatKhau.PasswordChar = isPasswordVisible ? '\0' : '*';
            txtNhapLaiMatKhau.PasswordChar = isPasswordVisible ? '\0' : '*';
            checkPassword.Text = isPasswordVisible ? "Hide Password" : "Show Password";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Xóa nội dung của tất cả các trường
            txtHoTen.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtNhapLaiMatKhau.Text = "";

            // Đặt lại trạng thái cho các điều khiển nếu cần
            checkPassword.Checked = false;
            txtMatKhau.PasswordChar = '*';
            txtNhapLaiMatKhau.PasswordChar = '*';

            // Đưa con trỏ chuột về ô nhập tài khoản hoặc bất kỳ ô nào bạn muốn
            txtHoTen.Focus();
        }
        private Login loginForm;
        private void OpenLogin_Click(object sender, EventArgs e)
        {
            if (loginForm != null && !loginForm.IsDisposed && loginForm.Visible)
            {
                loginForm.BringToFront();
                return;
            }

            // Tạo một instance mới của form Login
            loginForm = new Login();
            loginForm.FormClosed += (s, args) => this.Show(); // Hiển thị lại form chính khi form Login đóng

            this.Hide(); // Ẩn form chính
            loginForm.Show();
        }

        private void btnCloseAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng tất cả các form?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (Form openForm in Application.OpenForms)
                {
                    openForm.Close();
                }
                this.Close();
            }
        }
    }
}
