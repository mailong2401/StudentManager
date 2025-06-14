using StudentManager.model;
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
    public partial class UIItemSubject : UserControl
    {
        public UIItemSubject()
        {
            InitializeComponent();
        }
        public void setItem(Subject subject)
        {
            lb_maMon.Text = subject.MaMon;
            lb_tenMon.Text = subject.TenMon;
            lb_SoTinChi.Text = subject.SoTinChi.ToString();
        }
    }
}
