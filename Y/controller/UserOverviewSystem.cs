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
        public static List<UserAccount> UserAccounts { get; set; } = new List<UserAccount>();
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
                            DateTime date = DateTimeOffset.FromUnixTimeSeconds(reader.GetInt64(2)).DateTime;
                            int likes = reader.GetInt32(3);
                            int accountId = reader.GetInt32(4);
                            Post post = new Post(id, text, likes, date);
                            UserPosts.Add(post);
                        }
                    }
                }
            }
        }
        public static void LoadUsers()
        {
            try
            {
                using (SQLiteConnection connection = GetConnection())
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM UserAccount";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        if (count == 0)
                        {
                            return;
                        }
                    }

                    query = "SELECT * FROM UserAccount";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["id"]);
                                string name = reader["name"].ToString();
                                string email = reader["email"].ToString();
                                string password = reader["password"].ToString();
                                int followerCount = Convert.ToInt32(reader["followerCount"]);

                                UserAccount user = new UserAccount(id, name, email, password, followerCount);
                                UserAccounts.Add(user);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
