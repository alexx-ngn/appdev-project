using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y.controller
{
    internal class LoginSystem
    {
        private static Dictionary<String, String> UserCredentials { get; set; } = new Dictionary<String, String>();
        private static List<UserAccount> UserAccounts { get; set; } = ReportSystem.GetUserAccounts();
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
    }
}
