using System;
using System.Collections.Generic;

namespace Y
{
    public class Post
    {
        public int Id { get; set; }
        public string Text { get; set; }
        private static int idCount = 1;
        public int Likes { get; set; }
        public DateTime DatePosted { get;}
        public int accountId { get; set; }

        public Post(int id, string text, int likes, DateTime datePosted, int accountId) : this(id, text, accountId)
        {
            Likes = likes;
            DatePosted = datePosted;
            this.accountId = accountId;
        }

        public Post(int id, string text, int accountId)
        {
            Id = id;
            Text = text;
            Likes = 0;
            DatePosted = DateTime.Now;
            this.accountId = accountId;
        }

        public Post(string text, int accountId)
        {
            Id = idCount++;
            Text = text;
            Likes = 0;
            DatePosted = DateTime.Now;
            this.accountId = accountId;
        }

        //public void AddLike(Account account)
        //{
        //    Likes.Add(account);
        //}
    }
}