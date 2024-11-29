using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Y.view.admin
{
    public partial class AdminPost : Y.UserPost
    {
        public AdminPost()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                this.Dispose();
            }
        }
    }
}
