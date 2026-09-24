using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibrarySystem.Models
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                    "Do you really want to log out?",
                    "Confirm Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You have been logged out.");
                Environment.Exit(0);
            }
        }

        private void btnOpenLogin_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            Hide();
            signInForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
