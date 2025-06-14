using System.Security.Policy;

namespace StudentManager
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }
        

        private void ChangePage(int index)
        {
            ReaLTaiizor.Controls.ParrotButton[] btns = { btnKhoa, btnNganh, btnLop, btnMon, btnSinhVien, btnDiem, btnThongKe };
            for (int i = 0; i < btns.Length; i++)
            {
                btns[i].BackgroundColor = Color.Transparent;
                btns[i].TextColor = Color.White;
            }
            btns[index].BackgroundColor = Color.FromArgb(15, 40, 45);
            btns[index].TextColor = Color.DodgerBlue;
        }
        private void LoadUserControl(UserControl uc, int pos)
        {
            panelUserControlDad.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelUserControlDad.Controls.Add(uc);
            ChangePage(pos);
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlUDShow(),0);
        }
        private void btnNganh_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlBranchShow(),1);
        }
        private void btnLop_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlClassShow(),2);
        }
        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlStudentShow(),4);
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlStatistic(),6);
        }

        private void btnMon_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlSubjectShow(),3);
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlScoreShow(),5);
        }
    }
}