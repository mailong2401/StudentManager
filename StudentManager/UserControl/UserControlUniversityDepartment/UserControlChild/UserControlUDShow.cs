using StudentManager.model;
using System.Data.SQLite;


namespace StudentManager
{
    public partial class UserControlUDShow : UserControl
    {
        

        List<UniversityDepartment> _universities = new List<UniversityDepartment>();
        // Chuỗi kết nối SQLite

        int indexCurrentTable = 0;
        int indexMinTable = 0;
        // 0 1 2 3 4 5
        public UserControlUDShow()
        {
            InitializeComponent();
            // Gán các sự kiện Click cho các nút phân trang
            page1.Click += page1_Click;
            page2.Click += page2_Click;
            page3.Click += page3_Click;
            page4.Click += page4_Click;
            page5.Click += page5_Click;
            page6.Click += page6_Click;

            pageLeft.Click += pageLeft_Click;
            pageRight.Click += pageRight_Click;
            LoadAllUD(maKhoaT); // Gọi hàm khi control được tạo

        }

        public string maKhoaT = "";
        string tenKhoaT = "";

        private void btnConfirmOfUDAdd_Click_1(object sender, EventArgs e)
        {

        }

        public void LoadAllUD(string x)
        {
            string connectionString = "Data Source=mydb.sqlite;Version=3;";
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
                        if (maKhoa.ToLower().Contains(maKhoaT.ToLower()))
                        {
                            UniversityDepartment temp = new UniversityDepartment(maKhoa, tenKhoa);
                            _universities.Add(temp);
                        }
                    }
                }
            }
            ChangePage(indexCurrentTable);
        }

        public void createTable()
        {
            tablekhoa.Controls.Clear();
            if (_universities.Count == 0)
            {
                MessageBox.Show("Khong tim thay khoa nao");
                return;
            }  
            int indexMax = indexCurrentTable * 12 + 11;
            if (indexCurrentTable * 12 + 11 > _universities.Count - 1)
            {
                indexMax = _universities.Count - 1;
            }
            for (int i = indexMax; i >= indexCurrentTable * 12; i--)
            {

                var universityDe = _universities[i];
                // Tạo control UIItemUniversityDepartment
                UIItemUniversityDepartment uIItemBranch = new UIItemUniversityDepartment(this);
                uIItemBranch.Dock = DockStyle.Top;

                // Thiết lập dữ liệu
                uIItemBranch.setItem(universityDe.Id, universityDe.Name);

                // Thêm vào Panel (hoặc FlowLayoutPanel)
                tablekhoa.Controls.Add(uIItemBranch);
                uIItemBranch.BringToFront(); // Đảm bảo thứ tự từ trên xuống
            }
        }



        private void inputidKhoa_TextChanged(object sender, EventArgs e)
        {

        }


        void ChangePage(int pageIndex)
        {
            int itemsPerPage = 12;
            int totalPage = (int)Math.Ceiling(_universities.Count / (double)itemsPerPage);
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


        //Các nút di chuyển trang
        void page1_Click(object sender, EventArgs e) => ChangePage(indexMinTable + 0);
        void page2_Click(object sender, EventArgs e) => ChangePage(indexMinTable + 1);
        void page3_Click(object sender, EventArgs e) => ChangePage(indexMinTable + 2);
        void page4_Click(object sender, EventArgs e) => ChangePage(indexMinTable + 3);
        void page5_Click(object sender, EventArgs e) => ChangePage(indexMinTable + 4);
        void page6_Click(object sender, EventArgs e) => ChangePage(indexMinTable + 5);
        void pageLeft_Click(object sender, EventArgs e)
        {
            // Lùi về trang trước nếu không ở trang đầu
            if (indexCurrentTable > 0)
            {
                ChangePage(indexCurrentTable - 1);
            }
        }

        private void pageRight_Click(object sender, EventArgs e)
        {
            int itemsPerPage = 12;
            int totalPage = (int)Math.Ceiling(_universities.Count / (double)itemsPerPage);

            // Tiến tới trang tiếp theo nếu chưa ở trang cuối
            if (indexCurrentTable < totalPage - 1)
            {
                ChangePage(indexCurrentTable + 1);
            }
        }




        private void btnConfirmOfUDAdd_Click(object sender, EventArgs e)
        {
            fAddItemUD fAddItemUD = new fAddItemUD(this);
            fAddItemUD.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pbidkhoa.Image = null;  // Ẩn ảnh của pbidkhoa
            pbnamekhoa.Image = null;  // Ẩn ảnh của pbnamekhoa
            maKhoaT = inputidKhoa.Text;
            maKhoaT = maKhoaT.Trim(); // xóa dấu cách đầu và cuối
            LoadAllUD(maKhoaT);
        }
        bool sortid = true;
        bool sortname = true;

        private void lbkhoa_Click(object sender, EventArgs e)
        {
            // Khi nhấn vào lbkhoa, đảm bảo ảnh của pbnamekhoa không hiển thị
            pbnamekhoa.Image = null;  // Ẩn ảnh của pbnamekhoa

            if (sortid == false)
            {
                pbidkhoa.Image = Properties.Resources.up_chevron;
                _universities.Sort((x, y) => x.Id.CompareTo(y.Id));  // Sắp xếp theo Id tăng dần
                sortid = true;
            }
            else
            {
                pbidkhoa.Image = Properties.Resources.down_chevron;
                _universities.Sort((x, y) => y.Id.CompareTo(x.Id));  // Sắp xếp theo Id giảm dần
                sortid = false;
            }

            // Tạo lại bảng sau khi sắp xếp
            createTable();
        }

        private void lbnamekhoa_Click(object sender, EventArgs e)
        {
            // Khi nhấn vào lbnamekhoa, đảm bảo ảnh của pbidkhoa không hiển thị
            pbidkhoa.Image = null;  // Ẩn ảnh của pbidkhoa

            if (sortname == false)
            {
                pbnamekhoa.Image = Properties.Resources.up_chevron;
                _universities.Sort((x, y) => x.Name.CompareTo(y.Name));
                sortname = true;
            }
            else
            {
                pbnamekhoa.Image = Properties.Resources.down_chevron;
                _universities.Sort((x, y) => y.Name.CompareTo(x.Name));
                sortname = false;
            }

            createTable();
        }

    }
}
