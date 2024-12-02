using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookManagementSystem_Program
{
    internal class LoginForm : Form
    {
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btn_Login;
        private TextBox txt_Account;
        private Panel pnAccount;
        private Panel pnPassword;
        private TextBox txt_Password;
        private Panel pnPermission;
        private Panel pnButton;
        private ComboBox txt_Permission;
        private Button btn_SignUp;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.txt_Account = new System.Windows.Forms.TextBox();
            this.pnAccount = new System.Windows.Forms.Panel();
            this.pnPassword = new System.Windows.Forms.Panel();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.pnPermission = new System.Windows.Forms.Panel();
            this.txt_Permission = new System.Windows.Forms.ComboBox();
            this.pnButton = new System.Windows.Forms.Panel();
            this.pnAccount.SuspendLayout();
            this.pnPassword.SuspendLayout();
            this.pnPermission.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(410, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Log In";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(12, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "Account";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(12, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(12, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 30);
            this.label7.TabIndex = 4;
            this.label7.Text = "Who are you ?";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 10F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(471, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 30);
            this.label8.TabIndex = 2;
            this.label8.Text = "Forgot Password ?";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Login.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(3, 3);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(158, 55);
            this.btn_Login.TabIndex = 1;
            this.btn_Login.Text = "Log In";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SignUp.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignUp.ForeColor = System.Drawing.Color.White;
            this.btn_SignUp.Location = new System.Drawing.Point(195, 3);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(157, 55);
            this.btn_SignUp.TabIndex = 0;
            this.btn_SignUp.Text = "Sign Up";
            this.btn_SignUp.UseVisualStyleBackColor = false;
            this.btn_SignUp.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_Account
            // 
            this.txt_Account.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Account.Location = new System.Drawing.Point(16, 33);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.Size = new System.Drawing.Size(327, 35);
            this.txt_Account.TabIndex = 10;
            // 
            // pnAccount
            // 
            this.pnAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnAccount.BackColor = System.Drawing.Color.Transparent;
            this.pnAccount.Controls.Add(this.label5);
            this.pnAccount.Controls.Add(this.txt_Account);
            this.pnAccount.Location = new System.Drawing.Point(287, 116);
            this.pnAccount.Name = "pnAccount";
            this.pnAccount.Size = new System.Drawing.Size(355, 76);
            this.pnAccount.TabIndex = 11;
            // 
            // pnPassword
            // 
            this.pnPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnPassword.BackColor = System.Drawing.Color.Transparent;
            this.pnPassword.Controls.Add(this.txt_Password);
            this.pnPassword.Controls.Add(this.label6);
            this.pnPassword.Location = new System.Drawing.Point(287, 198);
            this.pnPassword.Name = "pnPassword";
            this.pnPassword.Size = new System.Drawing.Size(355, 76);
            this.pnPassword.TabIndex = 12;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(16, 33);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(327, 35);
            this.txt_Password.TabIndex = 10;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // pnPermission
            // 
            this.pnPermission.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnPermission.BackColor = System.Drawing.Color.Transparent;
            this.pnPermission.Controls.Add(this.txt_Permission);
            this.pnPermission.Controls.Add(this.label7);
            this.pnPermission.Location = new System.Drawing.Point(287, 280);
            this.pnPermission.Name = "pnPermission";
            this.pnPermission.Size = new System.Drawing.Size(355, 76);
            this.pnPermission.TabIndex = 13;
            // 
            // txt_Permission
            // 
            this.txt_Permission.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Permission.FormattingEnabled = true;
            this.txt_Permission.Items.AddRange(new object[] {
            "Admin",
            "Users"});
            this.txt_Permission.Location = new System.Drawing.Point(16, 33);
            this.txt_Permission.Name = "txt_Permission";
            this.txt_Permission.Size = new System.Drawing.Size(327, 36);
            this.txt_Permission.TabIndex = 15;
            // 
            // pnButton
            // 
            this.pnButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnButton.BackColor = System.Drawing.Color.Transparent;
            this.pnButton.Controls.Add(this.btn_Login);
            this.pnButton.Controls.Add(this.btn_SignUp);
            this.pnButton.Location = new System.Drawing.Point(287, 404);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(355, 63);
            this.pnButton.TabIndex = 14;
            // 
            // LoginForm
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 533);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.pnPermission);
            this.Controls.Add(this.pnPassword);
            this.Controls.Add(this.pnAccount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 580);
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.pnAccount.ResumeLayout(false);
            this.pnAccount.PerformLayout();
            this.pnPassword.ResumeLayout(false);
            this.pnPassword.PerformLayout();
            this.pnPermission.ResumeLayout(false);
            this.pnButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SiginUp signUpForm = new SiginUp();
            signUpForm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Account.Text))
            {
                MessageBox.Show("Please enter your account!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            if (string.IsNullOrWhiteSpace(txt_Password.Text))
            {
                MessageBox.Show("Please enter your password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txt_Permission.SelectedItem == null)
            {
                MessageBox.Show("Please select a permission before proceeding!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            // Nếu quyền là Admin
            if (txt_Permission.SelectedItem.ToString() == "Admin")
            {
                using (DashboardForm d = new DashboardForm())
                {
                    this.Hide();  
                    d.ShowDialog();  
                }
            }
            // Nếu quyền là Users
            else if (txt_Permission.SelectedItem.ToString() == "Users")
            {
                using (TourBooking t = new TourBooking())
                {
                    this.Hide();  
                    t.ShowDialog();  
                }
            }
            this.Show();
        }

    }
}
