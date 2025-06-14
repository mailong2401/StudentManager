using StudentManager.model;
using System.Data.SQLite;

namespace StudentManager.DAO
{
    public class StudentDAO
    {
        public static List<Student> GetAll()
        {
            var list = new List<Student>();
            using (var conn = Database.GetConnection())
            {
                Database.OpenConnection(conn);
                string sql = "SELECT * FROM SinhVien";
                var cmd = new SQLiteCommand(sql, conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Student
                    {
                        MSSV = Convert.ToInt32(reader["MSSV"]),
                        HoTen = reader["HoTen"].ToString(),
                        NgaySinh = reader["NgaySinh"].ToString(),
                        GioiTinh = reader["GioiTinh"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        SoDienThoai = reader["SoDienThoai"].ToString(),
                        MaLop = reader["MaLop"].ToString()
                    });
                }

                Database.CloseConnection(conn);
            }

            return list;
        }
        public static bool Insert(Student sv)
        {
            using (var conn = Database.GetConnection())
            {
                Database.OpenConnection(conn);
                string sql = @"INSERT INTO SinhVien (MSSV, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, MaLop)
                           VALUES (@MSSV, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SoDienThoai, @MaLop)";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MSSV", sv.MSSV);
                cmd.Parameters.AddWithValue("@HoTen", sv.HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", sv.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", sv.GioiTinh);
                cmd.Parameters.AddWithValue("@DiaChi", sv.DiaChi);
                cmd.Parameters.AddWithValue("@SoDienThoai", sv.SoDienThoai);
                cmd.Parameters.AddWithValue("@MaLop", sv.MaLop);

                int rowsAffected = cmd.ExecuteNonQuery();
                Database.CloseConnection(conn);
                return rowsAffected > 0;
            }
        }

        // Cập nhật sinh viên
        public static bool Update(Student sv)
        {
            using (var conn = Database.GetConnection())
            {
                Database.OpenConnection(conn);
                string sql = @"UPDATE SinhVien SET
                           HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh,
                           DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, MaLop = @MaLop
                           WHERE MSSV = @MSSV";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@HoTen", sv.HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", sv.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", sv.GioiTinh);
                cmd.Parameters.AddWithValue("@DiaChi", sv.DiaChi);
                cmd.Parameters.AddWithValue("@SoDienThoai", sv.SoDienThoai);
                cmd.Parameters.AddWithValue("@MaLop", sv.MaLop);
                cmd.Parameters.AddWithValue("@MSSV", sv.MSSV);

                int rowsAffected = cmd.ExecuteNonQuery();
                Database.CloseConnection(conn);
                return rowsAffected > 0;
            }
        }

        // Xóa sinh viên
        public static bool Delete(int mssv)
        {
            using (var conn = Database.GetConnection())
            {
                Database.OpenConnection(conn);
                string sql = "DELETE FROM SinhVien WHERE MSSV = @MSSV";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MSSV", mssv);

                int rowsAffected = cmd.ExecuteNonQuery();
                Database.CloseConnection(conn);
                return rowsAffected > 0;
            }
        }

        // Tìm kiếm theo MSSV hoặc tên
        public static List<Student> Search(string keyword)
        {
            var list = new List<Student>();
            using (var conn = Database.GetConnection())
            {
                Database.OpenConnection(conn);
                string sql = "SELECT * FROM SinhVien WHERE HoTen LIKE @kw OR MSSV LIKE @kw";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kw", $"%{keyword}%");
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Student
                    {
                        MSSV = Convert.ToInt32(reader["MSSV"]),
                        HoTen = reader["HoTen"].ToString(),
                        NgaySinh = reader["NgaySinh"].ToString(),
                        GioiTinh = reader["GioiTinh"].ToString(),
                        DiaChi = reader["DiaChi"].ToString(),
                        SoDienThoai = reader["SoDienThoai"].ToString(),
                        MaLop = reader["MaLop"].ToString()
                    });
                }

                Database.CloseConnection(conn);
            }

            return list;
        }
    }
}
