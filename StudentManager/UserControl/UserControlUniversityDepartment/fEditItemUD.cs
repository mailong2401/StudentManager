using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class fEditItemUD : Form
    {
        public fEditItemUD()
        {
            InitializeComponent();

        }

        public fEditItemUD(string id, string name)
        {
            InitializeComponent();
            this.inputidKhoa.Text = id;
            this.inputNameKhoa.Text = name;  // <-- sửa ở đây
        }

        public void UpdateKhoa(string maKhoa, string tenKhoaMoi)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=mydb.sqlite;Version=3;"))
            {
                conn.Open();
                string query = "UPDATE Khoa SET tenKhoa = @tenKhoa WHERE maKhoa = @maKhoa";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tenKhoa", tenKhoaMoi);
                    cmd.Parameters.AddWithValue("@maKhoa", maKhoa);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnConfirmOfUDAdd_Click(object sender, EventArgs e)
        {
            UpdateKhoa(inputidKhoa.Text, inputNameKhoa.Text); // <-- sửa ở đây
            DialogResult = DialogResult.OK;
            Close();
        }
        public string getEditedId() { return inputidKhoa.Text;}
        public string getEditedName() { return inputNameKhoa.Text; }
    }
}
