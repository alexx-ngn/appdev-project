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
        private static Dictionary<String, String> UserCredentials { get; set; } = new Dictionary<String, String>();
        private static List<UserAccount> UserAccounts { get; set; } = new List<UserAccount>();
        public static void AddUserCredentials(String username, String password)
        {
            UserCredentials.Add(username, password);
        }
        public static bool ValidateUser(String userName, String password)
        {
            if (UserCredentials.ContainsKey(userName))
            {
                return UserCredentials[userName] == password;
            }
            return false;
        }

        public static int FetchUserIdFromUsername(String username)
        {
            for (int i = 0; i < UserAccounts.Count; i++)
            {
                if (UserAccounts[i].Name == username)
                {
                    return UserAccounts[i].Id;
                }
            }
            return -1;
        }

        private static SQLiteConnection GetConnection()
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"database\Y_DB.sqlite");
            //string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True;";
            string connectionString = $@"Data Source={databasePath};";
            return new SQLiteConnection(connectionString);
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

        public static List<UserAccount> GetUserAccounts()
        {
            return UserAccounts;
        }
    }
}
