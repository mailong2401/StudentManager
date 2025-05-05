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

        

        private void btnClassShow_Click(object sender, EventArgs e)
        {
            mainclass.Controls.Clear();
            UserControlClassShow ucCS = new UserControlClassShow();
            ucCS.Dock = DockStyle.Fill;
            mainclass.Controls.Add(ucCS);
        }

       
    }
}
