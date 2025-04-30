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
    public partial class UserControlClass : UserControl
    {
        public UserControlClass()
        {
            InitializeComponent();
        }

        private void btnClassAdd_Click(object sender, EventArgs e)
        {
            panelUserControlChild.Controls.Clear();
            UserControlClassAdd ucCA = new UserControlClassAdd();
            ucCA.Dock = DockStyle.Fill;
            panelUserControlChild.Controls.Add(ucCA);
        }

        private void btnClassShow_Click(object sender, EventArgs e)
        {
            panelUserControlChild.Controls.Clear();
            UserControlClassShow ucCS = new UserControlClassShow();
            ucCS.Dock = DockStyle.Fill;
            panelUserControlChild.Controls.Add(ucCS);
        }

        private void btnClassSearch_Click(object sender, EventArgs e)
        {
            panelUserControlChild.Controls.Clear();
            UserControlClassSearch ucCSr = new UserControlClassSearch();
            ucCSr.Dock = DockStyle.Fill;
            panelUserControlChild.Controls.Add(ucCSr);
        }
    }
}
