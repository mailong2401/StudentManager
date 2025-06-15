using StudentManager.model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.DAO
{
    public class ClassDao
    {
        // Lấy tất cả môn học
        public static List<Class> GetAll()
        {
            var list = new List<Class>();
            using (var conn = Database.GetConnection())
            {
                Database.OpenConnection(conn);
                string sql = "SELECT * FROM Lop";
                var cmd = new SQLiteCommand(sql, conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Class
                    {
                        Id = reader["MaLop"].ToString(),
                        Name = reader["TenLop"].ToString(),
                        nameNganh= reader["MaNganh"].ToString(),
                    });
                }

                Database.CloseConnection(conn);
            }

            return list;
        }

        // Cập nhật lớp
        public static bool Update(Class lop)
        {
            using (var conn = Database.GetConnection())
            {
                Database.OpenConnection(conn);
                string sql = @"UPDATE Lop 
                       SET TenLop = @TenLop, MaNganh = @MaNganh 
                       WHERE MaLop = @MaLop";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenLop", lop.Name);
                cmd.Parameters.AddWithValue("@MaNganh", lop.nameNganh);
                cmd.Parameters.AddWithValue("@MaLop", lop.Id);

                int rowsAffected = cmd.ExecuteNonQuery();
                Database.CloseConnection(conn);
                return rowsAffected > 0;
            }
        }

        // Xóa lớp theo mã lớp
        public static bool Delete(string id)
        {
            using (var conn = Database.GetConnection())
            {
                Database.OpenConnection(conn);
                string sql = "DELETE FROM Lop WHERE MaLop = @MaLop";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaLop", id);

                int rowsAffected = cmd.ExecuteNonQuery();
                Database.CloseConnection(conn);
                return rowsAffected > 0;
            }
        }


        public static List<Class> FindByKeyword(string keyword)
        {
            var list = new List<Class>();
            using (var conn = Database.GetConnection())
            {
                Database.OpenConnection(conn);

                string sql = @"SELECT * FROM Lop 
                       WHERE MaLop LIKE @kw OR TenLop LIKE @kw";

                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Class
                    {
                        Id = reader["MaLop"].ToString(),
                        Name = reader["TenLop"].ToString(),
                        nameNganh = reader["MaNganh"].ToString(),
                    });
                }

                Database.CloseConnection(conn);
            }

            return list;
        }


    }
}
