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
    public partial class UserControlStudent : UserControl
    {
        public UserControlStudent()
        {
            InitializeComponent();
        }

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            panelUserControlChild.Controls.Clear();
            UserControlStudentAdd ucSA = new UserControlStudentAdd();
            ucSA.Dock = DockStyle.Fill;
            panelUserControlChild.Controls.Add(ucSA);
        }

        private void btnStudentShow_Click(object sender, EventArgs e)
        {
            panelUserControlChild.Controls.Clear();
            UserControlStudentShow ucSS = new UserControlStudentShow();
            ucSS.Dock = DockStyle.Fill;
            panelUserControlChild.Controls.Add(ucSS);
        }

        private void btnStudentSearch_Click(object sender, EventArgs e)
        {
            panelUserControlChild.Controls.Clear();
            UserControlStudentSearch ucSSr = new UserControlStudentSearch();
            ucSSr.Dock = DockStyle.Fill;
            panelUserControlChild.Controls.Add(ucSSr);
        }
    }
}
