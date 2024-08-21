using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Quán_Bánh_Kem_K98
{
    public partial class UserForm : Form
    {
        private string currentUser; // Lưu trữ tên đăng nhập của người dùng hiện tại
        public UserForm(string username)
        {
            InitializeComponent();
            listPosition.Items.Add("guest");
            listPosition.Items.Add("employee");
            listPosition.Items.Add("manager");
            currentUser = username; // Lưu tên đăng nhập khi khởi tạo form
            LoadEmployeeData(); // Nạp dữ liệu nhân viên khi mở form
        }
        private string connectionString = @"Data Source=LAPTOP-22RF98LR;Initial Catalog=QLyBanhKemK98;Integrated Security=True;";
        private bool IsEmployeeExist(string id, SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM dbo.NhanVien WHERE ID = @ID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", id);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                connection.Close();

                return count > 0;
            }
        }
        private void LoadEmployeeData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM dbo.NhanVien WHERE TenDN = @TenDN";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenDN", currentUser);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read()) // Nếu tìm thấy dữ liệu nhân viên
                    {
                        txtID.Text = reader["ID"].ToString();
                        txtTenHo.Text = reader["TenHo"].ToString();
                        txtTen.Text = reader["Ten"].ToString();
                        txtDiaChi.Text = reader["DiaChi"].ToString();
                        dateTimePicker1.Value = Convert.ToDateTime(reader["NgaySinh"]);
                        listPosition.SelectedItem = reader["ViTri"].ToString();

                        // Load image if available
                        string imagePath = reader["Anh"].ToString();
                        if (File.Exists(imagePath))
                        {
                            pfp.Image = Image.FromFile(imagePath);
                        }
                    }
                    else // Nếu không tìm thấy dữ liệu nhân viên
                    {
                        // Clear các trường để người dùng nhập mới
                        txtID.Clear();
                        txtTenHo.Clear();
                        txtTen.Clear();
                        txtDiaChi.Clear();
                        dateTimePicker1.Value = DateTime.Now;
                        listPosition.SelectedIndex = -1;
                        pfp.Image = null;
                    }
                }
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            // Chỉ giữ lại các ký tự số và đảm bảo chiều dài không vượt quá 13 ký tự
            string filteredText = new string(txtID.Text.Where(char.IsDigit).ToArray());

            if (filteredText.Length > 13)
            {
                filteredText = filteredText.Substring(0, 13);
            }

            if (txtID.Text != filteredText)
            {
                txtID.Text = filteredText;
                txtID.SelectionStart = txtID.Text.Length; // Đặt con trỏ về cuối chuỗi
            }
        }
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự không phải là số và không phải là phím điều khiển (như Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Hiển thị cảnh báo nếu người dùng nhập chữ
                MessageBox.Show("Không cho phép nhập chữ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Hủy bỏ ký tự nhập vào
                e.Handled = true;
            }

            // Giới hạn số ký tự được nhập
            if (txtID.Text.Length >= 13 && !char.IsControl(e.KeyChar))
            {
                // Hủy bỏ ký tự nhập vào nếu vượt quá 13 ký tự
                e.Handled = true;
            }
        }
        private void txtTenHo_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtTenHo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                // ngăn chặn việt nhập kí tự ko phù hợp vào
                e.Handled = true;
            }

            // giới hạn 50 từ
            if (txtTenHo.Text.Length >= 50 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                // ngăn chặn việt nhập kí tự ko phù hợp vào
                e.Handled = true;
            }

            // giới hạn 50 từ
            if (txtTen.Text.Length >= 50 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void pfp_Click(object sender, EventArgs e)
        {
            if (pfp.Image == null)
            {
                MessageBox.Show("Vui lòng chọn một ảnh trước!");
                return;
            }

            // Chuyển đổi ảnh thành byte array
            using (MemoryStream ms = new MemoryStream())
            {
                pfp.Image.Save(ms, pfp.Image.RawFormat);
                byte[] imageBytes = ms.ToArray();

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "INSERT INTO YourImageTable (ImageColumn) VALUES (@Image)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Image", imageBytes);

                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Ảnh đã được lưu thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Lưu ảnh thất bại.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadEmployeeData(); // Nạp dữ liệu nhân viên khi mở form
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string tenHo = txtTenHo.Text;
            string ten = txtTen.Text;
            string diaChi = txtDiaChi.Text;
            DateTime ngaySinh = dateTimePicker1.Value;
            string viTri = listPosition.SelectedItem.ToString();
            string anh = ""; // If you want to save the image path, you should handle it accordingly.

            string connectionString = @"Data Source=LAPTOP-22RF98LR;Initial Catalog=QLyBanhKemK98;Integrated Security=True;";

            string deleteQuery = "DELETE FROM NhanVien WHERE ID = @ID";
            string insertQuery = "INSERT INTO NhanVien (ID, TenDN, TenHo, Ten, DiaChi, NgaySinh, ViTri, Anh) " +
                                 "VALUES (@ID, @TenDN, @TenHo, @Ten, @DiaChi, @NgaySinh, @ViTri, @Anh)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Delete old employee information
                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection))
                {
                    deleteCmd.Parameters.AddWithValue("@ID", id);
                    deleteCmd.ExecuteNonQuery();
                }

                // Insert new employee information
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                {
                    insertCmd.Parameters.AddWithValue("@ID", id);
                    insertCmd.Parameters.AddWithValue("@TenDN", currentUser);
                    insertCmd.Parameters.AddWithValue("@TenHo", tenHo);
                    insertCmd.Parameters.AddWithValue("@Ten", ten);
                    insertCmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    insertCmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    insertCmd.Parameters.AddWithValue("@ViTri", viTri);
                    insertCmd.Parameters.AddWithValue("@Anh", anh);

                    insertCmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Cập nhật dữ liệu thành công!");

            // Reload data to reflect changes
            LoadEmployeeData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear all form fields
            txtID.Clear();
            txtTenHo.Clear();
            txtTen.Clear();
            txtDiaChi.Clear();
            listPosition.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            pfp.Image = null; // Or set a default image if needed

            // Optionally reload data if needed
            LoadEmployeeData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Chọn ảnh";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pfp.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
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
