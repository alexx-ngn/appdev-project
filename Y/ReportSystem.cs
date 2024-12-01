using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y
{
    public static class ReportSystem
    {
        private static List<UserAccount> UserAccounts { get; set; } = new List<UserAccount>();
        private static List<AdminAccount> AdminAccounts { get; set; } = new List<AdminAccount>();
        private static Queue<Report> OpenReports { get; set; } = new Queue<Report>();
        private static Queue<Report> ProcessingReports { get; set; } = new Queue<Report>();
        private static List<Report> ClosedReports { get; set; } = new List<Report>();

        public static void AddUser(UserAccount user)
        {
            UserAccounts.Add(user);
        }

        public static void RemoveUser(UserAccount user)
        {
            UserAccounts.Remove(user);
        }

        public static void AddAdmin(AdminAccount admin)
        {
            AdminAccounts.Add(admin);
        }

        public static void RemoveAdmin(AdminAccount admin)
        {
            AdminAccounts.Remove(admin);
        }

        public static void FileReport(Report report)
        {
            OpenReports.Enqueue(report);
        }

        public static Report FetchNextOpenReport()
        {
            if (OpenReports.Count > 0)
            {
                Report report = OpenReports.Dequeue();
                ProcessingReports.Enqueue(report);
                return report;
            }
            else
            {  
                return null;
            }
        }

        public static void FetchProcessingToClose()
        {
            Report report = ProcessingReports.Dequeue();
            ClosedReports.Add(report);
        }

        public static List<UserAccount> getUserAccount()
        {
            return UserAccounts;
        }

    }
}
