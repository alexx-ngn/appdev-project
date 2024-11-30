using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y
{
    public abstract class Account
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

        protected Account(string name, string email)
        {
            Name = name;
            Email = email;
            CreationDate = DateTime.Now;
        }
        public abstract void removePost(Post post);

        public override bool Equals(object obj)
        {
            return obj is Account account &&
                   Id == account.Id &&
                   Name == account.Name &&
                   Email == account.Email &&
                   CreationDate == account.CreationDate;
        }

        public override int GetHashCode()
        {
            int hashCode = -1247915963;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + CreationDate.GetHashCode();
            return hashCode;
        }
    }
}
