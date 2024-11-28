using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Y
{
    public partial class UserOverview : Overview.Overview
    {
        public UserOverview()
        {
            InitializeComponent();
            loadPosts();
        }
        public void loadPosts()
        {
            for (int i = 0; i < 5; i++)
            {
                Post post = new Post();
                overviewFlowLayoutPanel.Controls.Add(post);
            }
        }
    }
}
