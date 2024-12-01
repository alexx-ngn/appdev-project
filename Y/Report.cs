using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y
{
    public abstract class Report
    {
        protected int Id {  get; set; }
        protected int AdminId { get; set; } 
        protected int ReportingUserId { get; set; }
        protected String Reason { get; set; }
        protected Status Status { get; set; }
        protected DateTime DateReported { get;}

        protected Report(int id, int reportingUserId, string reason)
        {
            Id = id;
            AdminId = 0;
            ReportingUserId = reportingUserId;
            Reason = reason;
            Status = Status.Created;
            DateReported = DateTime.Now;
        }

        //this is what is created in the userAccount class, not sure about other one and how to handle them
        protected Report(int reportingUserId, string reason)
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
