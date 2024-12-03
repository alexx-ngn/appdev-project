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

namespace Y
{
    public partial class Login : Form
    {
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

        public void loadUserOverview()
        {
            this.Hide();
            UserOverview overview = new UserOverview();
            overview.ShowDialog();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (ReportSystem.GetUserAccounts().Count == 0)
            {
                ReportSystem.LoadUsers();
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
            if (ReportSystem.ValidateUser(usernameTextBox.Text, passwordTextBox.Text))
            {
                loadUserOverview();
            }
            else
            {
                MessageBox.Show("Invalid credentials ");
            }
        }
    }
}
