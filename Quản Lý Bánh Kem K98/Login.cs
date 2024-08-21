using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quản_Lý_Quán_Bánh_Kem_K98
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.ToRegister.Click += new System.EventHandler(this.ToRegister_Click);
        }

        private void btnTenDangNhap_Click(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=LAPTOP-22RF98LR;Initial Catalog=QLyBanhKemK98;Integrated Security=True";
            using (SqlConnection ketnoi = new SqlConnection(chuoiketnoi))
            {
                string tk = txtTenDangNhap.Text;
                string mk = txtMatKhau.Text;
                string sql = @"SELECT DANGNHAP.*, NhanVien.ViTri
                       FROM DANGNHAP
                       LEFT JOIN NhanVien ON DANGNHAP.TenDn = NhanVien.TenDN
                       WHERE DANGNHAP.TenDn = @tk AND DANGNHAP.MatKhau = @mk";
                SqlCommand cm = new SqlCommand(sql, ketnoi);
                cm.Parameters.AddWithValue("@tk", tk);
                cm.Parameters.AddWithValue("@mk", mk);

                try
                {
                    ketnoi.Open();
                    SqlDataReader read = cm.ExecuteReader();
                    if (read.Read())
                    {
                        string role = read["ViTri"] != DBNull.Value ? read["ViTri"].ToString() : string.Empty;
                        bool isOwnerChecked = ForOwnerChecker.Checked; // Assuming ForOwnerChecker is your checkbox

                        if (string.IsNullOrEmpty(role))
                        {
                            // Nếu chưa có vai trò, đưa người dùng vào EmployeeForm để nhập vai trò
                            this.Hide();
                            UserForm employeeForm = new UserForm(tk); // Pass username
                            employeeForm.Show();
                        }
                        else
                        {
                            // Redirect based on role and checkbox state
                            if (isOwnerChecked)
                            {
                                if (role == "manager")
                                {
                                    this.Hide();
                                    ManagerForm managerForm = new ManagerForm(); // Your ManagerForm here
                                    managerForm.Show();
                                }
                                else if (role == "employee")
                                {
                                    this.Hide();
                                    UserForm UserForm = new UserForm(tk); // Pass username
                                    UserForm.Show();
                                }
                                else if (role == "guest")
                                {
                                    this.Hide();
                                    ShopForm shopForm = new ShopForm();
                                    shopForm.Show();
                                }
                            }
                            else
                            {
                                if (role == "guest")
                                {
                                    this.Hide();
                                    ShopForm shopForm = new ShopForm();
                                    shopForm.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Chỉ có tài khoản là Guest mới có thể đăng nhập vào cửa hàng.");
                                    txtMatKhau.Text = "";
                                    txtTenDangNhap.Focus();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập không thành công");
                        txtMatKhau.Text = "";
                        txtTenDangNhap.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kết nối không thành công! Lỗi: " + ex.Message);
                }
            }
        }
        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private bool isPasswordVisible = false;
        private void CheckPassword_CheckedChanged(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtMatKhau.PasswordChar = isPasswordVisible ? '\0' : '*';
            CheckPassword.Text = isPasswordVisible ? "Hide Password" : "Show Password";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Xóa nội dung của tất cả các trường
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";

            // Đặt lại trạng thái cho các điều khiển nếu cần
            CheckPassword.Checked = false;
            txtMatKhau.PasswordChar = '*';
        }

        private void ToRegister_Click(object sender, EventArgs e)
        {
            Form1 registerForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (registerForm == null)
            {
                registerForm = new Form1();
                registerForm.Show();
            }
            else
            {
                registerForm.BringToFront();
            }
            this.Close();
        }

        private void ForOwnerChecker_CheckedChanged(object sender, EventArgs e)
        {

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
