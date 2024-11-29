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
        public string Email { get; set;}
        private DateTime CreationDate { get;}

        protected Account(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            CreationDate = DateTime.Now;
        }
        public abstract void removePost(Post post);
    }
}
