namespace BookManagementSystem
{
    partial class EditBookForm
    {
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Button btnSave;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();

            // Initialize components
            this.lblTitle.Text = "Title:";
            this.lblAuthor.Text = "Author:";
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // Set control positions and add them to the form
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.btnSave);
        }
    }
}
