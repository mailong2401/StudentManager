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
    public partial class UserControlBranch : UserControl
    {
        public UserControlBranch()
        {
            InitializeComponent();
        }
        private void btnBranchAdd_Click(object sender, EventArgs e)
        {
            mainBranch.Controls.Clear();
            UserControlBranchAdd ucBA = new UserControlBranchAdd();
            ucBA.Dock = DockStyle.Fill;
            mainBranch.Controls.Add(ucBA);
        }
        private void btnBrandShow_Click(object sender, EventArgs e)
        {
            mainBranch.Controls.Clear();
            UserControlBranchShow ucBS = new UserControlBranchShow();
            ucBS.Dock = DockStyle.Fill;
            mainBranch.Controls.Add(ucBS);
        }
        private void btnBranchSearch_Click(object sender, EventArgs e)
        {
            mainBranch.Controls.Clear();
            UserControlBranchSearch ucBSr = new UserControlBranchSearch();
            ucBSr.Dock = DockStyle.Fill;
            mainBranch.Controls.Add(ucBSr);
        }

        
    }
}
