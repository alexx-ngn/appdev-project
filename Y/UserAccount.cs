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

        public UserAccount(string name, string email) : base(name, email)
        {
            FollowerCount = 0;
            Followers = new List<UserAccount>();
            Posts = new List<Post>();
        }

        public void follow(UserAccount account)
        {
            if (!account.Followers.Contains(this))
            {
                account.FollowerCount++;
                account.Followers.Add(this);
            }
        }

        public void post(String text)
        {
            Post post = new Post(text);
            Posts.Add(post);
        }

        public void like(Post post)
        {
            int userId = GetHashCode();
            post.AddLike(userId);
        }

        public override void removePost(Post post)
        {
            if (Posts.Contains(post))
            {
                Posts.Remove(post);
            }
        }
    }
}
