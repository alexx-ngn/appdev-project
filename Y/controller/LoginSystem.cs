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
    internal class LoginSystem
    {
        private static LoginSystem _instance;
        private static readonly object _lock = new object();

        private Dictionary<String, String> UserCredentials { get; set; } = new Dictionary<String, String>();
        private List<UserAccount> UserAccounts { get; set; } = new List<UserAccount>();

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

        public void AddUserCredentials(String username, String password)
        {
            UserCredentials.Add(username, password);
        }

        public bool ValidateUser(String userName, String password)
        {
            if (UserCredentials.ContainsKey(userName))
            {
                return UserCredentials[userName] == password;
            }
            return false;
        }

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

        private SQLiteConnection GetConnection()
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"database\Y_DB.sqlite");
            //string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True;";
            string connectionString = $@"Data Source={databasePath};";
            return new SQLiteConnection(connectionString);
        }

        public void LoadUsers()
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

        public List<UserAccount> GetUserAccounts()
        {
            return UserAccounts;
        }
    }
}