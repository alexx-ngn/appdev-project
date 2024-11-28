using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y
{
    internal abstract class Account
    {
        public int Id {  get; set; }
        public string Name {get; set;}
        public string email { get; set;}
        public DateTime creationDate { get; private set; }

        public Account(int id, string name, string email)
        {
            Id = id;
            Name = name;
            this.email = email;
            this.creationDate = DateTime.Now;
        }
        public abstract void removePost(Post post);


    }
}
