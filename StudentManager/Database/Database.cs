using System.Data.SQLite;
using System.IO;
    public static class Database
    {
        private static string dbFile = "mydb.sqlite";
        private static string connectionString = $"Data Source={dbFile};Version=3;";
        public static SQLiteConnection GetConnection()
        {
            // Tạo file nếu chưa tồn tại
            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);
            }

            return new SQLiteConnection(connectionString);
        }

        public static void OpenConnection(SQLiteConnection conn)
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
        }

        public static void CloseConnection(SQLiteConnection conn)
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }
    }

