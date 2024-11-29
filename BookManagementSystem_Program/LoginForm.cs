using System;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Handle Login Button Click event
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Login logic here
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "password")
            {
                MessageBox.Show("Login Successful!");
                // Open the main form or other actions
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
