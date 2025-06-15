using StudentManager.DAO;
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
    public partial class UIItemClass : UserControl
    {

        UserControlClassShow _parent;
        public UIItemClass()
        {
            InitializeComponent();
        }
        public UIItemClass(UserControlClassShow parent)
        {
            InitializeComponent();
            pictureBox2.Click += pic_delete_Click;
            _parent = parent;
        }

        public void pic_delete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                // Xóa dữ liệu trong database nếu có
                string id = lbmalop.Text;
                ClassDao.Delete(id); // giả sử bạn lưu maKhoa ở đây
                _parent.loadTable();
            }
        }
        public void setitem(Class @class)
        {
            lbmalop.Text = @class.Id;
            lbnamelop.Text = @class.Name;
            lbnameNganh.Text = @class.nameNganh;
        }

        private void lbmalop_Click(object sender, EventArgs e)
        {

        }
    }
}
