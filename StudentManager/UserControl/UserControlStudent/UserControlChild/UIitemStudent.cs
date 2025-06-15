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
    public partial class UIitemStudent : UserControl
    {
        UserControlStudentShow _parent;
        Student temp;
        public UIitemStudent()
        {
            InitializeComponent();
        }

        public UIitemStudent(UserControlStudentShow parent)
        {
            InitializeComponent();
            _parent = parent;
            pic_delete.Click += pic_delete_Click;
            pic_edit.Click += pic_edit_Click;
        }

        public void pic_delete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa Sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                // Xóa dữ liệu trong database nếu có
                int id = Convert.ToInt32(lbid.Text);
                StudentDAO.Delete(id); // giả sử bạn lưu maKhoa ở đây
                _parent.LoadTable();
            }
        }
        public void pic_edit_Click(object sender, EventArgs e)
        {
            fEditStudent fEditStudent = new fEditStudent(_parent);
            fEditStudent.setItem(temp);
            fEditStudent.ShowDialog();
        }
        public void setItem(Student student)
        {
            lbid.Text = student.MSSV.ToString();
            lbname.Text = student.HoTen;
            lbdate.Text = student.NgaySinh; // hoặc student.BirthDate.ToShortDateString()
            lbrender.Text = student.GioiTinh;
            lbdress.Text = student.DiaChi;
            lbphone.Text = student.SoDienThoai;
            lbclass.Text = student.MaLop;
            temp = student;
        }

    }
}
