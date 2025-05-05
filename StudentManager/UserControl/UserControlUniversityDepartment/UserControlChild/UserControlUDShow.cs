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
        // Chuỗi kết nối SQLite
        string connectionString = "Data Source=mydb.sqlite;Version=3;";

        public UserControlUDShow()
        {
            InitializeComponent();
            LoadAllBranches(); // Gọi hàm khi control được tạo
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
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Khoa"; // Đảm bảo bảng 'Khoa' có tồn tại

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    // Xóa các control cũ trước khi thêm mới (nếu cần load lại nhiều lần)
                    tablekhoa.Controls.Clear();

                    while (reader.Read())
                    {
                        // Tạo control UIItemBranch
                        UIItemUniversityDepartment uIItemBranch = new UIItemUniversityDepartment();
                        uIItemBranch.Dock = DockStyle.Top;

                        // Thiết lập dữ liệu
                        string maKhoa = reader["maKhoa"].ToString();
                        string tenKhoa = reader["tenKhoa"].ToString();
                        uIItemBranch.setItem(maKhoa, tenKhoa);

                        // Thêm vào Panel (hoặc FlowLayoutPanel)
                        tablekhoa.Controls.Add(uIItemBranch);
                        uIItemBranch.BringToFront(); // Đảm bảo thứ tự từ trên xuống
                    }
                }
            }
        }

        private void inputidKhoa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
