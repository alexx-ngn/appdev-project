using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y
{
    internal class UserAccount : Account
    {
        private int FollowerCount { get; set; }
        private List<UserAccount> Followers {  get; set; }
        private List<Post> Posts { get; set; }

        public UserAccount(int id, string name, string email) : base(id, name, email)
        {
            FollowerCount = 0;
            Followers = new List<UserAccount>();
            Posts = new List<Post>();
        }

        public void follow(UserAccount account)
        {
            account.FollowerCount++;
            account.Followers.Add(this);
        }

        public void post(String text)
        {
            Post post = new Post(text);
            Posts.Add(post);
        }

        public void like(Post post)
        {

        }

        public override void removePost(Post post)
        {
            Posts.Remove(post);
        }
    }
}
