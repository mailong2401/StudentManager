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
    public partial class UIItemUniversityDepartment : UserControl
    {
        public UIItemUniversityDepartment()
        {
            InitializeComponent();
        }
        public void setItem(string id, string name)
        {
            lbidkhoa.Text = id;
            lbnamekhoa.Text = name;
        }
        public void DeleteKhoa(string maKhoa)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=mydb.sqlite;Version=3;"))
            {
                conn.Open();
                string query = "DELETE FROM Khoa WHERE maKhoa = @maKhoa";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maKhoa", maKhoa);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã khoa để xóa.");
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa khoa này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                // Xóa dữ liệu trong database nếu có
                string id = lbidkhoa.Text;
                DeleteKhoa(id); // giả sử bạn lưu maKhoa ở đây

                // Xóa control khỏi TableLayoutPanel
                TableLayoutPanel parent = this.Parent as TableLayoutPanel;
                if (parent != null)
                {
                    parent.Controls.Remove(this);

                    // Tùy chọn: cập nhật lại layout (không bắt buộc nếu dùng AutoSize)
                    parent.Refresh();
                }
            }
        }
    }
}
