namespace LibrarySystem.Models {
    partial class SignUpForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            btnSignInTab = new Button();
            btnSignUp = new Button();
            chkShowPassword = new CheckBox();
            btnNewAccount = new Button();
            txtStudentNo = new TextBox();
            txtFirstName = new TextBox();
            label1 = new Label();
            txtLastName = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // btnSignInTab
            // 
            btnSignInTab.BackColor = Color.Transparent;
            btnSignInTab.Location = new Point(568, 98);
            btnSignInTab.Name = "btnSignInTab";
            btnSignInTab.Size = new Size(142, 39);
            btnSignInTab.TabIndex = 22;
            btnSignInTab.Text = "[SIGN IN]";
            btnSignInTab.UseVisualStyleBackColor = false;
            btnSignInTab.Click += btnSignInTab_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(190, 437);
            btnSignUp.Margin = new Padding(3, 2, 3, 2);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(116, 30);
            btnSignUp.TabIndex = 21;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.BackColor = Color.Transparent;
            chkShowPassword.Location = new Point(198, 400);
            chkShowPassword.Margin = new Padding(3, 2, 3, 2);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(108, 19);
            chkShowPassword.TabIndex = 20;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.TextAlign = ContentAlignment.MiddleCenter;
            chkShowPassword.UseVisualStyleBackColor = false;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnNewAccount
            // 
            btnNewAccount.Location = new Point(722, 98);
            btnNewAccount.Margin = new Padding(3, 2, 3, 2);
            btnNewAccount.Name = "btnNewAccount";
            btnNewAccount.Size = new Size(144, 39);
            btnNewAccount.TabIndex = 19;
            btnNewAccount.Text = "[NEW ACCOUNT]";
            btnNewAccount.UseVisualStyleBackColor = true;
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(136, 307);
            txtStudentNo.Margin = new Padding(3, 2, 3, 2);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(244, 23);
            txtStudentNo.TabIndex = 16;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(120, 252);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(116, 23);
            txtFirstName.TabIndex = 15;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(625, 90);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 14;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(264, 252);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(116, 23);
            txtLastName.TabIndex = 26;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(136, 364);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(244, 23);
            txtPassword.TabIndex = 28;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(509, 548);
            Controls.Add(txtPassword);
            Controls.Add(txtLastName);
            Controls.Add(btnSignInTab);
            Controls.Add(btnSignUp);
            Controls.Add(chkShowPassword);
            Controls.Add(btnNewAccount);
            Controls.Add(txtStudentNo);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignUpForm";
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSignInTab;
        private Button btnSignUp;
        private CheckBox chkShowPassword;
        private Button btnNewAccount;
        private TextBox txtStudentNo;
        private TextBox txtFirstName;
        private Label label1;
        private TextBox txtLastName;
        private TextBox txtPassword;
    }
}