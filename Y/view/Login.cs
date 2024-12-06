using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Y.controller;
using Y.view.admin;

namespace Y
{
    public partial class Login : Form
    {
        LoginSystem LoginSystem = LoginSystem.Instance;
        public Login()
        {
            InitializeComponent();
        }

        private void registerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            this.Close();
        }

        public void loadUserOverview(int id)
        {
            this.Hide();
            UserOverview overview = new UserOverview(id);
            overview.ShowDialog();
            this.Close();
        }

        public void loadAdminOverview(int id)
        {
            this.Hide();
            AdminOverview overview = new AdminOverview(id);
            overview.ShowDialog();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (LoginSystem.GetUserAccounts().Count == 0)
            {
                LoginSystem.LoadUsers();
            }
            if (LoginSystem.GetAdminAccounts().Count == 0)
            {
                LoginSystem.LoadAdmins();
            }
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (languageComboBox.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-CA");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-CA");
                    break;
                default:
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    break;
            }
            this.Controls.Clear();
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (LoginSystem.ValidateUser(usernameTextBox.Text, passwordTextBox.Text))
            {
                int id = LoginSystem.FetchUserIdFromUsername(usernameTextBox.Text);
                loadUserOverview(id);
            }
            if (LoginSystem.ValidateAdmin(usernameTextBox.Text, passwordTextBox.Text))
            {
                int id = LoginSystem.FetchAdminIdFromUsername(usernameTextBox.Text);
                loadAdminOverview(id);
            }

            else
            {
                switch(Thread.CurrentThread.CurrentUICulture.Name)
                {
                    case "fr-CA":
                        MessageBox.Show("Nom d'utilisateur ou mot de passe invalide");
                        break;
                    default:
                        MessageBox.Show("Invalid username or password");
                        break;
                }
            }
        }
    }
}
