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
        public UIitemStudent()
        {
            InitializeComponent();
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
        }

    }
}
