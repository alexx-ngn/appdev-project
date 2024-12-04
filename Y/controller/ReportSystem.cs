using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Y.controller
{
    public class ReportSystem
    {
        private static ReportSystem _instance;
        private static readonly object Lock = new object();

        private List<UserAccount> UserAccounts { get; set; } = new List<UserAccount>();
        private List<AdminAccount> AdminAccounts { get; set; } = new List<AdminAccount>();
        private Queue<Report> OpenReports { get; set; } = new Queue<Report>();
        private Queue<Report> ProcessingReports { get; set; } = new Queue<Report>();
        private List<Report> ClosedReports { get; set; } = new List<Report>();

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
                    MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void RemoveUser(UserAccount user)
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM UserAccount WHERE id = @id";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", user.Id);
                        command.ExecuteNonQuery();
                    }

                    UserAccounts.Remove(user);
                    MessageBox.Show("User removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error removing user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public List<UserAccount> GetUserAccounts()
        {
            return new List<UserAccount>(UserAccounts);
        }
    }
}
