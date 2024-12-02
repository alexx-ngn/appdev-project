using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y
{
    public class AdminAccount : Account
    {
        private static int idCount = 1;
        public AdminAccount(int id, string name, string email) : base(id, name, email)
        {
        }

        public AdminAccount(string name, string email) : base(name, email)
        {
            Id = idCount++;
        }

        public void removeReport(Report ticket)
        {          
        }

        public void ban(UserAccount account)
        {
            if (ReportSystem.GetUserAccounts().Contains(account))
            {
                ReportSystem.RemoveUser(account);
            }
        }
        public Report fetchNewReport()
        {
            Report report = ReportSystem.FetchNextOpenReport();
            if (report != null)
            {
                report.AssignAdmin(this.Id);
                changeReportStatus(report,Status.Processing);
                return report;
            } else
            {
                return null;
            }
        }

        public void changeReportStatus(Report report, Status status)
        {
            report.ChangeStatus(status);
        }

        public void closeReport(Report report)
        {
            changeReportStatus(report, Status.Closed);
            ReportSystem.FetchProcessingToClose();
        }

        public void assignReportTo(Report report, AdminAccount adminAccount)
        {
            report.AssignAdmin(adminAccount.Id);
        }
        public override void removePost(Post post)
        {
            UserAccount user = FindAccountWithPost(post); 
            user.removePost(post); 
        }

        private UserAccount FindAccountWithPost(Post post)
        {
            foreach (UserAccount user in ReportSystem.GetUserAccounts()) // Assuming GetUserAccounts fetches all users
            {
                if (user.GetPosts().Contains(post)) // Check if the user's posts contain the given post
                {
                    return user; // Return the user that owns the post
                }
            }
            return null; // Return null if no user owns the post
        }
    }
}
