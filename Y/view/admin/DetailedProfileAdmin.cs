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

namespace Y.view.admin
{
    public partial class DetailedProfileAdmin : Form
    {
        // Event handler for ban button click
        public EventHandler banClicked;

        // Constructor
        public DetailedProfileAdmin()
        {
            InitializeComponent();
        }

        // Event handler for delete button click
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Invoke the banClicked event
            banClicked?.Invoke(this, EventArgs.Empty);

            // Get the current UI culture
            var culture = CultureInfo.CurrentUICulture.ToString();

            // Show message based on culture
            switch (culture)
            {
                case "fr-CA":
                    MessageBox.Show("L'utilisateur est supprimé.");
                    break;
                default:
                    MessageBox.Show("The user has been banned.");
                    break;
            }

            // Close the form
            this.Close();
        }
    }
}
