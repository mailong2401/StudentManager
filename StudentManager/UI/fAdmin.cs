namespace StudentManager
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            panelUserControlDad.Controls.Clear();
            UserControlUDShow ucUDS = new UserControlUDShow();
            ucUDS.Dock = DockStyle.Fill;
            panelUserControlDad.Controls.Add(ucUDS);
        }
        private void btnNganh_Click(object sender, EventArgs e)
        {
            panelUserControlDad.Controls.Clear();
            UserControlBranchShow ucBS = new UserControlBranchShow();
            ucBS.Dock = DockStyle.Fill;
            panelUserControlDad.Controls.Add(ucBS);
        }
        private void btnLop_Click(object sender, EventArgs e)
        {
            panelUserControlDad.Controls.Clear();
            UserControlClassShow ucCS = new UserControlClassShow();
            ucCS.Dock = DockStyle.Fill;
            panelUserControlDad.Controls.Add(ucCS);
        }
        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            panelUserControlDad.Controls.Clear();
            UserControlStudent ucS = new UserControlStudent();
            ucS.Dock = DockStyle.Fill;
            panelUserControlDad.Controls.Add(ucS);
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            panelUserControlDad.Controls.Clear();
            UserControlStatistic ucSS = new UserControlStatistic();
            ucSS.Dock = DockStyle.Fill;
            panelUserControlDad.Controls.Add(ucSS);
        }

        private void btnMon_Click(object sender, EventArgs e)
        {
            panelUserControlDad.Controls.Clear();
            UserControlSubjectShow ucSJS = new UserControlSubjectShow();
            ucSJS.Dock = DockStyle.Fill;
            panelUserControlDad.Controls.Add(ucSJS);
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            panelUserControlDad.Controls.Clear();
            UserControlScore ucSC = new UserControlScore();
            ucSC.Dock = DockStyle.Fill;
            panelUserControlDad.Controls.Add(ucSC);
        }
    }
}