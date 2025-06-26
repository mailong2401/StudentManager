using System.Data.SQLite;
using System.IO;
    public static class Database
    {
        private static string dbFile = "mydb.sqlite";
        private static string connectionString = $"Data Source={dbFile};Version=3;";
    public static SQLiteConnection GetConnection()
    {
        string sourceFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "temple", "mydb.sqlite");

        try
        {
            if (!File.Exists(dbFile))
            {
                if (File.Exists(sourceFile))
                {
                    File.Copy(sourceFile, dbFile);
                }
                else
                {
                    SQLiteConnection.CreateFile(dbFile);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi khi chuẩn bị database: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

