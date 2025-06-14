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
    }
}
