

using StudentManager.DAO;
using StudentManager.model;

namespace StudentManager
{
    public partial class UserControlSubjectShow : UserControl
    {
        List<Subject> subjects;
        int indexCurrentTable;
        int indexMinTable;
        public UserControlSubjectShow()
        {
            InitializeComponent();

            // Gán sự kiện click cho các nút phân trang
            page1.Click += (s, e) => ChangePage(indexMinTable + 0);
            page2.Click += (s, e) => ChangePage(indexMinTable + 1);
            page3.Click += (s, e) => ChangePage(indexMinTable + 2);
            page4.Click += (s, e) => ChangePage(indexMinTable + 3);
            page5.Click += (s, e) => ChangePage(indexMinTable + 4);
            page6.Click += (s, e) => ChangePage(indexMinTable + 5);

            pageLeft.Click += (s, e) =>
            {
                if (indexCurrentTable > 0)
                {
                    ChangePage(indexCurrentTable - 1);
                }
            };

            pageRight.Click += (s, e) =>
            {
                int itemsPerPage = 12;
                int totalPage = (int)Math.Ceiling(subjects.Count / (double)itemsPerPage);
                if (indexCurrentTable < totalPage - 1)
                {
                    ChangePage(indexCurrentTable + 1);
                }
            };

            // Load dữ liệu ban đầu
            subjects = SubjectDao.GetAll();
            indexCurrentTable = 0;
            indexMinTable = 0;
            ChangePage(0);

        }

        public void loadTable()
        {
            subjects = SubjectDao.GetAll();
            ChangePage(indexCurrentTable);
        }

        private void createTable()
        {
            tb_Subject.Controls.Clear();

            if (subjects.Count == 0)
            {
                tb_Subject.Controls.Add(new Label
                {
                    Text = "Chưa có sinh viên nào.",
                    Dock = DockStyle.Top,
                    AutoSize = true
                });
                return;
            }

            int startIndex = indexCurrentTable * 12;
            int endIndex = Math.Min(startIndex + 11, subjects.Count - 1);

            for (int i = endIndex; i >= startIndex; i--)
            {
                var subject = subjects[i];

                var item = new UIItemSubject(this)
                {
                    Dock = DockStyle.Top
                };
                item.setItem(subject);

                tb_Subject.Controls.Add(item);
                item.BringToFront(); // Đảm bảo hiển thị đúng thứ tự từ trên xuống
            }
        }

        private void ChangePage(int pageIndex)
        {
            int itemsPerPage = 12;
            int totalPage = (int)Math.Ceiling(subjects.Count / (double)itemsPerPage);
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

        private void btnConfirmOfSubjectAdd_Click(object sender, EventArgs e)
        {
            fAddSubject fAddSubject = new fAddSubject(this);
            fAddSubject.ShowDialog();
        }
    }
}
