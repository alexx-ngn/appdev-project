using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y
{
    internal class AdminAccount : Account
    {
        private Queue<Report> AssignedReports {  get; set; }
        public AdminAccount(int id, string name, string email) : base(id, name, email)
        {
            AssignedReports = new Queue<Report>();
        }

        public override void removePost(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
