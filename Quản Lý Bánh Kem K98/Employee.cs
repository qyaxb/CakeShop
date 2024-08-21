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
    public partial class Employee : Form
    {
        string connectionString = @"Data Source=WIN-NEQ19HH3LO5\SQLEXPRESS;Initial Catalog=QLyBanhKemK98;Integrated Security=True;";
        private string name;
        public Employee(string username)
        {
            InitializeComponent();
            name = username;
            txtUsername.Text = name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            
            string username = txtUsername.Text;
            DateTime checkInTime = DateTime.Now;
            string status = btnCheckIn.Text.ToString();

            // Câu lệnh SQL để chèn dữ liệu vào bảng CheckIn
            string query = "INSERT INTO dbo.CheckIn (TenDn, ThoiGian, Status) VALUES (@TenDn, @ThoiGian, @Status)";

            // Sử dụng SqlConnection và SqlCommand để thực hiện câu lệnh SQL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số vào câu lệnh SQL
                    command.Parameters.AddWithValue("@TenDn", username);
                    command.Parameters.AddWithValue("@ThoiGian", checkInTime);
                    command.Parameters.AddWithValue("@Status", status);
                    try
                    {
                        // Mở kết nối và thực hiện câu lệnh SQL
                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        // Kiểm tra xem lệnh có thành công không
                        if (result > 0)
                        {
                            
                            if (status == "Check In")
                            {
                                btnCheckIn.Text = "Check Out";
                                txtUsername.ReadOnly = true;
                            }
                            if (status == "Check Out")
                            {
                                btnCheckIn.Text = "Check In";
                                txtUsername.Text = "";
                                txtUsername.ReadOnly = false;
                            }
                            MessageBox.Show($"{status} thành công!");

                         
                        }
                        else
                        {

                            MessageBox.Show("Tên đăng nhập không tồn tại.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Xử lý lỗi
                        lbError.Text = ex.Message;

                    }
                }
            }

            

        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }
    }
}
