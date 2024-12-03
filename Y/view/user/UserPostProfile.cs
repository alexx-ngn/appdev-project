using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Y.view.user
{
    public partial class UserPostProfile : Y.UserPost
    {
        private int userId { get; set; }

        public UserPostProfile(int userId) : base(userId)
        {
            this.userId = userId;
            InitializeComponent();
        }
        private void reportButton_Click(object sender, EventArgs e)
        {
            new NewUserReport().ShowDialog();
        }
    }
}
