using StudentManager.DAO;
using StudentManager.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class fAddSubject : Form
    {
        UserControlSubjectShow _parent;
        public fAddSubject()
        {
            InitializeComponent();
        }

        public fAddSubject(UserControlSubjectShow parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void addSubject()
        {
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

            // Tạo đối tượng môn học đúng cách
            Subject subject = new Subject
            {
                MaMon = maMon,
                TenMon = tenMon,
                SoTinChi = soTinChi
            };

            try
            {
                SubjectDao.Insert(subject);
                _parent.loadTable(); // cập nhật lại danh sách
                MessageBox.Show("Thêm môn học thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // đóng form sau khi thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm môn học:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Hàm hiển thị thông báo lỗi
        private void ShowError(string message)
        {
            MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnConfirmOfUDAdd_Click(object sender, EventArgs e)
        {
            addSubject();
        }
    }
}
