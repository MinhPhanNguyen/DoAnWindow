using System.Windows.Forms;
using BookManagementSystem_Program.Properties;

namespace BookManagementSystem_Program
{
    internal class SiginUp : Form
    {
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_Password;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Panel pnAccount;
        private Guna.UI2.WinForms.Guna2TextBox txt_Account;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_Phone;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox txt_Email;
        private Panel pnButton;
        private Guna.UI2.WinForms.Guna2Button btn_Signup;
        private Button button2;
        public SiginUp()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiginUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnAccount = new System.Windows.Forms.Panel();
            this.txt_Account = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnButton = new System.Windows.Forms.Panel();
            this.btn_Signup = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.pnAccount.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Location = new System.Drawing.Point(455, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 76);
            this.panel1.TabIndex = 17;
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
            this.txt_Password.Size = new System.Drawing.Size(328, 54);
            this.txt_Password.TabIndex = 9;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(377, 78);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(129, 34);
            this.guna2HtmlLabel1.TabIndex = 18;
            this.guna2HtmlLabel1.Text = "Đăng Ký";
            // 
            // pnAccount
            // 
            this.pnAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnAccount.BackColor = System.Drawing.Color.Transparent;
            this.pnAccount.Controls.Add(this.txt_Account);
            this.pnAccount.Location = new System.Drawing.Point(101, 148);
            this.pnAccount.Name = "pnAccount";
            this.pnAccount.Size = new System.Drawing.Size(334, 76);
            this.pnAccount.TabIndex = 16;
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
            this.txt_Account.Size = new System.Drawing.Size(328, 54);
            this.txt_Account.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txt_Phone);
            this.panel2.Location = new System.Drawing.Point(455, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 76);
            this.panel2.TabIndex = 17;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Animated = true;
            this.txt_Phone.AutoRoundedCorners = true;
            this.txt_Phone.BackColor = System.Drawing.Color.Transparent;
            this.txt_Phone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_Phone.BorderColor = System.Drawing.Color.White;
            this.txt_Phone.BorderRadius = 26;
            this.txt_Phone.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Phone.DefaultText = "";
            this.txt_Phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Phone.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.txt_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_Phone.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.txt_Phone.Location = new System.Drawing.Point(0, 4);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.txt_Phone.PasswordChar = '\0';
            this.txt_Phone.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_Phone.PlaceholderText = "Số điện thoại";
            this.txt_Phone.SelectedText = "";
            this.txt_Phone.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.txt_Phone.Size = new System.Drawing.Size(328, 54);
            this.txt_Phone.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.txt_Email);
            this.panel3.Location = new System.Drawing.Point(101, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 76);
            this.panel3.TabIndex = 17;
            // 
            // txt_Email
            // 
            this.txt_Email.Animated = true;
            this.txt_Email.AutoRoundedCorners = true;
            this.txt_Email.BackColor = System.Drawing.Color.Transparent;
            this.txt_Email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_Email.BorderColor = System.Drawing.Color.White;
            this.txt_Email.BorderRadius = 26;
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Email.DefaultText = "";
            this.txt_Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Email.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.txt_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_Email.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.txt_Email.Location = new System.Drawing.Point(0, 4);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.txt_Email.PasswordChar = '\0';
            this.txt_Email.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_Email.PlaceholderText = "Email";
            this.txt_Email.SelectedText = "";
            this.txt_Email.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.txt_Email.Size = new System.Drawing.Size(328, 54);
            this.txt_Email.TabIndex = 9;
            // 
            // pnButton
            // 
            this.pnButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnButton.BackColor = System.Drawing.Color.Transparent;
            this.pnButton.Controls.Add(this.btn_Signup);
            this.pnButton.Location = new System.Drawing.Point(355, 371);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(180, 69);
            this.pnButton.TabIndex = 19;
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
            this.btn_Signup.Location = new System.Drawing.Point(3, 3);
            this.btn_Signup.Name = "btn_Signup";
            this.btn_Signup.PressedColor = System.Drawing.Color.White;
            this.btn_Signup.Size = new System.Drawing.Size(172, 63);
            this.btn_Signup.TabIndex = 1;
            this.btn_Signup.Text = "Đăng Ký";
            this.btn_Signup.Click += new System.EventHandler(this.btn_Signup_Click_1);
            // 
            // SiginUp
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 533);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.pnAccount);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 580);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 580);
            this.Name = "SiginUp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            this.Load += new System.EventHandler(this.SiginUp_Load);
            this.panel1.ResumeLayout(false);
            this.pnAccount.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SiginUp_Load(object sender, System.EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Signup_Click_1(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Account.Text))
            {
                MessageBox.Show("Please enter your account!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_Phone.Text))
            {
                MessageBox.Show("Please enter your number phone!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_Email.Text))
            {
                MessageBox.Show("Please enter your email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_Password.Text))
            {
                MessageBox.Show("Please enter your password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Signup Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoginForm l = new LoginForm();
            this.Hide();
            l.ShowDialog();
        }
    }
}
