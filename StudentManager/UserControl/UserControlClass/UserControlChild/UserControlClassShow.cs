using StudentManager.DAO;
using StudentManager.model;
using System.Data.SQLite;


namespace StudentManager
{
    public partial class UserControlClassShow : UserControl
    {
        // Chuỗi kết nối SQLite
        string connectionString = "Data Source=mydb.sqlite;Version=3;";

        
        List<Class> classes;
        int indexCurrentTable = 0;
        int indexMinTable = 0;
        public UserControlClassShow()
        {
            InitializeComponent();
            classes = ClassDao.GetAll();
            ChangePage(indexCurrentTable);
        }

        public void loadTable()
        {
            classes = ClassDao.GetAll();
            ChangePage(indexCurrentTable);
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
                UIItemClass uIItemClass = new UIItemClass(this);
                uIItemClass.Dock = DockStyle.Top;

                // Thiết lập dữ liệu
                uIItemClass.setitem(classi);

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
