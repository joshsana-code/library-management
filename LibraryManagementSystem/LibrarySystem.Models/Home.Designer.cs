namespace LibrarySystem.Models
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            btnLogout = new Button();
            btnOpenLogin = new Button();
            btnSearch = new Button();
            txtSearchBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackgroundImage = Properties.Resources.images;
            btnLogout.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogout.Location = new Point(1265, 21);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(50, 48);
            btnLogout.TabIndex = 12;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Visible = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnOpenLogin
            // 
            btnOpenLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpenLogin.BackgroundImage = Properties.Resources.profile_icon_login_head_icon_vector;
            btnOpenLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnOpenLogin.Location = new Point(1265, 20);
            btnOpenLogin.Margin = new Padding(3, 2, 3, 2);
            btnOpenLogin.Name = "btnOpenLogin";
            btnOpenLogin.Size = new Size(50, 49);
            btnOpenLogin.TabIndex = 11;
            btnOpenLogin.UseVisualStyleBackColor = true;
            btnOpenLogin.Click += btnOpenLogin_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top;
            btnSearch.BackColor = Color.Transparent;
            btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
            btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
            btnSearch.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(939, 407);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(42, 33);
            btnSearch.TabIndex = 14;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchBox
            // 
            txtSearchBox.Anchor = AnchorStyles.Top;
            txtSearchBox.BorderStyle = BorderStyle.None;
            txtSearchBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchBox.ForeColor = SystemColors.MenuText;
            txtSearchBox.Location = new Point(405, 391);
            txtSearchBox.Margin = new Padding(3, 2, 3, 2);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.Size = new Size(517, 28);
            txtSearchBox.TabIndex = 13;
            txtSearchBox.TextChanged += txtSearchBox_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(369, 518);
            button1.Name = "button1";
            button1.Size = new Size(115, 161);
            button1.TabIndex = 15;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(554, 518);
            button2.Name = "button2";
            button2.Size = new Size(115, 161);
            button2.TabIndex = 16;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(724, 518);
            button3.Name = "button3";
            button3.Size = new Size(115, 161);
            button3.TabIndex = 17;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(901, 518);
            button4.Name = "button4";
            button4.Size = new Size(115, 161);
            button4.TabIndex = 18;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1350, 729);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchBox);
            Controls.Add(btnLogout);
            Controls.Add(btnOpenLogin);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnLogout;
        private Button btnOpenLogin;
        private Button btnSearch;
        private TextBox txtSearchBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}