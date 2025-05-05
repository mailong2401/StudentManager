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
    public partial class UIItemBranch : UserControl
    {
        public UIItemBranch()
        {
            InitializeComponent();
        }
        public void setItem(string id, string name,string khoa)
        {
            lbid.Text = id;
            lbnamenganh.Text = name;
            lbkhoa.Text = khoa;
        }
    }
}
