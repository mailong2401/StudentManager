using System.Drawing.Drawing2D;
using System.Data.SqlClient;

namespace StudentManager
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            // xuất hiện chính giữa màn hình khi mở app
            this.StartPosition = FormStartPosition.CenterScreen; 


        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Thay Database=qlsv bằng tên database của bạn DataBase=ten-database
            // Nếu đăng nhập server bằng mật khẩu thì 

            //string connectionString = "Server=localhost;Database=qlsv;User Id=myUsername;Password=myPassword;";
            string connectionString = "Server=localhost;Database=qlsv;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Password FROM Users WHERE Username = @Username";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", inputAcc.Text);

                        object result = command.ExecuteScalar(); // chỉ lấy 1 giá trị

                        if (result != null)
                        {
                            string passwordInDatabase = result.ToString();
                            string inputPassword = inputPass.Text; // nếu bạn chưa mã hóa
                                                                 // Nếu bạn có dùng HashPassword thì:
                                                                 // string inputPassword = HashPassword(tb_pass.Text);

                            if (passwordInDatabase == inputPassword)
                            {
                                
                                // TODO: chuyển sang màn hình chính ở đây

                                // Ẩn form login
                                this.Hide();
                                // Mở form mới ten-form mainForm = new ten-form();
                                fAdmin mainForm = new fAdmin();
                                mainForm.ShowDialog();

                                // Sau khi form main đóng thì đóng luôn chương trình
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Sai mật khẩu! Vui lòng thử lại.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy tài khoản!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
