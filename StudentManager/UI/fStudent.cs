using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace StudentManager
{
    public partial class fStudent : Form
    {
        string connectionString = "Server=localhost;Database=qlsv;Integrated Security=True;";
        public fStudent()
        {
            InitializeComponent();
            LoadData();
            LoadNganh();
            LoadKhoa();
        }
        private void LoadData()
        {
            // Thay Database=qlsv bằng tên database của bạn DataBase=ten-database
            // Nếu đăng nhập server bằng mật khẩu thì 


            //string connectionString = "Data Source=TEN_SERVER;Initial Catalog=QLSinhVien;Integrated Security=True";

            // Câu lệnh SQL
            string query = "SELECT * FROM SinhVien";

            // Tạo kết nối và lấy dữ liệu
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }

        void showTable(String name)
        {
            string query = "SELECT * FROM " + name;

            // Tạo kết nối và lấy dữ liệu
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showTable("Diem");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showTable("SinhVien");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showTable("MonHoc");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showTable("Lop");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showTable("Nganh");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showTable("Khoa");
        }

        private void comboBoxNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNganh.SelectedValue != null)
            {
                string maNganh = comboBoxNganh.SelectedValue.ToString();
                string query = @"SELECT SV.MSSV, SV.HoTen, L.TenLop, N.TenNganh, K.TenKhoa
                         FROM SinhVien SV
                         JOIN Lop L ON SV.MaLop = L.MaLop
                         JOIN Nganh N ON L.MaNganh = N.MaNganh
                         JOIN Khoa K ON N.MaKhoa = K.MaKhoa
                         WHERE N.MaNganh = @MaNganh";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaNganh", maNganh);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }


        private void LoadNganh()
        {
            string query = "SELECT MaNganh, TenNganh FROM Nganh";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxNganh.DataSource = dt;
                comboBoxNganh.DisplayMember = "TenNganh";  // Hiển thị trên giao diện
                comboBoxNganh.ValueMember = "MaNganh";     // Giá trị bên trong (dùng để truy vấn)
            }
        }

        private void LoadKhoa()
        {
            string query = "SELECT MaKhoa, TenKhoa FROM Khoa";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxKhoa.DataSource = dt;
                comboBoxKhoa.DisplayMember = "TenKhoa";
                comboBoxKhoa.ValueMember = "MaKhoa";
            }

            // Khi load khoa xong thì load ngành tương ứng luôn
            comboBoxKhoa.SelectedIndexChanged += comboBoxKhoa_SelectedIndexChanged;
        }

        private void LoadNganhTheoKhoa(string maKhoa)
        {
            string query = "SELECT MaNganh, TenNganh FROM Nganh WHERE MaKhoa = @MaKhoa";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaKhoa", maKhoa);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxNganh.DataSource = dt;
                comboBoxNganh.DisplayMember = "TenNganh";
                comboBoxNganh.ValueMember = "MaNganh";
            }
        }



        private void comboBoxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKhoa.SelectedValue != null)
            {
                string maKhoa = comboBoxKhoa.SelectedValue.ToString();
                LoadNganhTheoKhoa(maKhoa);
            }
        }
    }
}
