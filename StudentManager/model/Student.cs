using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.model
{
    public class Student
    {
        public int MSSV { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string MaLop { get; set; }

        public Student() { }

        public Student(int mssv, string hoTen, string ngaySinh, string gioiTinh,
                        string diaChi, string soDienThoai, string maLop)
        {
            MSSV = mssv;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            MaLop = maLop;
        }
    }
}
