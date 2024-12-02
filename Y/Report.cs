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
        public int AdminId { get; set; } 
        public int ReportingUserId { get; set; }
        public String Reason { get; set; }
        public Status Status { get; set; }
        public DateTime DateReported { get;}

        public Report(int id, int reportingUserId, string reason)
        {
            Id = id;
            AdminId = 0;
            ReportingUserId = reportingUserId;
            Reason = reason;
            Status = Status.Created;
            DateReported = DateTime.Now;
        }

        //this is what is created in the userAccount class, not sure about other one and how to handle them
        public Report(int reportingUserId, string reason)
        {
            AdminId = 0;
            ReportingUserId = reportingUserId;
            Reason = reason;
            Status = Status.Created;
            DateReported = DateTime.Now;
        }

        //method to assign admin and change status
        public void AssignAdmin(int adminId)
        {
            AdminId = adminId; // Set AdminId
        }

        public void ChangeStatus(Status status)
        {
            Status = status; 
        }

        //  Method to retrieve AdminId for debugging or logs
        public int GetAdminId()
        {
            return AdminId;
        }
    }
}
