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
    public partial class UIItemClass : UserControl
    {
        public UIItemClass()
        {
            InitializeComponent();
        }
        public void setitem(string id, string name, string namenganh, string namekhoa)
        {
            lbmalop.Text = id;
            lbnamelop.Text = name;
            lbnameNganh.Text = namenganh;
            lbnameKhoa.Text = namekhoa;
        }

        private void lbmalop_Click(object sender, EventArgs e)
        {

        }
    }
}
