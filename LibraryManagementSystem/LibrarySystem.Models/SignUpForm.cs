using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibrarySystem.Models {
    public partial class SignUpForm : Form
    {
        private readonly AuthService authentication = new AuthService();
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string studentNo = txtStudentNo.Text.Trim();
            string password = txtPassword.Text;

            // 1. Check empty fields
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(studentNo) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Register user
            bool isRegistered = authentication.RegisterUser(studentNo, firstName, lastName, password);

            if (isRegistered)
            {
                MessageBox.Show("Account created successfully! Redirecting to Sign In...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SignInForm signIn = new SignInForm();
                signIn.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Registration failed. Make sure your Student Number is numeric and not already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private void btnSignInTab_Click(object sender, EventArgs e)
        {
            SignInForm signIn = new SignInForm();
            signIn.Show();
            this.Hide();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
