using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Y
{
    public partial class NewUserReport : Form
    {
        public NewUserReport()
        {
            InitializeComponent();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            var culture = CultureInfo.CurrentUICulture.ToString();
            if (reportRichTextBox.Text == "")
            {
                switch (culture)
                {
                    case "fr-CA":
                        MessageBox.Show("Veuillez entrez votre raison.");
                        break;
                    default:
                        MessageBox.Show("Please enter your statement.");
                        break;
                }
            }
            else
            {
                switch (culture)
                {
                    case "fr-CA":
                        MessageBox.Show("L'utilisateur a été signalé.");
                        break;
                    default:
                        MessageBox.Show("User has been reported.");
                        break;
                }
                this.Close();
            }
        }
    }
}
