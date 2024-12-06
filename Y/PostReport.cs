using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y
{
    public class PostReport : Report
    {
        public int ReportedPostId { get; set; }
        private static int idCount = 1;
        private int reportedUserId;
        private DateTime dateTime;

        //public PostReport(int reportingUserId, string reason, int reportedPostId) : base(reportingUserId, reason)
        //{
        //    Id = idCount++;
        //    ReportedPostId = reportedPostId;
        //}

        public PostReport(int id, int reportingUserId, string reason, DateTime dateReported, int reportedPostId) : base(id, reportingUserId, reason, dateReported)
        {
            ReportedPostId = reportedPostId;
        }

        public PostReport(int reportingUserId, string reason, int reportedPostId) : base(reportingUserId, reason)
        {
            ReportedPostId = reportedPostId;
        }
    }
}
