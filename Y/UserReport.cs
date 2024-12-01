using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y
{
    public class UserReport : Report
    {
        private int ReportedUserId { get; set; }
        public UserReport(int reportingUserId, string reason, int reportedUserId) : base(reportingUserId, reason)
        {
            ReportedUserId = reportedUserId;
        }
    }
}
