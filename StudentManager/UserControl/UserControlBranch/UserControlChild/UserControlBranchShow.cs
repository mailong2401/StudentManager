using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class UserControlBranchShow : UserControl
    {
        public class Branch
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string NameKhoa { get; set; }

            public Branch() { }

            public Branch(string id, string name, string nameKhoa)
            {
                Id = id;
                Name = name;
                NameKhoa = nameKhoa;
            }
        }
        List<Branch> _branches = new List<Branch>();
        // Chuỗi kết nối SQLite
        string connectionString = "Data Source=mydb.sqlite;Version=3;";

        int indexCurrentTable = 0;
        int indexMinTable = 0;

        public UserControlBranchShow()
        {
            InitializeComponent();
            LoadAllBranches(); // Gọi hàm khi control được tạo
            LoadKhoaData();
            ChangePage(0);
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
                        comboboxkhoa.Items.Clear();

                        // Đọc dữ liệu và thêm vào ComboBox
                        while (reader.Read())
                        {
                            // Thêm tên khoa vào ComboBox
                            string maKhoa = reader["maKhoa"].ToString();
                            comboboxkhoa.Items.Add(maKhoa);
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
                // Bật foreign key support
                using (var command = new SQLiteCommand("PRAGMA foreign_keys = ON;", conn))
                {
                    command.ExecuteNonQuery();
                }

                // Truy vấn kết hợp bảng Nganh và Khoa
                string query = @"
            SELECT Nganh.maNganh, Nganh.tenNganh, Khoa.tenKhoa
            FROM Nganh
            INNER JOIN Khoa ON Nganh.maKhoa = Khoa.maKhoa";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    // Xóa các control cũ trước khi thêm mới (nếu cần load lại nhiều lần)
                    tbNganh.Controls.Clear();
                    _branches.Clear();


                    while (reader.Read())
                    {
                        string maNganh = reader["maNganh"].ToString();
                        string tenNganh = reader["tenNganh"].ToString();
                        string tenKhoa = reader["tenKhoa"].ToString(); // Thay vì maKhoa, lấy tenKhoa
                        Branch temp = new Branch(maNganh, tenNganh, tenKhoa);
                        _branches.Add(temp);
                    }
                }
            }
            createTable();
        }

        private void createTable()
        {
            if (_branches.Count == 0)
            {
                Label emptyLabel = new Label();
                emptyLabel.Text = "Chưa có khoa nào.";
                emptyLabel.Dock = DockStyle.Top;
                tbNganh.Controls.Add(emptyLabel);
                return;
            }

            // Xóa các control cũ trước khi thêm mới (nếu cần load lại nhiều lần)
            tbNganh.Controls.Clear();

            // 24
            // 1  2  3  4  5  6  7  8  9  10 11 12
            // 13 14 15 16 17 18 19 20 21 22 23 24
            // max 30
            // 2 * 12 + 11 = 
            int indexMax = indexCurrentTable * 12 + 11;
            if (indexCurrentTable * 12 + 11 > _branches.Count - 1)
            {
                indexMax = _branches.Count - 1;
            }
            for (int i = indexMax; i >= indexCurrentTable * 12; i--)
            {

                var branche = _branches[i];
                // Tạo control UIItemUniversityDepartment
                UIItemBranch uIItemBranch = new UIItemBranch();
                uIItemBranch.Dock = DockStyle.Top;

                // Thiết lập dữ liệu
                uIItemBranch.setItem(branche.Id, branche.Name, branche.NameKhoa);

                // Thêm vào Panel (hoặc FlowLayoutPanel)
                tbNganh.Controls.Add(uIItemBranch);
                uIItemBranch.BringToFront(); // Đảm bảo thứ tự từ trên xuống
            }
        }


        private void inputNameNganh_TextChanged(object sender, EventArgs e)
        {

        }

        public void InsertNgang(string maNganh, string tenNganh, string maKhoa)
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
            if (!string.IsNullOrWhiteSpace(inputNameNganh.Text) && !string.IsNullOrWhiteSpace(inputidNganh.Text) && comboboxkhoa.SelectedIndex != -1)
            {
                string nameNganh = inputNameNganh.Text;
                string idNganh = inputidNganh.Text;
                string idKhoa = comboboxkhoa.SelectedItem.ToString();
                try
                {
                    InsertNgang(idNganh, nameNganh, idKhoa);
                    MessageBox.Show("Thêm Ngành thành công!");
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
        private void ChangePage(int pageIndex)
        {
            int itemsPerPage = 12;
            int totalPage = (int)Math.Ceiling(_branches.Count / (double)itemsPerPage);
            int maxIndexMinTable = Math.Max(totalPage - 6, 0); // Vì có 6 nút trang

            // Tính toán indexMinTable hợp lý
            if (pageIndex > indexMinTable + 2)
            {
                indexMinTable = Math.Min(pageIndex - 2, maxIndexMinTable);
            }
            else
            {
                indexMinTable = Math.Max(indexMinTable - (2 - (pageIndex - indexMinTable)), 0);
            }

            // Cập nhật các nút phân trang
            ReaLTaiizor.Controls.ParrotButton[] pages = { page1, page2, page3, page4, page5, page6 };
            for (int i = 0; i < pages.Length; i++)
            {
                int pageNumber = indexMinTable + i + 1;
                pages[i].ButtonText = pageNumber.ToString();
                pages[i].BackgroundColor = Color.FromArgb(37, 52, 68);
                pages[i].TextColor = Color.White;

                // Ẩn nút nếu vượt quá tổng số trang
                pages[i].Visible = pageNumber <= totalPage;
            }

            // Tô màu nút đang được chọn
            int selectedIndex = pageIndex - indexMinTable;
            if (selectedIndex >= 0 && selectedIndex < pages.Length)
            {
                pages[selectedIndex].BackgroundColor = Color.FromArgb(195, 195, 195);
                pages[selectedIndex].TextColor = Color.DodgerBlue;
            }

            indexCurrentTable = pageIndex;
            createTable();
        }
        private void page1_Click(object sender, EventArgs e) => ChangePage(indexMinTable + 0);
        private void page2_Click(object sender, EventArgs e) => ChangePage(indexMinTable + 1);
        private void page3_Click(object sender, EventArgs e) => ChangePage(indexMinTable + 2);
        private void page4_Click(object sender, EventArgs e) => ChangePage(indexMinTable + 3);
        private void page5_Click(object sender, EventArgs e) => ChangePage(indexMinTable + 4);
        private void page6_Click(object sender, EventArgs e) => ChangePage(indexMinTable + 5);
    }
}
