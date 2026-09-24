using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibrarySystem.Models
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            // Display logged-in user's name


            // Load Catalog view by default
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            CurrentUser.isLoggedIn = false;
            CurrentUser.MemberID = 0;
            CurrentUser.FullName = string.Empty;

            SignInForm signIn = new SignInForm();
            signIn.Show();
            this.Close();
        }
    }
}

