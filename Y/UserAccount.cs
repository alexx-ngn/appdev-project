using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y
{
    internal class UserAccount : Account
    {
        private int followerCount;
        private List<UserAccount> followers;
        private List<Post> posts;

        public UserAccount(int id, string name, string email) : base(id, name, email)
        {
        }

        public override void removePost(Post post)
        {
            throw new NotImplementedException();
        }

        public void follow(UserAccount account)
        {
            followers.Add(account);
        }

        public void post (String text)
        {

        }
    }
}
