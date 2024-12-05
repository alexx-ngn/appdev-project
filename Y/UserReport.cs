using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y
{
    public class UserReport : Report
    {
        public int ReportedUserId { get; set; }
        private static int idCount = 1;
        private DateTime dateTime;

        public UserReport(int reportingUserId, string reason, int reportedUserId) : base(reportingUserId, reason)
        {
            Id = idCount++;
            ReportedUserId = reportedUserId;
        }

        public UserReport(int id, int reportingUserId, string reason, int reportedUserId, DateTime dateTime) : base(id, reportingUserId, reason)
        {
            ReportedUserId = reportedUserId;
            this.dateTime = dateTime;
        }
    }
}
