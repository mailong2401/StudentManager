using StudentManager.DAO;
using StudentManager.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class UserControlStatistic : UserControl
    {
        public UserControlStatistic()
        {
            InitializeComponent();
            loadThongKe();
        }

        void loadThongKe()
        {
            // Lấy danh sách tất cả sinh viên từ CSDL
            List<Student> students = StudentDAO.GetAll();

            // Tính tổng số sinh viên
            int tongSoSV = students.Count;

            // Đếm số sinh viên nữ
            int tongSoNu = students.Count(sv => sv.GioiTinh == "Nữ");

            // Đếm số sinh viên nam
            int tongSoNam = students.Count(sv => sv.GioiTinh == "Nam");

            // Gán dữ liệu lên các Label
            labelNam.Text = tongSoNam.ToString();
            labelNu.Text = tongSoNu.ToString();
            labelTong.Text = tongSoSV.ToString();
            // Vẽ biểu đồ tròn (pie chart) với số lượng Nam và Nữ
            parrotPieGraph1.Numbers = new List<int> { tongSoNam, tongSoNu };
        }
    }
}