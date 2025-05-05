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
    public partial class UserControlClassShow : UserControl
    {
        // Chuỗi kết nối SQLite
        string connectionString = "Data Source=mydb.sqlite;Version=3;";

        public class Class
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string NameKhoa { get; set; }
            public string nameNganh { get; set; }

            public Class() { }

            public Class(string id, string name, string nameNganh, string nameKhoa)
            {
                this.Id = id;
                this.Name = name;
                this.NameKhoa = nameKhoa;
                this.nameNganh = nameNganh;
            }
        }
        List<Class> classes = new List<Class>();
        int indexCurrentTable = 0;
        int indexMinTable = 0;
        public UserControlClassShow()
        {
            InitializeComponent();
            LoadAllCall();
            ChangePage(0);
        }
        private void LoadAllCall()
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
                SELECT Lop.maLop, Lop.tenLop, Nganh.tenNganh, Khoa.tenKhoa
                FROM Lop
                JOIN Nganh ON Lop.maNganh = Nganh.maNganh
                JOIN Khoa ON Nganh.maKhoa = Khoa.maKhoa;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    classes.Clear();
                    while (reader.Read())
                    {
                        string maLop = reader["maLop"].ToString();
                        string tenLop = reader["tenLop"].ToString();
                        string tenNganh = reader["tenNganh"].ToString();
                        string tenKhoa = reader["tenKhoa"].ToString(); // Thay vì maKhoa, lấy tenKhoa
                        Class temp = new Class(maLop, tenLop, tenNganh, tenKhoa);
                        classes.Add(temp);
                    }
                }
            }
            createTable();
        }
        private void createTable()
        {
            if (classes.Count == 0)
            {
                Label emptyLabel = new Label();
                emptyLabel.Text = "Chưa có khoa nào.";
                emptyLabel.Dock = DockStyle.Top;
                tbClassac.Controls.Add(emptyLabel);
                return;
            }

            // Xóa các control cũ trước khi thêm mới (nếu cần load lại nhiều lần)
            tbClassac.Controls.Clear();
            int indexMax = indexCurrentTable * 12 + 11;
            if (indexCurrentTable * 12 + 11 > classes.Count - 1)
            {
                indexMax = classes.Count - 1;
            }
            for (int i = indexMax; i >= indexCurrentTable * 12; i--)
            {

                var classi = classes[i];
                // Tạo control UIItemUniversityDepartment
                UIItemClass uIItemClass = new UIItemClass();
                uIItemClass.Dock = DockStyle.Top;

                // Thiết lập dữ liệu
                uIItemClass.setitem(classi.Id, classi.Name, classi.nameNganh, classi.NameKhoa);

                // Thêm vào Panel (hoặc FlowLayoutPanel)
                tbClassac.Controls.Add(uIItemClass);
                uIItemClass.BringToFront(); // Đảm bảo thứ tự từ trên xuống
            }
        }

        private void ChangePage(int pageIndex)
        {
            int itemsPerPage = 12;
            int totalPage = (int)Math.Ceiling(classes.Count / (double)itemsPerPage);
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
