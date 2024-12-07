using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Y.controller
{
    /// <summary>
    /// Singleton class responsible for managing user accounts, admin accounts, reports, and posts.
    /// Provides methods to handle CRUD operations on database entities related to reports and accounts.
    /// </summary>
    public class ReportSystem
    {
        // Singleton instance
        private static ReportSystem _instance;

        // Lock for thread-safe singleton instantiation
        private static readonly object _lock = new object();

        // In-memory collections for user accounts, admin accounts, post reports, and user reports
        private List<UserAccount> UserAccounts { get; set; } = new List<UserAccount>();
        private List<AdminAccount> AdminAccounts { get; set; } = new List<AdminAccount>();
        public List<PostReport> PostReports { get; set; } = new List<PostReport>();
        public List<UserReport> UserReports { get; set; } = new List<UserReport>();

        // Private constructor to enforce singleton pattern
        private ReportSystem() { }

        /// <summary>
        /// Gets the singleton instance of ReportSystem, creating it if it doesn't exist.
        /// </summary>
        public static ReportSystem Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new ReportSystem();
                        }
                    }
                }
                return _instance;
            }
        }

        /// <summary>
        /// Establishes a connection to the SQLite database.
        /// </summary>
        /// <returns>An open SQLiteConnection object.</returns>
        private SQLiteConnection GetConnection()
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"database\Y_DB.sqlite");
            string connectionString = $@"Data Source={databasePath};";
            return new SQLiteConnection(connectionString);
        }

        /// <summary>
        /// Adds a new user to the database and in-memory list.
        /// </summary>
        /// <param name="user">The user to be added.</param>
        public void AddUser(UserAccount user)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    // Insert user into the database
                    string query = "INSERT INTO UserAccount (id, name, email, password, followerCount) VALUES (@id, @name, @email, @password, @followerCount)";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", user.Id);
                        command.Parameters.AddWithValue("@name", user.Name);
                        command.Parameters.AddWithValue("@email", user.Email);
                        command.Parameters.AddWithValue("@password", user.Password);
                        command.Parameters.AddWithValue("@followerCount", user.FollowerCount);
                        command.ExecuteNonQuery();
                    }

                    // Update in-memory collection
                    UserAccounts.Add(user);

                    // Register user credentials for login
                    LoginSystem.Instance.AddUserCredentials(user.Name, user.Password);

                    MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Removes a user from the database and in-memory list.
        /// Also removes associated posts and credentials.
        /// </summary>
        /// <param name="id">The ID of the user to remove.</param>
        public void RemoveUser(int id)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    // Remove user from database
                    string query = "DELETE FROM UserAccount WHERE id = @id";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }

                    // Remove associated posts
                    query = "DELETE FROM Post WHERE account_id = @id";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }

                    // Update in-memory collections
                    var userToRemove = UserAccounts.FirstOrDefault(u => u.Id == id);
                    if (userToRemove != null)
                    {
                        UserAccounts.Remove(userToRemove);
                    }

                    // Remove credentials and related data
                    LoginSystem.Instance.RemoveUserCredentials(id);
                    LoginSystem.Instance.RemoveUser(id);
                    UserOverviewSystem.Instance.removePostsFromUserId(id);

                    MessageBox.Show("User removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error removing user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Retrieves all posts by a specific user from the database.
        /// </summary>
        /// <param name="id">The ID of the user.</param>
        /// <returns>A list of posts by the user.</returns>
        public List<Post> getUserPosts(int id)
        {
            List<Post> userPosts = new List<Post>();
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Post WHERE account_id = @accountId";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@accountId", id);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int postId = Convert.ToInt32(reader["id"]);
                                string text = reader["text"].ToString();
                                DateTime date = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(reader["date"])).DateTime;
                                int likes = Convert.ToInt32(reader["likes"]);
                                int accountId = Convert.ToInt32(reader["account_id"]);
                                Post post = new Post(postId, text, likes, date, accountId);
                                userPosts.Add(post);
                            }
                        }
                        return userPosts;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading user posts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return userPosts;
        }
        // ... Rest of the methods follow similar structure and will also have detailed comments.
    }
}
