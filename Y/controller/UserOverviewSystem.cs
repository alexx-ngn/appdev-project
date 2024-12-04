using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Y.controller
{
    internal class UserOverviewSystem
    {
        // Singleton instance
        private static UserOverviewSystem _instance;
        private static readonly object _lock = new object();

        // Instance properties
        public List<UserAccount> UserAccounts { get; private set; }
        public List<Post> UserPosts { get; private set; }

        // Private constructor
        private UserOverviewSystem()
        {
            UserAccounts = LoadUsers();
            UserPosts = LoadPosts();
        }

        // Public accessor for the singleton instance
        public static UserOverviewSystem Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new UserOverviewSystem();
                        }
                    }
                }
                return _instance;
            }
        }

        // Instance methods
        private SQLiteConnection GetConnection()
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"database\Y_DB.sqlite");
            string connectionString = $@"Data Source={databasePath};";
            return new SQLiteConnection(connectionString);
        }

        private List<Post> LoadPosts()
        {
            using (SQLiteConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Post";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count == 0)
                    {
                        return new List<Post>();
                    }
                }

                var posts = new List<Post>();
                query = "SELECT * FROM Post";
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
                            posts.Add(post);
                        }
                    }
                }
                return posts;
            }
        }

        private List<UserAccount> LoadUsers()
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
                            return new List<UserAccount>();
                        }
                    }

                    var users = new List<UserAccount>();
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
                                users.Add(user);
                            }
                        }
                    }
                    return users;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<UserAccount>();
            }
        }
    }
}
