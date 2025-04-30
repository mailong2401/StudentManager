using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManager.UI.MainForms.Student;

namespace StudentManager.UI
{
    public partial class fStudentBar : Form
    {
        Panel MainPanel;
        public fStudentBar(Panel mainPanel)
        {
            InitializeComponent();
            MainPanel = mainPanel;
        }

        public static void ControlPanel(Panel tempPanel, Form f)
        {

            tempPanel.Controls.Clear();  // Xóa các điều khiển cũ
            f.Dock = DockStyle.Fill;       // Đảm bảo form này chiếm toàn bộ panel
            f.TopLevel = false;            // Đặt TopLevel là false để nó trở thành con của panel
            tempPanel.Controls.Add(f);   // Thêm form vào panel
            f.Show();                      // Hiển thị form
        }

        private void fStudentBar_Load(object sender, EventArgs e)
        {

        }

        private void btnStudentSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            ControlPanel(MainPanel, new fAddStudent());
        }
    }
}
