using System.Windows.Forms;
using System;

namespace BookManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Tải dữ liệu từ cơ sở dữ liệu và hiển thị trong DataGridView
            LoadBooks();
        }

        private void LoadBooks()
        {
            // Ví dụ: Lấy danh sách sách từ cơ sở dữ liệu và hiển thị vào DataGridView
            dataGridViewBooks.DataSource = BookService.GetAllBooks();
        }

        // Nút AddBook để mở cửa sổ thêm sách
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var addBookForm = new AddBookForm();
            addBookForm.ShowDialog();
        }
    }
}
