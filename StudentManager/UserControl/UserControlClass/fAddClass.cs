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
    public partial class fAddClass : Form
    {
        public fAddClass()
        {
            InitializeComponent();
        }

        public void InsertNganh(string maKhoa, string tenKhoa, string maNganh)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=mydb.sqlite;Version=3;"))
            {
                conn.Open();
                string query = "INSERT INTO Lop (MaLop, TenLop ,MaNganh) VALUES (@MaLop, @TenLop, @MaNganh)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maKhoa", maKhoa);
                    cmd.Parameters.AddWithValue("@tenKhoa", tenKhoa);
                    cmd.Parameters.AddWithValue("@MaNgang", maNganh);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
