using StudentManager.UI;

namespace StudentManager
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        public static void ControlPanel(Panel tempPanel,Form f)
        {

                tempPanel.Controls.Clear();  // Xóa các điều khiển cũ
                f.Dock = DockStyle.Fill;       // Đảm bảo form này chiếm toàn bộ panel
                f.TopLevel = false;            // Đặt TopLevel là false để nó trở thành con của panel
                tempPanel.Controls.Add(f);   // Thêm form vào panel
                f.Show();                      // Hiển thị form
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {

            ControlPanel(BarPanel,new fControlUniversityDepartmentBar());
        }
        private void btnNganh_Click(object sender, EventArgs e)
        {
            ControlPanel(BarPanel, new fBranchBar());
        }
        private void btnLop_Click(object sender, EventArgs e)
        {
            ControlPanel(BarPanel, new fClassBar());
        }
        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            ControlPanel(BarPanel,new fStudentBar(panelMain));
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ControlPanel(BarPanel,new fStatisticBar());
        }
       
    }
}
