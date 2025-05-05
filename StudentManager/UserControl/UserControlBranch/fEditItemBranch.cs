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
    public partial class fEditItemBranch : Form
    {
        public fEditItemBranch()
        {
            InitializeComponent();
            
        }
        private void LoadKhoaData()
        {
            // Chuỗi kết nối tới cơ sở dữ liệu SQLite
            string connectionString = "Data Source=mydb.sqlite;Version=3;";

            // Câu lệnh SQL để lấy dữ liệu
            string query = "SELECT maKhoa FROM Khoa";

            // Mở kết nối và thực hiện truy vấn
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        SQLiteDataReader reader = cmd.ExecuteReader();

                        // Xóa hết các item cũ trong ComboBox (nếu có)
                        inputkhoa.Items.Clear();

                        // Đọc dữ liệu và thêm vào ComboBox
                        while (reader.Read())
                        {
                            // Thêm tên khoa vào ComboBox
                            string maKhoa = reader["maKhoa"].ToString();
                            inputkhoa.Items.Add(maKhoa);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        public fEditItemBranch(string id, string name,string khoa)
        {
            InitializeComponent();
            
            LoadKhoaData();
            this.inputidNganh.Text = id;
            this.inputNameNganh.Text = name;  // <-- sửa ở đây
            this.inputkhoa.SelectedItem = khoa;
        }
    }
}
