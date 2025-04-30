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
            UserControlUD ucU = new UserControlUD();
            ucU.Dock = DockStyle.Fill;
            panelUserControlDad.Controls.Add(ucU);
        }
        private void btnNganh_Click(object sender, EventArgs e)
        {
            panelUserControlDad.Controls.Clear();
            UserControlBranch ucB = new UserControlBranch();
            ucB.Dock = DockStyle.Fill;
            panelUserControlDad.Controls.Add(ucB);
        }
        private void btnLop_Click(object sender, EventArgs e)
        {
            panelUserControlDad.Controls.Clear();
            UserControlClass ucC = new UserControlClass();
            ucC.Dock = DockStyle.Fill;
            panelUserControlDad.Controls.Add(ucC);
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
       
    }
}
