using StudentManager.model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.DAO
{
    public class DepartmenDAO
    {
        public static List<UniversityDepartment> GetAll()
        {
            var list = new List<UniversityDepartment>();
            using (var conn = Database.GetConnection())
            {
                Database.OpenConnection(conn);
                string sql = "SELECT * FROM Khoa";
                var cmd = new SQLiteCommand(sql, conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new UniversityDepartment
                    {
                        Id = reader["maKhoa"].ToString(),
                        Name = reader["tenKhoa"].ToString(),
                    });
                }

                Database.CloseConnection(conn);
            }

            return list;
        }
    }
}
