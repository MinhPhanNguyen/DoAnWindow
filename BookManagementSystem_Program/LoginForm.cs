using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookManagementSystem_Program
{
    internal class LoginForm : Form
    {
        private Panel pnAccount;
        private Panel pnButton;
        private Guna.UI2.WinForms.Guna2TextBox txt_Account;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_Password;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_Login;
        private Guna.UI2.WinForms.Guna2Button btn_Signup;
        private Label lb_ForgotPass;
        private Guna.UI2.WinForms.Guna2ComboBox txt_Permission;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lb_ForgotPass = new System.Windows.Forms.Label();
            this.pnAccount = new System.Windows.Forms.Panel();
            this.txt_Account = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnButton = new System.Windows.Forms.Panel();
            this.btn_Signup = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Login = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Permission = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnAccount.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_ForgotPass
            // 
            this.lb_ForgotPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_ForgotPass.BackColor = System.Drawing.Color.Transparent;
            this.lb_ForgotPass.Font = new System.Drawing.Font("Verdana", 10F);
            this.lb_ForgotPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_ForgotPass.Location = new System.Drawing.Point(459, 341);
            this.lb_ForgotPass.Name = "lb_ForgotPass";
            this.lb_ForgotPass.Size = new System.Drawing.Size(171, 30);
            this.lb_ForgotPass.TabIndex = 2;
            this.lb_ForgotPass.Text = "Quên mật khẩu ?";
            this.lb_ForgotPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnAccount
            // 
            this.pnAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnAccount.BackColor = System.Drawing.Color.Transparent;
            this.pnAccount.Controls.Add(this.txt_Account);
            this.pnAccount.Location = new System.Drawing.Point(275, 109);
            this.pnAccount.Name = "pnAccount";
            this.pnAccount.Size = new System.Drawing.Size(355, 76);
            this.pnAccount.TabIndex = 11;
            // 
            // txt_Account
            // 
            this.txt_Account.Animated = true;
            this.txt_Account.AutoRoundedCorners = true;
            this.txt_Account.BackColor = System.Drawing.Color.Transparent;
            this.txt_Account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_Account.BorderColor = System.Drawing.Color.White;
            this.txt_Account.BorderRadius = 26;
            this.txt_Account.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Account.DefaultText = "";
            this.txt_Account.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Account.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Account.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Account.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Account.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.txt_Account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_Account.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.txt_Account.Location = new System.Drawing.Point(0, 4);
            this.txt_Account.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.txt_Account.PasswordChar = '\0';
            this.txt_Account.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_Account.PlaceholderText = "Tài khoản";
            this.txt_Account.SelectedText = "";
            this.txt_Account.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.txt_Account.Size = new System.Drawing.Size(352, 54);
            this.txt_Account.TabIndex = 9;
            // 
            // pnButton
            // 
            this.pnButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnButton.BackColor = System.Drawing.Color.Transparent;
            this.pnButton.Controls.Add(this.btn_Signup);
            this.pnButton.Controls.Add(this.btn_Login);
            this.pnButton.Location = new System.Drawing.Point(275, 388);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(355, 69);
            this.pnButton.TabIndex = 14;
            // 
            // btn_Signup
            // 
            this.btn_Signup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_Signup.BorderRadius = 10;
            this.btn_Signup.BorderThickness = 1;
            this.btn_Signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Signup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Signup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Signup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Signup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Signup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_Signup.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Signup.ForeColor = System.Drawing.Color.White;
            this.btn_Signup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_Signup.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_Signup.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_Signup.Location = new System.Drawing.Point(180, 3);
            this.btn_Signup.Name = "btn_Signup";
            this.btn_Signup.PressedColor = System.Drawing.Color.White;
            this.btn_Signup.Size = new System.Drawing.Size(172, 63);
            this.btn_Signup.TabIndex = 1;
            this.btn_Signup.Text = "Đăng Ký";
            this.btn_Signup.Click += new System.EventHandler(this.btn_Signup_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Animated = true;
            this.btn_Login.AnimatedGIF = true;
            this.btn_Login.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_Login.BorderRadius = 10;
            this.btn_Login.BorderThickness = 1;
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_Login.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_Login.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_Login.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_Login.Location = new System.Drawing.Point(0, 3);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.PressedColor = System.Drawing.Color.White;
            this.btn_Login.Size = new System.Drawing.Size(172, 63);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Đăng Nhập";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click_1);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(363, 49);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(200, 40);
            this.guna2HtmlLabel1.TabIndex = 15;
            this.guna2HtmlLabel1.Text = "Đăng Nhập";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Location = new System.Drawing.Point(275, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 76);
            this.panel1.TabIndex = 12;
            // 
            // txt_Password
            // 
            this.txt_Password.Animated = true;
            this.txt_Password.AutoRoundedCorners = true;
            this.txt_Password.BackColor = System.Drawing.Color.Transparent;
            this.txt_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_Password.BorderColor = System.Drawing.Color.White;
            this.txt_Password.BorderRadius = 26;
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Password.DefaultText = "";
            this.txt_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.txt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_Password.Location = new System.Drawing.Point(0, 4);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.txt_Password.PasswordChar = '●';
            this.txt_Password.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_Password.PlaceholderText = "Mật khẩu";
            this.txt_Password.SelectedText = "";
            this.txt_Password.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.txt_Password.Size = new System.Drawing.Size(352, 54);
            this.txt_Password.TabIndex = 9;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txt_Permission);
            this.panel2.Location = new System.Drawing.Point(275, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 65);
            this.panel2.TabIndex = 13;
            // 
            // txt_Permission
            // 
            this.txt_Permission.BackColor = System.Drawing.Color.Transparent;
            this.txt_Permission.BorderColor = System.Drawing.Color.White;
            this.txt_Permission.BorderRadius = 20;
            this.txt_Permission.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txt_Permission.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txt_Permission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_Permission.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Permission.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Permission.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.txt_Permission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_Permission.ItemHeight = 44;
            this.txt_Permission.Items.AddRange(new object[] {
            "Admin",
            "Users"});
            this.txt_Permission.Location = new System.Drawing.Point(0, 3);
            this.txt_Permission.Name = "txt_Permission";
            this.txt_Permission.Size = new System.Drawing.Size(352, 50);
            this.txt_Permission.TabIndex = 0;
            this.txt_Permission.Tag = "Vui lòng chọn";
            // 
            // LoginForm
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 524);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.pnAccount);
            this.Controls.Add(this.lb_ForgotPass);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 580);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 580);
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnAccount.ResumeLayout(false);
            this.pnButton.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_Login_Click_1(object sender, EventArgs e)
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

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            SiginUp signUpForm = new SiginUp();
            signUpForm.Show();
            this.Hide();
        }
    }
}
