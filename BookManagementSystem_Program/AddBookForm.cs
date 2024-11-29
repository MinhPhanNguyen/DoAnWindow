using System;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent(); // Initializes UI components defined in the Designer file
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Collect user input
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            int yearPublished = int.Parse(txtYear.Text);
            string genre = txtGenre.Text;

            // Perform validation
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
            {
                MessageBox.Show("Title and Author are required fields.", "Validation Error");
                return;
            }

            // Save the book (you can call a data access layer method here)
            MessageBox.Show("Book added successfully!", "Success");

            // Optionally close the form
            this.Close();
        }
    }
}
