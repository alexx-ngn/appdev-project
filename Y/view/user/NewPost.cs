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
    // Define the NewPost form class
    public partial class NewPost : Form
    {
        // Property to store the account ID
        private int accountId { get; set; }

        // Event handler for the Post button
        public EventHandler PostButton;

        // Constructor to initialize the form with the account ID
        public NewPost(int accountId)
        {
            this.accountId = accountId;
            InitializeComponent();
        }

        // Event handler for the post button click event
        private void postButton_Click(object sender, EventArgs e)
        {
            // Get the current UI culture
            var culture = global::System.Globalization.CultureInfo.CurrentUICulture.ToString();

            // Check if the post content is empty
            if (postRichTextBox.Text == "")
            {
                // Show a message box based on the current culture
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
                // Show a message box based on the current culture
                switch (culture)
                {
                    case "fr-CA":
                        MessageBox.Show("Publication a été publiée.");
                        break;
                    default:
                        MessageBox.Show("Post submitted.");
                        break;
                }
                // Create a new post with the content and account ID
                var post = new Post(postRichTextBox.Text, accountId);
                // Add the post to the user overview system
                UserOverviewSystem.Instance.AddPost(post);

                // Invoke the PostButton event
                PostButton?.Invoke(this, EventArgs.Empty);
                // Close the form
                this.Close();
            }
        }
    }
}
