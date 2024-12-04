using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Y.controller;

namespace Y
{
    public partial class Register : Form
    {
        ReportSystem ReportSystem = ReportSystem.Instance;
        public Register()
        {
            InitializeComponent();
        }

        private void loginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" || emailTextBox.Text == "" || passwordTextBox.Text == "")
            {
                switch (Thread.CurrentThread.CurrentUICulture.Name)
                {
                    case "en-US":
                        MessageBox.Show("Please fill in all fields");
                        break;
                    case "fr-CA":
                        MessageBox.Show("Veuillez remplir tous les champs");
                        break;
                    default:
                        MessageBox.Show("Please fill in all fields");
                        break;
                }
            }
            else if (usernameTextBox.Text.Equals("admin"))
            {
                switch (Thread.CurrentThread.CurrentUICulture.Name)
                {
                    case "en-US":
                        MessageBox.Show("Username cannot be 'admin'");
                        break;
                    case "fr-CA":
                        MessageBox.Show("Le nom d'utilisateur ne peut pas être 'admin'");
                        break;
                    default:
                        MessageBox.Show("Username cannot be 'admin'");
                        break;
                }
            }
            else
            {
                UserAccount newUserAccount = new UserAccount(usernameTextBox.Text, emailTextBox.Text, passwordTextBox.Text);
                ReportSystem.AddUser(newUserAccount);
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                this.Close();
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

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
    }
}
