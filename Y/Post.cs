﻿using System;
using System.Collections.Generic;

namespace Y
{
    public class Post
    {
        private int Id { get; set; }
        private string Text { get; set; }
        private static int idCount = 1;


        private HashSet<Account> Likes { get; set; }
        private DateTime DatePosted { get;}
      
        public Post(int id, string text)
        {
            Id = id;
            Text = text;
            Likes = new HashSet<Account>();
            DatePosted = DateTime.Now;
        }

        public Post(string text)
        {
            Id = idCount++;
            Text = text;
            Likes = new HashSet<Account>();
            DatePosted = DateTime.Now;
        }

        public void AddLike(Account account)
        {
            Likes.Add(account);
        }
    }
}