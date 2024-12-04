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
                            DateTime date = DateTimeOffset.FromUnixTimeSeconds(reader.GetInt64(2)).UtcDateTime;
                            date = TimeZoneInfo.ConvertTimeFromUtc(date, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"));
                            int likes = reader.GetInt32(3);
                            int accountId = reader.GetInt32(4);
                            Post post = new Post(id, text, likes, date, accountId);
                            posts.Add(post);
                        }
                    }
                }
                return posts;
            }
        }

        private List<UserAccount> LoadUsers()
        {
            //try
            //{
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
                    return users;
                }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show($"Error loading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return new List<UserAccount>();
                //}
            }
        }

        public String GetPostUsername(int postId)
        {
            using (SQLiteConnection connection = GetConnection())
            {
                connection.Open();
                string query = @"
                    SELECT UserAccount.name 
                    FROM Post 
                    INNER JOIN UserAccount ON Post.account_id = UserAccount.id 
                    WHERE Post.id = @postId";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@postId", postId);
                    object result = command.ExecuteScalar();
                    return result != null ? result.ToString() : null;
                }
            }
        }

        public void AddPost(Post post)
        {
            UserPosts.Add(post);
            using (SQLiteConnection connection = GetConnection())
            {
                connection.Open();
                string query = @"
                    INSERT INTO Post (text, date, likes, account_id) 
                    VALUES (@text, @date, @likes, @account_id)";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    //command.Parameters.AddWithValue("@id", post.Id);
                    command.Parameters.AddWithValue("@text", post.Text);
                    command.Parameters.AddWithValue("@date", new DateTimeOffset(post.DatePosted).ToUnixTimeSeconds());
                    command.Parameters.AddWithValue("@likes", post.Likes);
                    command.Parameters.AddWithValue("@account_id", post.accountId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
