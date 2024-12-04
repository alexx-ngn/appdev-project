using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Y.Controller
{
    internal class LoginSystem
    {
        // Singleton instance
        private static LoginSystem _instance;
        private static readonly object _lock = new object();

        // Instance properties
        private Dictionary<string, string> UserCredentials { get; } = new Dictionary<string, string>();
        private List<UserAccount> UserAccounts { get; } = new List<UserAccount>();

        // Private constructor
        private LoginSystem() { }

        // Public accessor for the singleton instance
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
        /// Adds a new user's credentials securely.
        /// </summary>
        public void AddUserCredentials(string username, string password)
        {
            if (UserCredentials.ContainsKey(username))
            {
                MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedPassword = HashPassword(password);
            UserCredentials[username] = hashedPassword;
        }

        /// <summary>
        /// Validates a user's credentials against stored data.
        /// </summary>
        public bool ValidateUser(string username, string password)
        {
            if (UserCredentials.TryGetValue(username, out string storedHashedPassword))
            {
                return VerifyPassword(password, storedHashedPassword);
            }
            return false;
        }

        /// <summary>
        /// Fetches the User ID for a given username.
        /// </summary>
        public int FetchUserIdFromUsername(string username)
        {
            foreach (var user in UserAccounts)
            {
                if (user.Name.Equals(username, StringComparison.OrdinalIgnoreCase))
                {
                    return user.Id;
                }
            }
            return -1; // User not found
        }

        /// <summary>
        /// Loads users from the database into in-memory structures.
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

                                // Populate credentials dictionary
                                UserCredentials[name] = password;
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
        /// Retrieves all loaded user accounts.
        /// </summary>
        public List<UserAccount> GetUserAccounts()
        {
            return new List<UserAccount>(UserAccounts);
        }

        /// <summary>
        /// Hashes a password securely using SHA256.
        /// </summary>
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        /// <summary>
        /// Verifies a password against a stored hash.
        /// </summary>
        private bool VerifyPassword(string password, string hashedPassword)
        {
            string hashOfInput = HashPassword(password);
            return hashOfInput.Equals(hashedPassword);
        }

        /// <summary>
        /// Creates and returns a SQLite connection object.
        /// </summary>
        private SQLiteConnection GetConnection()
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"database\Y_DB.sqlite");
            string connectionString = $@"Data Source={databasePath};";
            return new SQLiteConnection(connectionString);
        }
    }
}
