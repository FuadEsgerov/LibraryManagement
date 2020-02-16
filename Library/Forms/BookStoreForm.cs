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
    public partial class BookStoreForm : Form
    {
        private readonly LibraryContext _libraryContext;
        private Person _selectedPerson;
        private Book _selectedbook;
        public BookStoreForm(int personID)
        {
            InitializeComponent();
            returnDateLabel.Visible = false;
            dateTimePicker1.Visible = false;
            BtnConfirm.Visible = false;
            _selectedPerson = new Person();


            _libraryContext = new LibraryContext();

            _selectedPerson = _libraryContext.Person.Find(personID);

        

            _libraryContext = new LibraryContext();
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //Clears the Data Grid of all previous searches
            DgvSearchResult.Rows.Clear();
            DgvSearchResult.Refresh();

            List<Book> myBookList = new List<Book>();
            myBookList = Search(BookSearchBoxTB.Text);

            foreach (Book book in myBookList)
            {
                DgvSearchResult.Rows.Add(book.bookID, book.bookName, book.bookGenre, book.bookPrice);
            }

        }

        //Seaches for the Book from database with entered String
        public List<Book> Search(string searchStr)
        {
            List<Book> bookList = new List<Book>();
            bookList = _libraryContext.Book.Where(b => b.bookName.Contains(searchStr)).ToList();
            return bookList;
        }

        private void DgvSearchResult_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Show Buy Options
            returnDateLabel.Visible = true;
            dateTimePicker1.Visible = true;
            BtnConfirm.Visible = true;

            _selectedbook = new Book();

            //Take book from search DGV and add to cart DGV
            _selectedbook = _libraryContext.Book.Find(DgvSearchResult.Rows[e.RowIndex].Cells[0].Value);
            DgvCart.Rows.Add(_selectedbook.bookID, _selectedbook.bookName, _selectedbook.bookGenre, _selectedbook.bookPrice);

        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            //Gets user from login with ID
            Person person = _libraryContext.Person.Find(_selectedPerson.PersonID);

            Book book;


            foreach (DataGridViewRow dr in DgvCart.Rows)
            {
                //gets book from card row with BookID
                book = new Book();
                book = _libraryContext.Book.Find(dr.Cells[0].Value);
                //Creates management object
                Management management = new Management
                {
                   Person = person,
                    BookReturnDate = dateTimePicker1.Value.Date,
                    Book = book,
                    returned = false

                    // = book.bookPrice
                };

                _libraryContext.Management.Add(management);

                _libraryContext.SaveChanges();

            }
            MessageBox.Show("Purchase Completed");
        }

     

        private void BtnReturnBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReturnsForm returnsForm = new ReturnsForm(_selectedPerson.PersonID);
            returnsForm.Show();
        }
    }
}
