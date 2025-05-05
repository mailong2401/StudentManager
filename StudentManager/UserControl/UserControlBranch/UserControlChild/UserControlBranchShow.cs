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
            LoadKhoaData();
        }
        private void LoadKhoaData()
        {
            // Chuỗi kết nối tới cơ sở dữ liệu SQLite
            string connectionString = "Data Source=mydb.sqlite;Version=3;";

            // Câu lệnh SQL để lấy dữ liệu
            string query = "SELECT tenKhoa FROM Khoa";

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
                        comboboxkhoa.Items.Clear();

                        // Đọc dữ liệu và thêm vào ComboBox
                        while (reader.Read())
                        {
                            // Thêm tên khoa vào ComboBox
                            string tenKhoa = reader["tenKhoa"].ToString();
                            comboboxkhoa.Items.Add(tenKhoa);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void LoadAllBranches()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Nganh"; // Đảm bảo bảng 'Khoa' có tồn tại

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    // Xóa các control cũ trước khi thêm mới (nếu cần load lại nhiều lần)
                    tbNganh.Controls.Clear();

                    while (reader.Read())
                    {
                        // Tạo control UIItemBranch
                        UIItemBranch uIItemBranch = new UIItemBranch();
                        uIItemBranch.Dock = DockStyle.Top;

                        // Thiết lập dữ liệu
                        string maNganh = reader["maNganh"].ToString();
                        string tenNganh = reader["tenNganh"].ToString();
                        string maKhoa = reader["maKhoa"].ToString();
                        uIItemBranch.setItem(maNganh, tenNganh, maKhoa);

                        // Thêm vào Panel (hoặc FlowLayoutPanel)
                        tbNganh.Controls.Add(uIItemBranch);
                        uIItemBranch.BringToFront(); // Đảm bảo thứ tự từ trên xuống
                    }
                }
            }
        }

        private void inputNameNganh_TextChanged(object sender, EventArgs e)
        {

        }

        public void InsertNgang(string maNganh, string tenNganh,string maKhoa)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=mydb.sqlite;Version=3;"))
            {
                conn.Open();
                string query = "INSERT INTO Nganh (maNganh, tenNganh, maKhoa) VALUES (@maNganh, @tenNganh, @maKhoa)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maNganh", maNganh);
                    cmd.Parameters.AddWithValue("@tenNganh", tenNganh);
                    cmd.Parameters.AddWithValue("@maKhoa", maKhoa);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnConfirmOfUDAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(inputNameNganh.Text) && !string.IsNullOrWhiteSpace(inputidNganh.Text))
            {
                string nameNganh = inputNameNganh.Text;
                string idNganh = inputidNganh.Text;
                string idKhoa = comboboxkhoa.SelectedItem.ToString();
                try
                {
                    InsertNgang(idNganh, nameNganh, idKhoa);
                    MessageBox.Show("Thêm khoa thành công!");
                    inputidNganh.Text = "";
                    inputNameNganh.Text = "";
                    LoadAllBranches();
                }
                catch (SQLiteException ex)
                {
                    if (ex.ErrorCode == (int)SQLiteErrorCode.Constraint)
                    {
                        MessageBox.Show("Mã Nganh đã tồn tại!");
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
    }
}
