﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Y.view.admin;

namespace Y.view.admin
{
    public partial class UserReport : Form
    {
        public UserReport()
        {
            InitializeComponent();
        }

        public event EventHandler dismissClicked;
        public event EventHandler banClicked;

        private void allowButton_Click(object sender, EventArgs e)
        {
            dismissClicked?.Invoke(this, EventArgs.Empty);
            var culture = CultureInfo.CurrentUICulture.ToString();
            switch (culture)
            {
                case "fr-CA":
                    MessageBox.Show("Le signal a été rejeté.");
                    break;
                default:
                    MessageBox.Show("The report has been dismissed.");
                    break;
            }
            this.Close();
        }

        private void banButton_Click(object sender, EventArgs e)
        {
            banClicked?.Invoke(this, EventArgs.Empty);
            var culture = CultureInfo.CurrentUICulture.ToString();
            switch (culture)
            {
                case "fr-CA":
                    MessageBox.Show("L'utilisateur est supprimé.");
                    break;
                default:
                    MessageBox.Show("The user is banned.");
                    break;
            }
            this.Close();
        }
    }
}