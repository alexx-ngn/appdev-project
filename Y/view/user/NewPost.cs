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
            var culture = global::System.Globalization.CultureInfo.CurrentUICulture.ToString();
            
            if (postRichTextBox.Text == "") {
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
                this.Close();
            }
        }
    }
}
