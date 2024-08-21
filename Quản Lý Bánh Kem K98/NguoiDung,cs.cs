using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Quản_Lý_Quán_Bánh_Kem_K98
{
    internal class NguoiDung
    {
        private string hoten, taikhoan, matkhau;
        // Hàm khởi tạo mặc định không có tham số
        public NguoiDung()
        {
            hoten = taikhoan = matkhau = "";
        }
        public NguoiDung(string ten, string tk, string mk)
        {
            hoten = ten;
            taikhoan = tk;
            matkhau = mk;
        }
        public bool KiemTraDinhDangMatKhau() // Tối thiểu 7 ký tự và có cả chữ & số
        {
            if (matkhau.Length < 7)
            {
                return false;
            }
            // Kiểm tra có cả chữ và số
            bool KiemTraChu = false; // coi như chưa có chữ
            bool KiemTraSo = false; // coi như chưa có số
            for (int i = 0; i < matkhau.Length; ++i)
            {
                if (KiemTraChu == true && KiemTraSo == true)
                {
                    break; // Dừng vòng lặp lại
                }
                // A -> Z: Bắt đầu 65
                // a -> z: Bắt đầu 97
                if ((matkhau[i] >= 'A' && matkhau[i] <= 'Z') || (matkhau[i] >= 'a' && matkhau[i] <= 'z'))
                {
                    KiemTraChu = true;
                }
                if (matkhau[i] >= '0' && matkhau[i] <= '9')
                //if(Char.IsDigit(matkhau[i]))
                {
                    KiemTraSo = true;
                }
            }
            if (KiemTraSo == false || KiemTraChu == false)
            {
                return false; // không hợp lệ
            }
            return true; // hoàn toàn hợp lệ
        }
        public string ChuanHoaHoTen()
        {
            hoten = hoten.Trim(); // Bỏ khoảng trắng đầu và cuối chuỗi
            // Nếu phát hiện 2 khoảng trắng trùng nhau liên tiếp thì xóa đi 1
            for (int i = 0; i < hoten.Length; ++i)
            {
                if (hoten[i] == ' ' && hoten[i + 1] == ' ')
                {
                    // "Lê-_-Thanh"
                    hoten = hoten.Remove(i, 1);
                    i--;
                }
            }
            hoten = hoten.ToLower();
            // "le thanh"
            // a --> A (a: 97, A: 65)
            // In hoa ký tự đầu tiên
            char c = hoten[0];
            hoten = hoten.Remove(0, 1);
            hoten = hoten.Insert(0, c.ToString().ToUpper());
            // Xử lý in hoa ký tự đầu mỗi từ sau khoảng trắng
            for (int i = 1; i < hoten.Length; ++i)
            {
                if (hoten[i] == ' ') // i + 1 sẽ viết hoa
                {
                    char c1 = hoten[i + 1]; 
                    hoten = hoten.Remove(i + 1, 1);
                    hoten = hoten.Insert(i + 1, c1.ToString().ToUpper());
                }
            }
            return hoten;
        }
    }
}
