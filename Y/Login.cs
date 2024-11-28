﻿using System;
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
            //loadUserOverview();
        }
    }
}
