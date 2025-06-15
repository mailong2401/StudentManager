using StudentManager.DAO;
using StudentManager.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class UIItemSubject : UserControl
    {
        Subject index;
        UserControlSubjectShow _parent;
        public UIItemSubject()
        {
            InitializeComponent();
        }
        public UIItemSubject(UserControlSubjectShow parent)
        {
            InitializeComponent();
            this._parent = parent;
        }
        public void setItem(Subject subject)
        {
            index = subject;
            lb_maMon.Text = index.MaMon;
            lb_tenMon.Text = index.TenMon;
            lb_SoTinChi.Text = index.SoTinChi.ToString();
        }


        // delete 
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa môn học này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                SubjectDao.Delete(index.MaMon);
                _parent.loadTable();
            }
        }

        //update
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fEditSubject fEditSubject = new fEditSubject(_parent);
            fEditSubject.setItem(index);
            fEditSubject.ShowDialog();
        }
    }
}
