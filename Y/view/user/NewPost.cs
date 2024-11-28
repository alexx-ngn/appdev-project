using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y
{
    public partial class NewPost : Form
    {
        public NewPost()
        {
            InitializeComponent();
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            if (postRichTextBox.Text == "") {
                MessageBox.Show("Please enter content.");
            }
            else
            {
                MessageBox.Show("Post submitted.");
                this.Close();
            }
        }
    }
}
