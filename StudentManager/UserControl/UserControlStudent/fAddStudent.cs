using StudentManager.DAO;
using StudentManager.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class fAddStudent : Form
    {
        UserControlStudentShow _parent;
        public fAddStudent()
        {
            InitializeComponent();
        }
        public fAddStudent(UserControlStudentShow parent)
        {
            InitializeComponent();
            _parent = parent;
            btn_add.Click += (s,e) =>
            {
                addStudent();

            };
            radio_btn_female.CheckedChanged += () =>
            {
                if (radio_btn_female.Checked)
                    radio_btn_male.Checked = false;
            };

            radio_btn_male.CheckedChanged += () =>
            {
                if (radio_btn_male.Checked)
                    radio_btn_female.Checked = false;
            };

            inputlop.DataSource = ClassDao.GetAll();
            inputlop.DisplayMember = "Name";  // Hiển thị cho người dùng
            inputlop.ValueMember = "Id";     // Giá trị thực dùng để xử lý (nếu cần)

            
        }

        private void addStudent()
        {
            // Kiểm tra và chuyển đổi MSSV
            if (!int.TryParse(inputid.Text.Trim(), out int mssv))
            {
                ShowError("MSSV không hợp lệ!");
                return;
            }

            string hoTen = inputname.Text.Trim();
            if (string.IsNullOrWhiteSpace(hoTen))
            {
                ShowError("Vui lòng nhập họ tên!");
                return;
            }

            string soDienThoai = inputphone.Text.Trim();
            string diaChi = inputdiachi.Text.Trim();
            string ngaySinh = inputngaysinh.Value.ToString("yyyy-MM-dd");

            // Xác định giới tính
            string gioiTinh = radio_btn_male.Checked ? "Nam" :
                              radio_btn_female.Checked ? "Nữ" : "";

            if (gioiTinh == "")
            {
                ShowError("Vui lòng chọn giới tính!");
                return;
            }

            // Kiểm tra lớp
            if (inputlop.SelectedItem is not Class selectedClass)
            {
                ShowError("Vui lòng chọn lớp!");
                return;
            }

            // Tạo đối tượng sinh viên
            Student student = new Student
            {
                MSSV = mssv,
                HoTen = hoTen,
                SoDienThoai = soDienThoai,
                DiaChi = diaChi,
                NgaySinh = ngaySinh,
                GioiTinh = gioiTinh,
                MaLop = selectedClass.Id
            };

            try
            {
                StudentDAO.Insert(student);
                _parent.LoadTable();
                MessageBox.Show("Thêm sinh viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sinh viên:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        // Hàm hiển thị thông báo lỗi
        private void ShowError(string message)
        {
            MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }
}
