using System;
using System.Collections.Generic;

namespace Y
{
    public class Post
    {
        private int Id { get; set; }
        private string Text { get; set; }

        private HashSet<int> Likes { get; set; }
        private DateTime DatePosted { get; }

        public Post(int id, string text)
        {
            Id = id;
            Text = text;
            Likes = new HashSet<int>();
            DatePosted = DateTime.Now;
        }
    }
}