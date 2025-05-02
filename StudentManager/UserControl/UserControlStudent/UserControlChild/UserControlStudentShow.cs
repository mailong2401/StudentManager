using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using StudentManager.Data;

namespace StudentManager
{
    public partial class UserControlStudentShow : UserControl
    {
        
        private List<Student> students = new List<Student>();

        public UserControlStudentShow()
        {
            InitializeComponent();
            GetStudentsFromDatabase();
            LoadTable();
        }

        private void GetStudentsFromDatabase()
        {
            string connectionString = "Data Source=WINDOWS-PC\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True;";
            //string connectionString = "Server=localhost;Database=qlsv;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT MSSV, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, MaLop FROM SinhVien", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var student = new Student
                            {
                                MSSV = reader["MSSV"].ToString(),
                                HoTen = reader["HoTen"].ToString(),
                                NgaySinh = Convert.ToDateTime(reader["NgaySinh"]),
                                GioiTinh = reader["GioiTinh"].ToString(),
                                DiaChi = reader["DiaChi"].ToString(),
                                SoDienThoai = reader["SoDienThoai"].ToString(),
                                MaLop = reader["MaLop"].ToString()
                            };
                            students.Add(student);
                        }
                    }
                }
            }
        }

        private void LoadTable()
        {
            foreach (var student in students)
            {
                AddTable(student.MSSV, student.HoTen, student.NgaySinh.ToString("dd/MM/yyyy"),
                         student.GioiTinh, student.DiaChi, student.SoDienThoai, student.MaLop);
            }
        }

        private void AddTable(string id, string name, string date, string gender, string address, string phone, string className)
        {
            UIitemStudent it = new UIitemStudent();
            it.Dock = DockStyle.Top;
            it.setItem(id, name, date, gender, address, phone, className);
            tableLayoutPanel1.Controls.Add(it);
        }
    }
}