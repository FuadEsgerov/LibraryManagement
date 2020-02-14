using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Data;
using Library.Forms;
using Library.Models;


namespace Library.Forms
{
    
    public partial class BookForm : Form
    {
        private LibraryContext _libraryContext;
    private Book _selectedBook;
        public BookForm()
        {
          
            InitializeComponent();
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            TbBookID.Enabled = false;

            _libraryContext = new LibraryContext();
        }
        private void BookForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagement01DataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.DataSet1.Books);

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Book newBook = new Book()
            {
                bookName = TbBookName.Text,
                bookPrice = Convert.ToSingle(TbBookPrice.Text),
                bookGenre = TbBookGenre.Text
            };

            _libraryContext.Book.Add(newBook);
            _libraryContext.SaveChanges();

            this.booksTableAdapter.Fill(this.DataSet1.Books);


        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _selectedBook.bookName = TbBookName.Text;
            _selectedBook.bookGenre = TbBookGenre.Text;
            _selectedBook.bookPrice = Convert.ToSingle(TbBookPrice.Text);

            _libraryContext.SaveChanges();

            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            this.booksTableAdapter.Fill(this.DataSet1.Books);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _libraryContext.Book.Remove(_selectedBook);
            _libraryContext.SaveChanges();

            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            this.booksTableAdapter.Fill(this.DataSet1.Books);
        }

        private void DgvBookCrud_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _selectedBook = _libraryContext.Book.Find(DgvBookCrud.Rows[e.RowIndex].Cells[0].Value);

            TbBookID.Text = _selectedBook.bookID.ToString();
            TbBookName.Text = _selectedBook.bookName;
            TbBookGenre.Text = _selectedBook.bookGenre;
            TbBookPrice.Text = _selectedBook.bookPrice.ToString();

            BtnUpdate.Enabled = true;
            BtnDelete.Enabled = true;
        }

     
    }
}
