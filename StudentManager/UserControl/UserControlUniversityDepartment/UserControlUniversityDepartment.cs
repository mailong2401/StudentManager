using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class UserControlUD : UserControl
    {
        public UserControlUD()
        {
            InitializeComponent();
        }

        private void btnUDAdd_Click(object sender, EventArgs e)
        {
            mainUD.Controls.Clear();
            UserControlUDAdd ucUDA = new UserControlUDAdd();
            ucUDA.Dock = DockStyle.Fill;
            mainUD.Controls.Add(ucUDA);
        }

        private void btnUDShow_Click(object sender, EventArgs e)
        {
            mainUD.Controls.Clear();
            UserControlUDShow ucUDS = new UserControlUDShow();
            ucUDS.Dock = DockStyle.Fill;
            mainUD.Controls.Add(ucUDS);
        }

        private void btnUDSearch_Click(object sender, EventArgs e)
        {
            mainUD.Controls.Clear();
            UserControlUDSearch ucUDSr = new UserControlUDSearch();
            ucUDSr.Dock = DockStyle.Fill;
            mainUD.Controls.Add(ucUDSr);
        }
    }
}
