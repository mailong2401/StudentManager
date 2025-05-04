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
    public partial class UserControlBranchAdd : UserControl
    {
        public UserControlBranchAdd()
        {
            InitializeComponent();

            LoadComboBox();
        }

        private void LoadComboBox()
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=mydb.sqlite;Version=3;"))
            {
                conn.Open();
                string query = "SELECT * FROM Khoa";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    inputkhoavien.DataSource = dt;
                    inputkhoavien.DisplayMember = "tenKhoa";  // Hiển thị tên
                    inputkhoavien.ValueMember = "maKhoa";     // Giá trị thực sự (ẩn)
                }
            }
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

        private void btnConfirmOfBranchAdd_Click(object sender, EventArgs e)
        {
            string maKhoa = inputid.Text;
            string tenkhoa = inputnamenganh.Text;
            InsertKhoa(maKhoa, tenkhoa);
        }
    }
}
