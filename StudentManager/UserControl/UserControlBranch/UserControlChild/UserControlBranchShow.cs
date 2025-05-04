using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class UserControlBranchShow : UserControl
    {
        // Chuỗi kết nối SQLite
        string connectionString = "Data Source=mydb.sqlite;Version=3;";

        public UserControlBranchShow()
        {
            InitializeComponent();
            LoadAllBranches(); // Gọi hàm khi control được tạo
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
                    tbkhoa.Controls.Clear();

                    while (reader.Read())
                    {
                        // Tạo control UIItemBranch
                        UIItemBranch uIItemBranch = new UIItemBranch();
                        uIItemBranch.Dock = DockStyle.Top;

                        // Thiết lập dữ liệu
                        string maKhoa = reader["maKhoa"].ToString();
                        string tenKhoa = reader["tenKhoa"].ToString();
                        uIItemBranch.setItem(maKhoa, tenKhoa);

                        // Thêm vào Panel (hoặc FlowLayoutPanel)
                        tbkhoa.Controls.Add(uIItemBranch);
                        uIItemBranch.BringToFront(); // Đảm bảo thứ tự từ trên xuống
                    }
                }
            }
        }
    }
}
