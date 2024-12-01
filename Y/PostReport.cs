using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y
{
    public class PostReport : Report
    {
        private int ReportedPostId { get; set; }
        public PostReport(int reportingUserId, string reason, int reportedPostId) : base(reportingUserId, reason)
        {
            ReportedPostId = reportedPostId;
        }
    }
}
