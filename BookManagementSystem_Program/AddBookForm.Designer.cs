namespace BookManagementSystem
{
    public partial class AddBookForm
    {
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AddBookForm
            // 
            this.ClientSize = new System.Drawing.Size(1282, 521);
            this.Name = "AddBookForm";
            this.ResumeLayout(false);

        }
    }
}
