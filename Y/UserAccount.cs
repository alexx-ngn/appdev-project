﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y
{
    public class UserAccount : Account
    {
        public int FollowerCount { get; set; }
        private List<UserAccount> Followers {  get; set; }
        private List<Post> Posts { get; set; }
        private static int idCount = 1;

        public UserAccount(int id, string name, string email) : base(id, name, email)
        {
            FollowerCount = 0;
            Followers = new List<UserAccount>();
            Posts = new List<Post>();
        }

        public UserAccount(string name, string email) : base(name, email)
        {
            Id = idCount++;
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
            post.AddLike(this);
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
