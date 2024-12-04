using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Y.controller;

namespace Y
{
    public class UserAccount : Account
    {
        ReportSystem ReportSystem = ReportSystem.Instance;
        LoginSystem LoginSystem = LoginSystem.Instance;

        public int FollowerCount { get; set; }
        private List<UserAccount> Followers { get; set; }
        private List<Post> Posts { get; set; }
        private static int nextId;

        static UserAccount()
        {
            nextId = 1 + ReportSystem.Instance.GetLastUserID();
        }

        public UserAccount(int id, string name, string email, string password, int followerCount) : base(id, name, email, password)
        {
            FollowerCount = followerCount;
            Followers = new List<UserAccount>();
            Posts = new List<Post>();
            //LoginSystem.AddUserCredentials(name, password);
        }
        public UserAccount(int id, string name, string email, string password) : base(id, name, email, password)
        {
            FollowerCount = 0;
            Followers = new List<UserAccount>();
            Posts = new List<Post>();
            //LoginSystem.AddUserCredentials(name, password);
        }

        public UserAccount(string name, string email, string password) : base(name, email, password)
        {
            Id = nextId++;
            FollowerCount = 0;
            Followers = new List<UserAccount>();
            Posts = new List<Post>();
            //LoginSystem.AddUserCredentials(name, password);
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
            Post post = new Post(text, this.Id);
            Posts.Add(post);
        }

        public void like(Post post)
        {
            post.Likes++;
        }

        public override void removePost(Post post)
        {
            if (Posts.Contains(post))
            {
                Posts.Remove(post);
            }
        }

        public void reportUser(UserAccount account, String reason)
        {
            UserReport report = new UserReport(account.Id, reason, this.Id);
            ReportSystem.FileReport(report);
        }

        public void reportPost(UserAccount account, String reason)
        {
            PostReport report = new PostReport(account.Id, reason, this.Id);
            ReportSystem.FileReport(report);
        }

        public IReadOnlyList<Post> GetPosts()
        {
            return Posts.AsReadOnly(); // Expose the list as a read-only collection
        }
    }
}
