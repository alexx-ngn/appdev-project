﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Y.controller
{
    public class ReportSystem
    {
        private static ReportSystem _instance;
        private static readonly object _lock = new object();

        private List<UserAccount> UserAccounts { get; set; } = new List<UserAccount>();
        private List<AdminAccount> AdminAccounts { get; set; } = new List<AdminAccount>();
        public List<PostReport> PostReports { get; set; } = new List<PostReport>();
        public List<UserReport> UserReports { get; set; } = new List<UserReport>();

        private ReportSystem() { }

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

        private SQLiteConnection GetConnection()
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"database\Y_DB.sqlite");
            string connectionString = $@"Data Source={databasePath};";
            return new SQLiteConnection(connectionString);
        }

        public void AddUser(UserAccount user)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();

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

                    UserAccounts.Add(user);
                    LoginSystem.Instance.AddUserCredentials(user.Name, user.Password);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void RemoveUser(int id)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM UserAccount WHERE id = @id";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }

                    query = "DELETE FROM Post WHERE account_id = @id";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }

                    var userToRemove = UserAccounts.FirstOrDefault(u => u.Id == id);
                    if (userToRemove != null)
                    {
                        UserAccounts.Remove(userToRemove);
                    }

                    LoginSystem.Instance.RemoveUserCredentials(id);
                    LoginSystem.Instance.RemoveUser(id);
                    UserOverviewSystem.Instance.removePostsFromUserId(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error removing user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

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

        public void removePost(int reportedPostId)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM Post WHERE id = @id";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", reportedPostId);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error removing post: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void LoadUsers()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    string query = "SELECT * FROM UserAccount";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["id"]);
                                string name = reader["name"].ToString();
                                string email = reader["email"].ToString();
                                string password = reader["password"].ToString();
                                int followerCount = Convert.ToInt32(reader["followerCount"]);

                                UserAccounts.Add(new UserAccount(id, name, email, password, followerCount));
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

        public void loadUserReports()
        {
            UserReports.Clear();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    string query = "SELECT * FROM UserReport";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["id"]);
                                int reportingUserId = Convert.ToInt32(reader["reportingUserId"]);
                                string reason = reader["reason"].ToString();
                                int reportedUserId = Convert.ToInt32(reader["reportedUserId"]);
                                DateTime dateTime = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(reader["date"])).DateTime;
                                dateTime = TimeZoneInfo.ConvertTimeFromUtc(dateTime, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"));

                                var userReport = new UserReport(id, reportingUserId, reason, reportedUserId, dateTime);
                                UserReports.Add(userReport);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user reports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadPostReports()
        {
            PostReports.Clear();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    string query = "SELECT * FROM PostReport";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["id"]);
                                int reportingUserId = Convert.ToInt32(reader["reportingUserId"]);
                                string reason = reader["reason"].ToString();
                                int reportedPostId = Convert.ToInt32(reader["reportedPostId"]);
                                DateTime dateTime = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(reader["date"])).DateTime;
                                dateTime = TimeZoneInfo.ConvertTimeFromUtc(dateTime, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"));

                                var postReport = new PostReport(id, reportingUserId, reason, dateTime, reportedPostId);
                                PostReports.Add(postReport);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading post reports: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int GetLastUserID()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    string query = "SELECT MAX(id) FROM UserAccount";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        return result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting last user ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public UserReport getUserReportFromId(int id)
        {
            for (int i = 0; i < UserReports.Count; i++)
            {
                if (UserReports[i].Id == id)
                {
                    return UserReports[i];
                }
            }
            return null;
        }

        public PostReport getPostReportFromId(int id)
        {
            for (int i = 0; i < PostReports.Count; i++)
            {
                if (PostReports[i].Id == id)
                {
                    return PostReports[i];
                }
            }
            return null;
        }

        public void AddAdmin(AdminAccount admin)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO AdminAccount (id, name, email, password) VALUES (@id, @name, @email, @password)";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", admin.Id);
                        command.Parameters.AddWithValue("@name", admin.Name);
                        command.Parameters.AddWithValue("@email", admin.Email);
                        command.Parameters.AddWithValue("@password", admin.Password);
                        command.ExecuteNonQuery();
                    }

                    AdminAccounts.Add(admin);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error adding admin: {ex.Message}");
                }
            }
        }

        public void RemoveAdmin(AdminAccount admin)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM AdminAccount WHERE id = @id";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", admin.Id);
                        command.ExecuteNonQuery();
                    }

                    AdminAccounts.Remove(admin);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error removing admin: {ex.Message}");
                }
            }
        }

        public int GetLastAdminID()
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
                            return 0;
                        }
                    }

                    query = "SELECT MAX(id) FROM AdminAccount";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting last admin ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }


        public void FileReport(Report report)
        {
            using (SQLiteConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = string.Empty;

                    if (report is UserReport userReport)
                    {
                        // UserReport: Insert into UserReport table
                        query = "INSERT INTO UserReport (reportingUserId, reason, reportedUserId, date) VALUES (@reportingUserId, @reason, @reportedUserId, @date)";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@reportingUserId", userReport.ReportingUserId);
                            command.Parameters.AddWithValue("@reason", userReport.Reason);
                            command.Parameters.AddWithValue("@reportedUserId", userReport.ReportedUserId);
                            command.Parameters.AddWithValue("@date", new DateTimeOffset(userReport.DateReported).ToUnixTimeSeconds());
                            command.ExecuteNonQuery();
                        }
                        UserReports.Add(report as UserReport);
                    }
                    else if (report is PostReport postReport)
                    {
                        query = "INSERT INTO PostReport (reportingUserId, reason, reportedPostId, date) VALUES (@reportingUserId, @reason, @reportedPostId, @date)";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@reportingUserId", postReport.ReportingUserId);
                            command.Parameters.AddWithValue("@reason", postReport.Reason);
                            command.Parameters.AddWithValue("@reportedPostId", postReport.ReportedPostId);
                            command.Parameters.AddWithValue("@date", new DateTimeOffset(postReport.DateReported).ToUnixTimeSeconds());

                            command.ExecuteNonQuery();
                        }
                        PostReports.Add(report as PostReport);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error filing report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void removeReport(Report report)
        {
            using (SQLiteConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = string.Empty;
                    if (report is UserReport userReport)
                    {
                        // UserReport: Delete from UserReport table
                        query = "DELETE FROM UserReport WHERE id = @id";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", userReport.Id);
                            command.ExecuteNonQuery();
                        }
                        UserReports.Remove(userReport);
                    }
                    else if (report is PostReport postReport)
                    {
                        // PostReport: Delete from PostReport table
                        query = "DELETE FROM PostReport WHERE id = @id";
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", postReport.Id);
                            command.ExecuteNonQuery();
                        }
                        PostReports.Remove(postReport);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error removing report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Post getPostFromId(int id)
        {
            using (SQLiteConnection connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Post WHERE id = @id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int postId = Convert.ToInt32(reader["id"]);
                            string text = reader["text"].ToString();
                            DateTime date = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(reader["date"])).DateTime;
                            int likes = Convert.ToInt32(reader["likes"]);
                            int accountId = Convert.ToInt32(reader["account_id"]);
                            Post post = new Post(postId, text, likes, date, accountId);
                            return post;
                        }
                    }
                }
            }
            return null;
        }

        public List<UserAccount> GetUserAccounts()
        {
            return new List<UserAccount>(UserAccounts);
        }
    }
}