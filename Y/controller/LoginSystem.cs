using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Y.controller
{
    /// <summary>
    /// Manages login functionality for both users and admins, including credential validation
    /// and database interaction for retrieving and managing account details.
    /// </summary>
    internal class LoginSystem
    {
        // Singleton instance of LoginSystem
        private static LoginSystem _instance;

        // Lock object to ensure thread safety for Singleton pattern
        private static readonly object _lock = new object();

        // Stores user credentials (username-password pairs)
        private Dictionary<String, String> UserCredentials { get; set; } = new Dictionary<String, String>();

        // Stores admin credentials (username-password pairs)
        private Dictionary<String, String> AdminCredentials { get; set; } = new Dictionary<String, String>();

        // List of user accounts loaded from the database
        private List<UserAccount> UserAccounts { get; set; } = new List<UserAccount>();

        // List of admin accounts loaded from the database
        private List<AdminAccount> AdminAccounts { get; set; } = new List<AdminAccount>();

        /// <summary>
        /// Singleton property to get the instance of LoginSystem.
        /// Ensures only one instance of this class exists.
        /// </summary>
        public static LoginSystem Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new LoginSystem();
                        }
                    }
                }
                return _instance;
            }
        }

        /// <summary>
        /// Adds a user's credentials to the dictionary.
        /// </summary>
        public void AddUserCredentials(String username, String password)
        {
            UserCredentials.Add(username, password);
        }

        /// <summary>
        /// Adds an admin's credentials to the dictionary.
        /// </summary>
        public void AddAdminCredentials(String username, String password)
        {
            AdminCredentials.Add(username, password);
        }

        /// <summary>
        /// Validates a user's credentials.
        /// </summary>
        /// <param name="userName">Username to validate.</param>
        /// <param name="password">Password to validate.</param>
        /// <returns>True if valid, false otherwise.</returns>
        public bool ValidateUser(String userName, String password)
        {
            return UserCredentials.ContainsKey(userName) && UserCredentials[userName] == password;
        }

        /// <summary>
        /// Validates an admin's credentials.
        /// </summary>
        /// <param name="userName">Admin username to validate.</param>
        /// <param name="password">Admin password to validate.</param>
        /// <returns>True if valid, false otherwise.</returns>
        public bool ValidateAdmin(String userName, String password)
        {
            return AdminCredentials.ContainsKey(userName) && AdminCredentials[userName] == password;
        }

        /// <summary>
        /// Fetches the user ID from the database based on their username.
        /// </summary>
        public int FetchUserIdFromUsername(String username)
        {
            try
            {
                using (SQLiteConnection connection = GetConnection())
                {
                    connection.Open();
                    string query = "SELECT id FROM UserAccount WHERE name = @username";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching user ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1; // Return -1 if user not found or error occurs
        }

        /// <summary>
        /// Fetches the admin ID from the database based on their username.
        /// </summary>
        public int FetchAdminIdFromUsername(String username)
        {
            try
            {
                using (SQLiteConnection connection = GetConnection())
                {
                    connection.Open();
                    string query = "SELECT id FROM AdminAccount WHERE name = @username";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching admin ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1; // Return -1 if admin not found or error occurs
        }

        /// <summary>
        /// Establishes a connection to the SQLite database.
        /// </summary>
        private SQLiteConnection GetConnection()
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"database\Y_DB.sqlite");
            string connectionString = $@"Data Source={databasePath};";
            return new SQLiteConnection(connectionString);
        }

        /// <summary>
        /// Loads user accounts from the database into memory.
        /// </summary>
        public void LoadUsers()
        {
            try
            {
                using (SQLiteConnection connection = GetConnection())
                {
                    connection.Open();
                    string query = "SELECT * FROM UserAccount";
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
                                AddUserCredentials(name, password);
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

        /// <summary>
        /// Loads admin accounts from the database into memory.
        /// </summary>
        public void LoadAdmins()
        {
            try
            {
                using (SQLiteConnection connection = GetConnection())
                {
                    connection.Open();
                    string query = "SELECT * FROM AdminAccount";
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

                                AdminAccount admin = new AdminAccount(id, name, email, password);
                                AdminAccounts.Add(admin);
                                AddAdminCredentials(name, password);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading admins: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Retrieves all user accounts currently loaded.
        /// </summary>
        public List<UserAccount> GetUserAccounts()
        {
            return UserAccounts;
        }

        /// <summary>
        /// Retrieves all admin accounts currently loaded.
        /// </summary>
        public List<AdminAccount> GetAdminAccounts()
        {
            return AdminAccounts;
        }

        /// <summary>
        /// Removes user credentials based on their ID.
        /// </summary>
        public void RemoveUserCredentials(int id)
        {
            var user = UserAccounts.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                UserCredentials.Remove(user.Name);
                UserAccounts.Remove(user);
            }
        }

        /// <summary>
        /// Removes a user from the list based on their ID.
        /// </summary>
        public void RemoveUser(int id)
        {
            var user = UserAccounts.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                UserAccounts.Remove(user);
            }
        }
    }
}
