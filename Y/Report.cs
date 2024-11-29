using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y
{
    internal abstract class Report
    {
        private int Id {  get; set; }
        private int AdminId { get; set; }
        private int ReportingUserId { get; set; }
        private String Reason { get; set; }
        private String Status { get; set; }
        private DateTime DateReported { get;}

        protected Report(int id, int adminId, int reportingUserId, string reason, string status)
        {
            Id = id;
            AdminId = adminId;
            ReportingUserId = reportingUserId;
            Reason = reason;
            Status = status;
            DateReported = DateTime.Now;
        }
    }
}
