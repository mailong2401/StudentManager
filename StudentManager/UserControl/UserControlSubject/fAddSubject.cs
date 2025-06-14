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
        public fAddSubject()
        {
            InitializeComponent();
        }
        public void InsertDiem(string maKhoa, string tenKhoa)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=mydb.sqlite;Version=3;"))
            {
                conn.Open();
                string query = "INSERT INTO Diem (maKhoa, tenKhoa) VALUES (@maKhoa, @tenKhoa)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maKhoa", maKhoa);
                    cmd.Parameters.AddWithValue("@tenKhoa", tenKhoa);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
