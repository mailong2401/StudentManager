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
    public partial class fAddItemUD : Form
    {
        public fAddItemUD()
        {
            InitializeComponent();
        }

        public void InsertKhoa(string maKhoa, string tenKhoa)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=mydb.sqlite;Version=3;"))
            {
                conn.Open();
                string query = "INSERT INTO Khoa (maKhoa, tenKhoa) VALUES (@maKhoa, @tenKhoa)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maKhoa", maKhoa);
                    cmd.Parameters.AddWithValue("@tenKhoa", tenKhoa);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnConfirmOfUDAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(inputNameKhoa.Text) && !string.IsNullOrWhiteSpace(inputidKhoa.Text))
            {
                string nameKhoa = inputNameKhoa.Text;
                string idKhoa = inputidKhoa.Text;
                try
                {
                    InsertKhoa(idKhoa, nameKhoa);
                    MessageBox.Show("Thêm khoa thành công!");
                    inputidKhoa.Text = "";
                    inputNameKhoa.Text = "";
                    UserControlUDShow.LoadAllUD("");
                }
                catch (SQLiteException ex)
                {
                    if (ex.ErrorCode == (int)SQLiteErrorCode.Constraint)
                    {
                        MessageBox.Show("Mã khoa đã tồn tại!");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi cơ sở dữ liệu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhập thiếu thông tin");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
