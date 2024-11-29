using System;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class EditBookForm : Form
    {
        public EditBookForm()
        {
            InitializeComponent(); // Initializes UI components defined in the Designer file
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Logic for saving the edited book
            MessageBox.Show("Book edited successfully!", "Success");
            this.Close();
        }
    }
}
