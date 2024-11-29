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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            dateOfBirthPicker.MaxDate = DateTime.Now.AddYears(-16); //Minimum age to register is 16
            dateOfBirthPicker.MinDate = DateTime.Now.AddYears(-100); //Maximum age to register is 100
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

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}