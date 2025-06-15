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
    public partial class fEditClass : Form
    {

        UserControlStudentShow _parent;
        public fEditClass()
        {
            InitializeComponent();
        }
        public fEditClass(UserControlStudentShow parent)
        {
            InitializeComponent();
            _parent = parent;

            comboboxnganh.DataSource = ClassDao.GetAll();
            comboboxnganh.DisplayMember = "Name";  // Hiển thị cho người dùng
            comboboxnganh.ValueMember = "Id";     // Giá trị thực dùng để xử lý (nếu cần)
        }

        public void setitem(Class @class)
        {
            inputidLop.Text = @class.Id;
            inputNameLop.Text = @class.Name;

        }
    }
}
