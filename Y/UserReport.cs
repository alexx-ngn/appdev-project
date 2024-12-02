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
        public UserReport(int reportingUserId, string reason, int reportedUserId) : base(reportingUserId, reason)
        {
            Id = idCount++;
            ReportedUserId = reportedUserId;
        }
    }
}
