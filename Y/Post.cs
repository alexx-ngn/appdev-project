using System;
using System.Collections.Generic;

namespace Y
{
    public class Post
    {
        private int Id { get; set; }
        private string Text { get; set; }

        private HashSet<int> Likes { get; set; }
        private DateTime DatePosted { get;}

        public Post(int id, string text)
        {
            Id = id;
            Text = text;
            Likes = new HashSet<int>();
            DatePosted = DateTime.Now;
        }

        public Post(string text)
        {
            Text = text;
            Likes = new HashSet<int>();
            DatePosted = DateTime.Now;
        }

        public void AddLike(int userId)
        {
            if (!Likes.Contains(userId))
            {
                Likes.Add(userId); 
                //Console.WriteLine($"User {userId} liked the post: {Text}");
            }
            else
            {
                //Console.WriteLine($"User {userId} already liked the post: {Text}");
            }
        }
    }
}