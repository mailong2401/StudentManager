using StudentManager.model;
using System.Data.SQLite;

namespace StudentManager.DAO
{
    public class SubjectDao
    {
        // Lấy tất cả môn học
        public static List<Subject> GetAll()
        {
            var list = new List<Subject>();
            using (var conn = Database.GetConnection())
            {
                Database.OpenConnection(conn);
                string sql = "SELECT * FROM MonHoc";
                var cmd = new SQLiteCommand(sql, conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Subject
                    {
                        MaMon = reader["maMon"].ToString(),
                        TenMon = reader["tenMon"].ToString(),
                        SoTinChi = Convert.ToInt32(reader["SoTinChi"]),
                    });
                }

                Database.CloseConnection(conn);
            }

            return list;
        }

        public static bool Insert(Subject monHoc)
        {
            using (var conn = Database.GetConnection())
            {
                Database.OpenConnection(conn);
                string sql = @"INSERT INTO MonHoc (maMon, tenMon, SoTinChi) VALUES (@maMon, @tenMon, @SoTinChi)";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maMon", monHoc.MaMon);
                cmd.Parameters.AddWithValue("@tenMon", monHoc.TenMon);
                cmd.Parameters.AddWithValue("@SoTinChi", monHoc.SoTinChi);

                int rowsAffected = cmd.ExecuteNonQuery();
                Database.CloseConnection(conn);
                return rowsAffected > 0;
            }
        }

        public static bool Delete(string maMon)
        {
            using (var conn = Database.GetConnection())
            {
                Database.OpenConnection(conn);
                string sql = "DELETE FROM MonHoc WHERE maMon = @maMon";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maMon", maMon);

                int rowsAffected = cmd.ExecuteNonQuery();
                Database.CloseConnection(conn);
                return rowsAffected > 0;
            }
        }

        public static bool Update(Subject monHoc)
        {
            using (var conn = Database.GetConnection())
            {
                Database.OpenConnection(conn);
                string sql = @"UPDATE MonHoc 
                       SET tenMon = @tenMon, SoTinChi = @SoTinChi 
                       WHERE maMon = @maMon";

                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tenMon", monHoc.TenMon);
                cmd.Parameters.AddWithValue("@SoTinChi", monHoc.SoTinChi);
                cmd.Parameters.AddWithValue("@maMon", monHoc.MaMon); // Khóa chính

                int rowsAffected = cmd.ExecuteNonQuery();
                Database.CloseConnection(conn);
                return rowsAffected > 0;
            }
        }


    }
}
