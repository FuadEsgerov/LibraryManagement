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
    public partial class ReturnsForm : Form
    {
        private readonly LibraryContext _libraryContext;
        private Person _selectedPerson;
        int _selectedOrderID = 0;
        int _selectedRow = 0;
        public ReturnsForm(int id)
        {
            InitializeComponent();
            _selectedPerson = new Person();
            _libraryContext = new LibraryContext();
            _selectedPerson = _libraryContext.Person.Find(id);

            BtnConfirm.Enabled = false;
            TbPrice.ReadOnly = true;
            labelOverallCost.Visible = false;
            TBOverall.Visible = false;


            List<Management> testlist = new List<Management>();

            //Shows list of purchaes
            testlist = _libraryContext.Management.Include("Person").Include("Book").Where(m => m.Person.PersonID == _selectedPerson.PersonID).Where(m => m.returned == false).ToList();
            foreach (var item in testlist)
            {
                DgvMyPurchaes.Rows.Add(item.OrderID, item.Book.bookName, item.Book.bookPrice, item.BookReturnDate);
            }
        }

       
       

        public float Payment(DateTime returndate, float price)
        {
            DateTime now = new DateTime();
            now = DateTime.Now;

            //if its late
            if (DateTime.Compare(returndate, now) < 0)
            {
                int daysPassed = (now - returndate).Days;
                price += price * (0.005f) * daysPassed;
                return price;
            }
            return price;
        }

        private void DgvMyPurchaes_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Shows ReturnPrice of selected Book 
            TbPrice.Text = Payment((DateTime)DgvMyPurchaes.Rows[e.RowIndex].Cells[3].Value, (float)DgvMyPurchaes.Rows[e.RowIndex].Cells[2].Value).ToString();
            BtnConfirm.Enabled = true;
            _selectedOrderID = (int)DgvMyPurchaes.Rows[e.RowIndex].Cells[0].Value;
            _selectedRow = e.RowIndex;
        }

        //Its Sum button that shows the overall debt
        private void BtnPay_Click(object sender, EventArgs e)
        {

            labelOverallCost.Visible = false;
            TBOverall.Visible = false;
            float sum = 0;
            BtnConfirm.Enabled = true;

            foreach (DataGridViewRow dr in DgvMyPurchaes.Rows)
            {
                sum += Payment((DateTime)dr.Cells[3].Value, (float)dr.Cells[2].Value);
            }

            TBOverall.Text = sum.ToString();
        }

        //Confirm Return
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            date = DateTime.Now;

            Management management = new Management();
            management = _libraryContext.Management.Find(_selectedOrderID);

            Purchase purchase = new Purchase()
            {
                Money = Convert.ToSingle(TbPrice.Text),
                BookReturnededDate = date,
                Management = management
            };

            _libraryContext.Purchase.Add(purchase);
            management.returned = true;
            _libraryContext.SaveChanges();

            MessageBox.Show("Purchase Completed");

            DgvMyPurchaes.Rows.RemoveAt(_selectedRow);

        }

        ////Back Button
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    BookStoreForm bookStoreForm = new BookStoreForm(_selectedPerson.PersonID);
        //    bookStoreForm.Show();
        //}
    }
    }

