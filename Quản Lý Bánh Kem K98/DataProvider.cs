using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Quản_Lý_Quán_Bánh_Kem_K98
{
    internal class DataProvider
    {
        // Connection String thiết lập các thông số để kết nối.
        static string cnStr = @"Data Source=admin\LAPTOP-22RF98LR;Initial Catalog=SQLQLyBKK98;Integrated Security=True;";
        // Tạo kết nối
        static SqlConnection cn;
        static public DataTable LoadCSDL(string sql)
        {
            DataTable dt = new DataTable();//Khởi tạo một datatable để lưu dữ liệu
            cn = new SqlConnection(cnStr);//Khởi tạo 1 kết nối
            SqlCommand cm = new SqlCommand(sql, cn);//Tạo các lệnh
            SqlDataAdapter da = new SqlDataAdapter(cm);//Thực thi những lệnh được truyền từ SqlCommand
            da.Fill(dt);//Đổ dữ liệu từ DataAdapter vào Datatable
            return dt;
        }
        static public DataSet LoadCSDLDTS(string sql)
        {
            DataSet dts = new DataSet();//Khởi tạo một datatable để lưu dữ liệu
            cn = new SqlConnection(cnStr);//Khởi tạo 1 kết nối
            SqlCommand cm = new SqlCommand(sql, cn);//Tạo các lệnh
            SqlDataAdapter da = new SqlDataAdapter(cm);//Thực thi những lệnh được truyền từ SqlCommand
            da.Fill(dts);//Đổ dữ liệu từ DataAdapter vào Datatable trong Dataset
            return dts;
        }
        //insert, update, delete
        static public int Change(string sql)
        {
            cn = new SqlConnection(cnStr);
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            SqlCommand cm = new SqlCommand(sql, cn);
            int kq = cm.ExecuteNonQuery();// trả về số dòng bị thay đổi
            cn.Close();
            return kq;
        }
    }
}
