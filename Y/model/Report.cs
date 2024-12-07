using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y
{
    public abstract class Report
    {
        public int Id {  get; set; }
        public int ReportingUserId { get; set; }
        public String Reason { get; set; }
        public DateTime DateReported { get;} 

        public Report(int id, int reportingUserId, string reason, DateTime dateReported)
        {
            Id = id;
            ReportingUserId = reportingUserId;
            Reason = reason;
            DateReported = dateReported;
        }

        public Report(int id, int reportingUserId, string reason)
        {
            Id = id;
            ReportingUserId = reportingUserId;
            Reason = reason;
            //Status = Status.Created;
            DateReported = DateTime.Now;
        }

        public Report(int reportingUserId, string reason)
        {
            ReportingUserId = reportingUserId;
            Reason = reason;
            //Status = Status.Created;
            DateReported = DateTime.Now;
        }
    }
}
