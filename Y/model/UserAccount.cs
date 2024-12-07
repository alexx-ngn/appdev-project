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
            // Initialize the static nextId field by retrieving the last user ID from the report system.
            nextId = 1 + ReportSystem.Instance.GetLastUserID();
        }

        // Constructor to create a UserAccount with an existing ID and follower count
        public UserAccount(int id, string name, string email, string password, int followerCount) : base(id, name, email, password)
        {
            FollowerCount = followerCount;
            Followers = new List<UserAccount>();
            Posts = new List<Post>();
        }

        // Constructor to create a UserAccount with an existing ID and no follower count
        public UserAccount(int id, string name, string email, string password) : base(id, name, email, password)
        {
            FollowerCount = 0;
            Followers = new List<UserAccount>();
            Posts = new List<Post>();
        }

        // Constructor to create a new UserAccount with a unique ID
        public UserAccount(string name, string email, string password) : base(name, email, password)
        {
            Id = nextId++;
            FollowerCount = 0;
            Followers = new List<UserAccount>();
            Posts = new List<Post>();
        }

        /// <summary>
        /// Follow another user account. Increments the target account's follower count and adds the current user to their followers list.
        /// </summary>
        /// <param name="account">The user account to follow.</param>
        public void follow(UserAccount account)
        {
            if (!account.Followers.Contains(this))
            {
                account.FollowerCount++;
                account.Followers.Add(this);
            }
        }

        /// <summary>
        /// Create a new post with the specified text and add it to the user's posts list.
        /// </summary>
        /// <param name="text">The text content of the post.</param>
        public void post(String text)
        {
            Post post = new Post(text, this.Id);
            Posts.Add(post);
        }

        /// <summary>
        /// Increment the number of likes on the specified post.
        /// </summary>
        /// <param name="post">The post to like.</param>
        public void like(Post post)
        {
            post.Likes++;
        }

        /// <summary>
        /// Remove a specified post from the user's posts list.
        /// </summary>
        /// <param name="post">The post to remove.</param>
        public override void removePost(Post post)
        {
            if (Posts.Contains(post))
            {
                Posts.Remove(post);
            }
        }

        /// <summary>
        /// Report another user for a specific reason. Creates a UserReport and files it with the report system.
        /// </summary>
        /// <param name="account">The user to report.</param>
        /// <param name="reason">The reason for the report.</param>
        public void reportUser(UserAccount account, String reason)
        {
            UserReport report = new UserReport(account.Id, reason, this.Id);
            ReportSystem.FileReport(report);
        }

        /// <summary>
        /// Report a post by another user for a specific reason. Creates a PostReport and files it with the report system.
        /// </summary>
        /// <param name="account">The user who owns the post being reported.</param>
        /// <param name="reason">The reason for the report.</param>
        public void reportPost(UserAccount account, String reason)
        {
            PostReport report = new PostReport(account.Id, reason, this.Id);
            ReportSystem.FileReport(report);
        }

        /// <summary>
        /// Retrieve the list of posts created by the user as a read-only collection.
        /// </summary>
        /// <returns>A read-only list of the user's posts.</returns>
        public IReadOnlyList<Post> GetPosts()
        {
            return Posts.AsReadOnly(); // Expose the list as a read-only collection
        }
    }
}
