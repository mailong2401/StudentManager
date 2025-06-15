using StudentManager.DAO;
using StudentManager.model;

namespace StudentManager
{
    public partial class UserControlStudentShow : UserControl
    {

        private List<Student> students;
        int indexCurrentTable;
        int indexMinTable;

        public UserControlStudentShow()
        {
            InitializeComponent();

            btnConfirmOfUDAdd.Click += (s, e) =>
            {
                fAddStudent fAddStudent = new fAddStudent(this);
                fAddStudent.ShowDialog();
            };

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
                int totalPage = (int)Math.Ceiling(students.Count / (double)itemsPerPage);
                if (indexCurrentTable < totalPage - 1)
                {
                    ChangePage(indexCurrentTable + 1);
                }
            };

            // Load dữ liệu ban đầu
            students = StudentDAO.GetAll();
            indexCurrentTable = 0;
            indexMinTable = 0;
            ChangePage(indexCurrentTable);
        }

        public void LoadTable()
        {
            students = StudentDAO.GetAll();
            ChangePage(indexCurrentTable);
        }

        private void createTable()
        {
            tableStudent.Controls.Clear();

            if (students.Count == 0)
            {
                tableStudent.Controls.Add(new Label
                {
                    Text = "Chưa có sinh viên nào.",
                    Dock = DockStyle.Top,
                    AutoSize = true
                });
                return;
            }

            int startIndex = indexCurrentTable * 12;
            int endIndex = Math.Min(startIndex + 11, students.Count - 1);

            for (int i = endIndex; i >= startIndex; i--)
            {
                var student = students[i];

                var item = new UIitemStudent(this)
                {
                    Dock = DockStyle.Top
                };
                item.setItem(student);

                tableStudent.Controls.Add(item);
                item.BringToFront(); // Đảm bảo hiển thị đúng thứ tự từ trên xuống
            }
        }


        private void ChangePage(int pageIndex)
        {
            int itemsPerPage = 12;
            int totalPage = (int)Math.Ceiling(students.Count / (double)itemsPerPage);
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
    }
}