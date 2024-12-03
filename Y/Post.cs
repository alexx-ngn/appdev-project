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

        public Post(int id, string text, int likes, DateTime datePosted) : this(id, text)
        {
            Likes = likes;
            DatePosted = datePosted;
        }

        public Post(int id, string text)
        {
            Id = id;
            Text = text;
            Likes = 0;
            DatePosted = DateTime.Now;
        }

        public Post(string text)
        {
            Id = idCount++;
            Text = text;
            Likes = 0;
            DatePosted = DateTime.Now;
        }

        //public void AddLike(Account account)
        //{
        //    Likes.Add(account);
        //}
    }
}