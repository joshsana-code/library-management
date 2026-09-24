namespace LibrarySystem.Models
{
    partial class SignInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            label1 = new Label();
            txtMemberID = new TextBox();
            txtPassword = new TextBox();
            btnSignUp = new Button();
            chkShowPassword = new CheckBox();
            btnSignIn = new Button();
            button1 = new Button();
            btn_home = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(626, 88);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(562, 255);
            txtMemberID.Margin = new Padding(3, 2, 3, 2);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(245, 23);
            txtMemberID.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(563, 330);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(244, 23);
            txtPassword.TabIndex = 3;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(696, 184);
            btnSignUp.Margin = new Padding(3, 2, 3, 2);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(144, 39);
            btnSignUp.TabIndex = 6;
            btnSignUp.Text = "[NEW ACCOUNT]";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignIn_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.BackColor = Color.Transparent;
            chkShowPassword.Location = new Point(664, 357);
            chkShowPassword.Margin = new Padding(3, 2, 3, 2);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(108, 19);
            chkShowPassword.TabIndex = 7;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.TextAlign = ContentAlignment.MiddleCenter;
            chkShowPassword.UseVisualStyleBackColor = false;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(664, 403);
            btnSignIn.Margin = new Padding(3, 2, 3, 2);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(119, 30);
            btnSignIn.TabIndex = 8;
            btnSignIn.Text = "Sign in";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnLogin_Click;
            // 
            // button1
            // 
            button1.Location = new Point(899, 557);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 9;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_home
            // 
            btn_home.BackColor = Color.FromArgb(224, 224, 224);
            btn_home.Location = new Point(696, 478);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(53, 23);
            btn_home.TabIndex = 11;
            btn_home.Text = "HOME";
            btn_home.UseVisualStyleBackColor = false;
            btn_home.Click += btn_home_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(224, 224, 224);
            button3.Location = new Point(755, 478);
            button3.Name = "button3";
            button3.Size = new Size(73, 23);
            button3.TabIndex = 12;
            button3.Text = "CATALOG";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(224, 224, 224);
            button4.Location = new Point(833, 478);
            button4.Name = "button4";
            button4.Size = new Size(85, 23);
            button4.TabIndex = 13;
            button4.Text = "CONTACT US";
            button4.UseVisualStyleBackColor = false;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(941, 513);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btn_home);
            Controls.Add(button1);
            Controls.Add(btnSignIn);
            Controls.Add(chkShowPassword);
            Controls.Add(btnSignUp);
            Controls.Add(txtPassword);
            Controls.Add(txtMemberID);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign in";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMemberID;
        private TextBox txtPassword;
        private Button btnSignUp;
        private CheckBox chkShowPassword;
        private Button btnSignIn;
        private Button button1;
        private Button btn_home;
        private Button button3;
        private Button button4;
    }
}