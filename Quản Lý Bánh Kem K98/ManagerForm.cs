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
    public partial class ManagerForm : Form
    {
        private string chuoiketnoi = @"Data Source=LAPTOP-22RF98LR;Initial Catalog=QLyBanhKemK98;Integrated Security=True";
        public ManagerForm()
        {
            InitializeComponent();
            listPosition.Items.Add("guest");
            listPosition.Items.Add("employee");
            listPosition.Items.Add("manager");
            LoadAccountData(); // Gọi phương thức để tải dữ liệu khi form được khởi tạo
        }
        private void LoadAccountData()
        {
            using (SqlConnection ketnoi = new SqlConnection(chuoiketnoi))
            {
                string sql = @"SELECT NhanVien.ID, NhanVien.TenHo, NhanVien.Ten, NhanVien.DiaChi, 
                          NhanVien.NgaySinh, NhanVien.ViTri, NhanVien.Anh, DANGNHAP.TenDn, 
                          DANGNHAP.HoTen
                   FROM NhanVien
                   INNER JOIN DANGNHAP ON NhanVien.TenDN = DANGNHAP.TenDn";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, ketnoi);
                DataTable dt = new DataTable();

                try
                {
                    adapter.Fill(dt);
                    Accountdata.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
                }
            }
        }
        private void Accountdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Accountdata.Rows[e.RowIndex];

                // Đưa dữ liệu từ hàng được chọn vào các ô nhập liệu
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtUsername.Text = row.Cells["TenDn"].Value.ToString();
                txtTenHo.Text = row.Cells["TenHo"].Value.ToString();
                txtTen.Text = row.Cells["Ten"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                dateBirthday.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                listPosition.SelectedItem = row.Cells["ViTri"].Value.ToString();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = SearchBar.Text.Trim().ToLower();

            // Kiểm tra xem có nhập giá trị tìm kiếm không
            if (string.IsNullOrEmpty(searchValue))
            {
                // Nếu không có giá trị tìm kiếm, tải lại tất cả dữ liệu
                LoadAccountData();
                return;
            }
            // Lọc dữ liệu trong DataGridView
            (Accountdata.DataSource as DataTable).DefaultView.RowFilter = $"HoTen LIKE '%{searchValue}%'";
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào tài khoản");
                txtUsername.Focus(); // Đưa con trỏ chuột về lại
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            NguoiDung nd = new NguoiDung(txtHoTen.Text, txtUsername.Text, txtMatKhau.Text);
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

        private void listPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateBirthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();

            // Đóng form quản lý
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn trong DataGridView không
            if (Accountdata.SelectedRows.Count > 0)
            {
                // Lấy mã ID của hàng đang được chọn (cột ID là cột đầu tiên)
                string selectedID = Accountdata.SelectedRows[0].Cells["ID"].Value.ToString();

                // Tạo chuỗi kết nối
                using (SqlConnection ketnoi = new SqlConnection(chuoiketnoi))
                {
                    try
                    {
                        // Mở kết nối
                        ketnoi.Open();

                        // Tạo câu lệnh SQL để xóa dữ liệu từ bảng NhanVien dựa trên ID
                        string sql = "DELETE FROM NhanVien WHERE ID = @ID";

                        // Tạo SqlCommand
                        using (SqlCommand cmd = new SqlCommand(sql, ketnoi))
                        {
                            // Thêm tham số vào câu lệnh SQL
                            cmd.Parameters.AddWithValue("@ID", selectedID);

                            // Thực thi câu lệnh
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Tải lại dữ liệu sau khi xóa
                                LoadAccountData();
                            }
                            else
                            {
                                MessageBox.Show("Xóa dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            string tenDN = txtUsername.Text.Trim();
            string hoTen = txtTenHo.Text.Trim();
            string ten = txtTen.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            DateTime ngaySinh = dateBirthday.Value;
            string viTri = listPosition.SelectedItem?.ToString() ?? string.Empty;
            string hinhAnh = ""; // Bạn có thể thêm logic để lấy đường dẫn hoặc byte[] của hình ảnh

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(tenDN) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(viTri))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem tài khoản đã tồn tại trong bảng DANGNHAP chưa
            using (SqlConnection ketnoi = new SqlConnection(chuoiketnoi))
            {
                try
                {
                    ketnoi.Open();

                    // Tạo câu lệnh SQL để kiểm tra tài khoản
                    string checkAccountSql = "SELECT COUNT(*) FROM DANGNHAP WHERE TenDn = @TenDn";

                    using (SqlCommand checkCmd = new SqlCommand(checkAccountSql, ketnoi))
                    {
                        checkCmd.Parameters.AddWithValue("@TenDn", tenDN);

                        int count = (int)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("Thêm thông tin thất bại, tài khoản không tồn tại, vui lòng tạo tài khoản trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Nếu tài khoản tồn tại, thực hiện thêm thông tin vào bảng NhanVien
                    string sql = @"INSERT INTO NhanVien (ID, TenDN, TenHo, Ten, DiaChi, NgaySinh, ViTri, Anh)
                           VALUES (@ID, @TenDN, @TenHo, @Ten, @DiaChi, @NgaySinh, @ViTri, @Anh)";

                    using (SqlCommand cmd = new SqlCommand(sql, ketnoi))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.Parameters.AddWithValue("@TenDN", tenDN);
                        cmd.Parameters.AddWithValue("@TenHo", hoTen);
                        cmd.Parameters.AddWithValue("@Ten", ten);
                        cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                        cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        cmd.Parameters.AddWithValue("@ViTri", viTri);
                        cmd.Parameters.AddWithValue("@Anh", hinhAnh); // Lưu ý: Bạn cần thay đổi logic để lưu hình ảnh nếu cần thiết

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Có thể gọi phương thức LoadAccountData() để tải lại dữ liệu sau khi thêm mới
                            LoadAccountData();
                        }
                        else
                        {
                            MessageBox.Show("Thêm dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
                }
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string tenDn = txtUsername.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(tenDn) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection ketnoi = new SqlConnection(chuoiketnoi))
            {
                try
                {
                    ketnoi.Open();
                    string sql = @"INSERT INTO DANGNHAP (TenDn, HoTen, MatKhau)
                           VALUES (@TenDn, @HoTen, @MatKhau)";

                    using (SqlCommand cmd = new SqlCommand(sql, ketnoi))
                    {
                        cmd.Parameters.AddWithValue("@TenDn", tenDn);
                        cmd.Parameters.AddWithValue("@HoTen", hoTen);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnAdd.Enabled = true; // Enable the Add Employee button
                        }
                        else
                        {
                            MessageBox.Show("Tạo tài khoản thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tạo tài khoản: " + ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Accountdata.SelectedRows.Count > 0)
            {
                // Lấy mã ID của hàng đang được chọn (cột ID là cột đầu tiên)
                string selectedID = Accountdata.SelectedRows[0].Cells["ID"].Value.ToString();

                // Lấy thông tin từ các ô nhập liệu
                string tenDN = txtUsername.Text.Trim();
                string hoTen = txtTenHo.Text.Trim();
                string ten = txtTen.Text.Trim();
                string diaChi = txtDiaChi.Text.Trim();
                DateTime ngaySinh = dateBirthday.Value;
                string viTri = listPosition.SelectedItem?.ToString() ?? string.Empty;

                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrEmpty(tenDN) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(viTri))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo chuỗi kết nối
                using (SqlConnection ketnoi = new SqlConnection(chuoiketnoi))
                {
                    try
                    {
                        // Mở kết nối
                        ketnoi.Open();

                        // Tạo câu lệnh SQL để cập nhật dữ liệu vào bảng NhanVien
                        string sql = @"UPDATE NhanVien
                               SET TenDN = @TenDN,
                                   TenHo = @TenHo,
                                   Ten = @Ten,
                                   DiaChi = @DiaChi,
                                   NgaySinh = @NgaySinh,
                                   ViTri = @ViTri
                               WHERE ID = @ID";

                        // Tạo SqlCommand
                        using (SqlCommand cmd = new SqlCommand(sql, ketnoi))
                        {
                            // Thêm các tham số vào câu lệnh SQL
                            cmd.Parameters.AddWithValue("@ID", selectedID);
                            cmd.Parameters.AddWithValue("@TenDN", tenDN);
                            cmd.Parameters.AddWithValue("@TenHo", hoTen);
                            cmd.Parameters.AddWithValue("@Ten", ten);
                            cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                            cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                            cmd.Parameters.AddWithValue("@ViTri", viTri);

                            // Thực thi câu lệnh
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Có thể gọi phương thức LoadAccountData() để tải lại dữ liệu sau khi cập nhật
                                LoadAccountData();
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
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

        private void btnTotal_Click(object sender, EventArgs e)
        {
            this.Hide();
            totalForm totalForm = new totalForm();
            totalForm.Show();
        }
    }
}
