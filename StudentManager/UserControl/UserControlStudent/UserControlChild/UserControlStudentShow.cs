using StudentManager.DAO;
using StudentManager.model;

namespace StudentManager
{
    public partial class UserControlStudentShow : UserControl
    {

        private List<Student> students;
        int indexCurrentTable;

        public UserControlStudentShow()
        {
            InitializeComponent();
            students = StudentDAO.GetAll();
            createTable();
            indexCurrentTable = 0;
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

                var item = new UIitemStudent
                {
                    Dock = DockStyle.Top
                };
                item.setItem(student);

                tableStudent.Controls.Add(item);
                item.BringToFront(); // Đảm bảo hiển thị đúng thứ tự từ trên xuống
            }
        }
    }
}