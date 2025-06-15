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
    public partial class fEditSubject : Form
    {
        Subject index;
        UserControlSubjectShow _parent;
        public fEditSubject()
        {
            InitializeComponent();
        }

        public fEditSubject(UserControlSubjectShow parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void setItem(Subject subject)
        {
            index = subject;
            inputidMon.Text = index.MaMon;
            inputNameMon.Text = index.TenMon;
            inputSoTinChi.Text = index.SoTinChi.ToString();
        }

        private void editSubject()
        {
            // Kiểm tra và chuyển đổi số tín chỉ
            if (!int.TryParse(inputSoTinChi.Text.Trim(), out int soTinChi))
            {
                ShowError("Số tín chỉ không hợp lệ!");
                return;
            }

            string tenMon = inputNameMon.Text.Trim();
            if (string.IsNullOrWhiteSpace(tenMon))
            {
                ShowError("Vui lòng nhập tên môn học!");
                return;
            }

            string maMon = inputidMon.Text.Trim();
            if (string.IsNullOrWhiteSpace(maMon))
            {
                ShowError("Vui lòng nhập mã môn học!");
                return;
            }

            // Tạo đối tượng môn học
            Subject subject = new Subject
            {
                MaMon = maMon,
                TenMon = tenMon,
                SoTinChi = soTinChi
            };

            try
            {
                SubjectDao.Update(subject);
                _parent.loadTable(); // Load lại bảng
                MessageBox.Show("Cập nhật môn học thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật môn học:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Hàm hiển thị thông báo lỗi
        private void ShowError(string message)
        {
            MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnConfirmOfUDAdd_Click(object sender, EventArgs e)
        {
            editSubject();
        }
    }
}
