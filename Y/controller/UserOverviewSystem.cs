using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Y.controller
{
    internal class UserOverviewSystem
    {
        // Singleton instance to ensure a single shared object for the system
        private static UserOverviewSystem _instance;
        private static readonly object _lock = new object();

        // Properties holding user accounts and posts data
        public List<UserAccount> UserAccounts { get; private set; } // List of all user accounts
        public List<Post> UserPosts { get; private set; } // List of all user posts
        public int CurrentUserId { get; set; } // ID of the currently logged-in user

        /// <summary>
        /// Private constructor for singleton pattern.
        /// Initializes user accounts and posts by loading them from the database.
        /// </summary>
        private UserOverviewSystem()
        {
            UserAccounts = LoadUsers(); // Load users from database
            UserPosts = LoadPosts(); // Load posts from database
        }

        /// <summary>
        /// Public accessor for the singleton instance.
        /// Ensures thread-safe access and lazy initialization.
        /// </summary>
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

        /// <summary>
        /// Creates a connection to the SQLite database.
        /// </summary>
        /// <returns>An SQLite connection object.</returns>
        private SQLiteConnection GetConnection()
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"database\Y_DB.sqlite");
            string connectionString = $@"Data Source={databasePath};";
            return new SQLiteConnection(connectionString);
        }

        /// <summary>
        /// Loads all posts from the database into a list.
        /// </summary>
        /// <returns>A list of posts loaded from the database.</returns>
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
                            // Parse post fields from the database
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

        /// <summary>
        /// Loads all user accounts from the database into a list.
        /// </summary>
        /// <returns>A list of user accounts loaded from the database.</returns>
        private List<UserAccount> LoadUsers()
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
                            // Parse user fields from the database
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
            }
        }

        /// <summary>
        /// Reloads the user accounts and posts from the database.
        /// </summary>
        public void ReloadUsers()
        {
            UserPosts = LoadPosts();
            UserAccounts = LoadUsers();
        }

        /// <summary>
        /// Retrieves the username associated with a specific post.
        /// </summary>
        /// <param name="postId">The ID of the post.</param>
        /// <returns>The username of the post's owner.</returns>
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

        /// <summary>
        /// Adds a new post to the database and updates the local list.
        /// </summary>
        /// <param name="post">The post to add.</param>
        public void AddPost(Post post)
        {
            using (SQLiteConnection connection = GetConnection())
            {
                connection.Open();
                string query = @"
                    INSERT INTO Post (text, date, likes, account_id) 
                    VALUES (@text, @date, @likes, @account_id)";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@text", post.Text);
                    command.Parameters.AddWithValue("@date", new DateTimeOffset(post.DatePosted).ToUnixTimeSeconds());
                    command.Parameters.AddWithValue("@likes", post.Likes);
                    command.Parameters.AddWithValue("@account_id", post.accountId);
                    command.ExecuteNonQuery();
                }
            }
            UserPosts.Add(post);
        }

        /// <summary>
        /// Removes a post from the database and local list.
        /// </summary>
        /// <param name="post">The post to remove.</param>
        public void removePost(Post post)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM Post WHERE id = @id";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", post.Id);
                        command.ExecuteNonQuery();
                    }
                    UserPosts.Remove(post);
                    MessageBox.Show("Post removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error removing post: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Removes all posts matching the specified post ID.
        /// </summary>
        /// <param name="reportedPostId">The ID of the post to remove.</param>
        public void removePosts(int reportedPostId)
        {
            UserPosts.RemoveAll(post => post.Id == reportedPostId);
        }

        /// <summary>
        /// Removes all posts from a specific user based on user ID.
        /// </summary>
        /// <param name="userId">The user ID whose posts will be removed.</param>
        public void removePostsFromUserId(int userId)
        {
            UserPosts.RemoveAll(post => post.accountId == userId);
        }

        /// <summary>
        /// Updates the like count for a specific post in the database.
        /// </summary>
        /// <param name="post">The post to update.</param>
        public void updateLikes(Post post)
        {
            using (SQLiteConnection connection = GetConnection())
            {
                connection.Open();
                string query = @"
                    UPDATE Post
                    SET likes = @likes
                    WHERE id = @postId";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@likes", post.Likes);
                    command.Parameters.AddWithValue("@postId", post.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
