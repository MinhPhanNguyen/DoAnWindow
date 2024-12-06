using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementSystem_Program
{
    internal class AccountInfo : Form
    {
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Panel pnAccount;
        private Guna.UI2.WinForms.Guna2Button btn_Update;
        private Guna.UI2.WinForms.Guna2Button btn_Close;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_Displayname;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_Password;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox txt_Newpassword;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox txt_Repassword;
        private Guna.UI2.WinForms.Guna2TextBox txt_Account;

        public AccountInfo()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountInfo));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnAccount = new System.Windows.Forms.Panel();
            this.txt_Account = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Update = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Close = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Displayname = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_Newpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_Repassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnAccount.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(345, 25);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(175, 40);
            this.guna2HtmlLabel1.TabIndex = 23;
            this.guna2HtmlLabel1.Text = "Thông tin";
            // 
            // pnAccount
            // 
            this.pnAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnAccount.BackColor = System.Drawing.Color.Transparent;
            this.pnAccount.Controls.Add(this.txt_Account);
            this.pnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnAccount.Location = new System.Drawing.Point(375, 80);
            this.pnAccount.Name = "pnAccount";
            this.pnAccount.Size = new System.Drawing.Size(334, 46);
            this.pnAccount.TabIndex = 19;
            // 
            // txt_Account
            // 
            this.txt_Account.Animated = true;
            this.txt_Account.AutoRoundedCorners = true;
            this.txt_Account.BackColor = System.Drawing.Color.Transparent;
            this.txt_Account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_Account.BorderColor = System.Drawing.Color.White;
            this.txt_Account.BorderRadius = 19;
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
            this.txt_Account.PlaceholderText = "";
            this.txt_Account.ReadOnly = true;
            this.txt_Account.SelectedText = "";
            this.txt_Account.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.txt_Account.Size = new System.Drawing.Size(328, 40);
            this.txt_Account.TabIndex = 9;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Transparent;
            this.btn_Update.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_Update.BorderRadius = 10;
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_Update.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_Update.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_Update.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_Update.Location = new System.Drawing.Point(246, 406);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_Update.Size = new System.Drawing.Size(151, 57);
            this.btn_Update.TabIndex = 33;
            this.btn_Update.Text = "Cập nhật";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_Close.BorderRadius = 10;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_Close.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_Close.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_Close.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_Close.Location = new System.Drawing.Point(488, 406);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btn_Close.Size = new System.Drawing.Size(151, 57);
            this.btn_Close.TabIndex = 34;
            this.btn_Close.Text = "Thoát";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel1.Location = new System.Drawing.Point(159, 80);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(200, 46);
            this.guna2Panel1.TabIndex = 35;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(0, 4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(163, 27);
            this.guna2HtmlLabel2.TabIndex = 36;
            this.guna2HtmlLabel2.Text = "Tên tài khoản:";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel2.Location = new System.Drawing.Point(159, 141);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(200, 46);
            this.guna2Panel2.TabIndex = 38;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(0, 4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(144, 27);
            this.guna2HtmlLabel3.TabIndex = 36;
            this.guna2HtmlLabel3.Text = "Tên hiển thị:";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txt_Displayname);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(375, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 46);
            this.panel1.TabIndex = 37;
            // 
            // txt_Displayname
            // 
            this.txt_Displayname.Animated = true;
            this.txt_Displayname.AutoRoundedCorners = true;
            this.txt_Displayname.BackColor = System.Drawing.Color.Transparent;
            this.txt_Displayname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_Displayname.BorderColor = System.Drawing.Color.White;
            this.txt_Displayname.BorderRadius = 19;
            this.txt_Displayname.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Displayname.DefaultText = "";
            this.txt_Displayname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Displayname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Displayname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Displayname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Displayname.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.txt_Displayname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_Displayname.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.txt_Displayname.Location = new System.Drawing.Point(0, 4);
            this.txt_Displayname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Displayname.Name = "txt_Displayname";
            this.txt_Displayname.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.txt_Displayname.PasswordChar = '\0';
            this.txt_Displayname.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_Displayname.PlaceholderText = "";
            this.txt_Displayname.SelectedText = "";
            this.txt_Displayname.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.txt_Displayname.Size = new System.Drawing.Size(328, 40);
            this.txt_Displayname.TabIndex = 9;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel3.Location = new System.Drawing.Point(159, 203);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(200, 46);
            this.guna2Panel3.TabIndex = 40;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(0, 4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(113, 27);
            this.guna2HtmlLabel4.TabIndex = 36;
            this.guna2HtmlLabel4.Text = "Mật khẩu:";
            this.guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txt_Password);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(375, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 46);
            this.panel2.TabIndex = 39;
            // 
            // txt_Password
            // 
            this.txt_Password.Animated = true;
            this.txt_Password.AutoRoundedCorners = true;
            this.txt_Password.BackColor = System.Drawing.Color.Transparent;
            this.txt_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_Password.BorderColor = System.Drawing.Color.White;
            this.txt_Password.BorderRadius = 19;
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Password.DefaultText = "";
            this.txt_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.txt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_Password.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.txt_Password.Location = new System.Drawing.Point(0, 4);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.txt_Password.PasswordChar = '●';
            this.txt_Password.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_Password.PlaceholderText = "";
            this.txt_Password.SelectedText = "";
            this.txt_Password.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.txt_Password.Size = new System.Drawing.Size(328, 40);
            this.txt_Password.TabIndex = 9;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel4.Location = new System.Drawing.Point(159, 267);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(200, 46);
            this.guna2Panel4.TabIndex = 42;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(0, 4);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(162, 27);
            this.guna2HtmlLabel5.TabIndex = 36;
            this.guna2HtmlLabel5.Text = "Mật khẩu mới:";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.txt_Newpassword);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(375, 267);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 46);
            this.panel3.TabIndex = 41;
            // 
            // txt_Newpassword
            // 
            this.txt_Newpassword.Animated = true;
            this.txt_Newpassword.AutoRoundedCorners = true;
            this.txt_Newpassword.BackColor = System.Drawing.Color.Transparent;
            this.txt_Newpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_Newpassword.BorderColor = System.Drawing.Color.White;
            this.txt_Newpassword.BorderRadius = 19;
            this.txt_Newpassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Newpassword.DefaultText = "";
            this.txt_Newpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Newpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Newpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Newpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Newpassword.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.txt_Newpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_Newpassword.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.txt_Newpassword.Location = new System.Drawing.Point(0, 4);
            this.txt_Newpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Newpassword.Name = "txt_Newpassword";
            this.txt_Newpassword.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.txt_Newpassword.PasswordChar = '●';
            this.txt_Newpassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_Newpassword.PlaceholderText = "";
            this.txt_Newpassword.SelectedText = "";
            this.txt_Newpassword.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.txt_Newpassword.Size = new System.Drawing.Size(328, 40);
            this.txt_Newpassword.TabIndex = 9;
            this.txt_Newpassword.UseSystemPasswordChar = true;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel5.Location = new System.Drawing.Point(159, 330);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(200, 46);
            this.guna2Panel5.TabIndex = 44;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(0, 4);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(103, 27);
            this.guna2HtmlLabel6.TabIndex = 36;
            this.guna2HtmlLabel6.Text = "Nhập lại:";
            this.guna2HtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.txt_Repassword);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(375, 330);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(334, 46);
            this.panel4.TabIndex = 43;
            // 
            // txt_Repassword
            // 
            this.txt_Repassword.Animated = true;
            this.txt_Repassword.AutoRoundedCorners = true;
            this.txt_Repassword.BackColor = System.Drawing.Color.Transparent;
            this.txt_Repassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_Repassword.BorderColor = System.Drawing.Color.White;
            this.txt_Repassword.BorderRadius = 19;
            this.txt_Repassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Repassword.DefaultText = "";
            this.txt_Repassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Repassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Repassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Repassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Repassword.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.txt_Repassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_Repassword.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.txt_Repassword.Location = new System.Drawing.Point(0, 4);
            this.txt_Repassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Repassword.Name = "txt_Repassword";
            this.txt_Repassword.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.txt_Repassword.PasswordChar = '●';
            this.txt_Repassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.txt_Repassword.PlaceholderText = "";
            this.txt_Repassword.SelectedText = "";
            this.txt_Repassword.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.txt_Repassword.Size = new System.Drawing.Size(328, 40);
            this.txt_Repassword.TabIndex = 9;
            this.txt_Repassword.UseSystemPasswordChar = true;
            // 
            // AccountInfo
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 484);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.pnAccount);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 540);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 540);
            this.Name = "AccountInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin tài khoản";
            this.pnAccount.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            TourBooking tourBooking = new TourBooking();
            tourBooking.Show();
            this.Close();
        }
    }
}
