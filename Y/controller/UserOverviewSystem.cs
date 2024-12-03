using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y.controller
{
    internal class UserOverviewSystem
    {
        public static List<UserAccount> UserAccounts { get; set; } = ReportSystem.GetUserAccounts();
        public static List<Post> UserPosts { get; set; } = new List<Post>();

        private static SQLiteConnection GetConnection()
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"database\Y_DB.sqlite");
            //string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True;";
            string connectionString = $@"Data Source={databasePath};";
            return new SQLiteConnection(connectionString);
        }

        public static void LoadPosts()
        {
            UserPosts.Clear();
            using (SQLiteConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Post";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string text = reader.GetString(1);
                            Post post = new Post(id, text);
                            UserPosts.Add(post);
                        }
                    }
                }
            }
        }
    }
}
