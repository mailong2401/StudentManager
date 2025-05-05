using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class UserControlUDShow : UserControl
    {
        private class UniversityDepartment
        {
            string id;
            string Name;

            public UniversityDepartment()
            {
                id = "";
                Name = "";
            }
            public UniversityDepartment(string id, string name)
            {
                this.id = id;
                Name = name;
            }
            public string getId() { return id; }
            public string getName() { return Name; }
        }
        private List<UniversityDepartment> _universities = new List<UniversityDepartment>();
        // Chuỗi kết nối SQLite
        string connectionString = "Data Source=mydb.sqlite;Version=3;";
        int indexCurrentTable = 1;
        public UserControlUDShow()
        {
            InitializeComponent();
            LoadAllBranches(); // Gọi hàm khi control được tạo
            createTable();
        }

        private void btnConfirmOfUDAdd_Click_1(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(inputNameKhoa.Text) && !string.IsNullOrWhiteSpace(inputidKhoa.Text))
            {
                string nameKhoa = inputNameKhoa.Text;
                string idKhoa = inputidKhoa.Text;
                try
                {
                    InsertKhoa(idKhoa, nameKhoa);
                    MessageBox.Show("Thêm khoa thành công!");
                    inputidKhoa.Text = "";
                    inputNameKhoa.Text = "";
                    LoadAllBranches();
                    createTable();
                }
                catch (SQLiteException ex)
                {
                    if (ex.ErrorCode == (int)SQLiteErrorCode.Constraint)
                    {
                        MessageBox.Show("Mã khoa đã tồn tại!");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi cơ sở dữ liệu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhập thiếu thông tin");
            }

        }
        public void InsertKhoa(string maKhoa, string tenKhoa)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=mydb.sqlite;Version=3;"))
            {
                conn.Open();
                string query = "INSERT INTO Khoa (maKhoa, tenKhoa) VALUES (@maKhoa, @tenKhoa)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maKhoa", maKhoa);
                    cmd.Parameters.AddWithValue("@tenKhoa", tenKhoa);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void LoadAllBranches()
        {
            // Xóa danh sách _universities để tránh trùng lặp dữ liệu
            _universities.Clear();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Khoa"; // Đảm bảo bảng 'Khoa' có tồn tại

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string maKhoa = reader["maKhoa"].ToString();
                        string tenKhoa = reader["tenKhoa"].ToString();
                        UniversityDepartment temp = new UniversityDepartment(maKhoa, tenKhoa);
                        _universities.Add(temp);
                    }
                }
            }

            // Gọi createTable sau khi dữ liệu đã được tải xong
            createTable();
        }

        private void createTable()
        {
            // Xóa các control cũ trước khi thêm mới (nếu cần load lại nhiều lần)
            tablekhoa.Controls.Clear();

            // 24
            // 1  2  3  4  5  6  7  8  9  10 11 12
            // 13 14 15 16 17 18 19 20 21 22 23 24
            // max 30
            // 2 * 12 + 11 = 
            int indexMax = indexCurrentTable * 12 + 11;
            if (indexCurrentTable * 12 + 11 > _universities.Count - 1)
            {
                indexMax = _universities.Count - 1;
            }
            for (int i = indexMax; i >= indexCurrentTable * 12; i--)
            {

                var universityDe = _universities[i];
                // Tạo control UIItemUniversityDepartment
                UIItemUniversityDepartment uIItemBranch = new UIItemUniversityDepartment();
                uIItemBranch.Dock = DockStyle.Top;

                // Thiết lập dữ liệu
                uIItemBranch.setItem(universityDe.getId(), universityDe.getName());

                // Thêm vào Panel (hoặc FlowLayoutPanel)
                tablekhoa.Controls.Add(uIItemBranch);
                uIItemBranch.BringToFront(); // Đảm bảo thứ tự từ trên xuống
            }
        }



        private void inputidKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void page1_Click(object sender, EventArgs e)
        {
            this.indexCurrentTable = 0;
            LoadAllBranches();
            createTable();
        }

        private void page2_Click(object sender, EventArgs e)
        {
            this.indexCurrentTable = 1;
            LoadAllBranches();
            createTable();
        }

        private void page3_Click(object sender, EventArgs e)
        {
            this.indexCurrentTable = 2;
            LoadAllBranches();
            createTable();
        }
    }
}
