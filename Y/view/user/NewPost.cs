using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Y.controller;

namespace Y
{
    public partial class NewPost : Form
    {
        private int accountId { get; set; }
        public EventHandler PostButton;
        public NewPost(int accountId)
        {
            this.accountId = accountId;
            InitializeComponent();
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            var culture = global::System.Globalization.CultureInfo.CurrentUICulture.ToString();

            if (postRichTextBox.Text == "")
            {
                switch (culture)
                {
                    case "fr-CA":
                        MessageBox.Show("Veuillez entrez votre contenu.");
                        break;
                    default:
                        MessageBox.Show("Please enter your content.");
                        break;
                }
            }
            else
            {
                switch (culture)
                {
                    case "fr-CA":
                        MessageBox.Show("Publication a été publiée.");
                        break;
                    default:
                        MessageBox.Show("Post submitted.");
                        break;
                }
                var post = new Post(postRichTextBox.Text, accountId);
                UserOverviewSystem.Instance.AddPost(post);

                PostButton?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
        }
    }
}
