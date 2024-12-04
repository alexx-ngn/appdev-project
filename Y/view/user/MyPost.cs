using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Y
{
    public partial class MyPost : Y.UserPost
    {

        public MyPost(Post post) : base(post)
        {
            InitializeComponent();
        }

        public MyPost()
        {
            InitializeComponent();
        }
    }
}
