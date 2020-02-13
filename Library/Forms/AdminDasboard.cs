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
using Library.Models;
using Library.Forms;
using System.Collections;
using System.IO;

namespace Library.Forms
{
    public partial class AdminDasboard : Form
    {
        private LibraryContext _libraryContext;
        public AdminDasboard()
        {
            InitializeComponent();
            _libraryContext = new LibraryContext();

            DgvTodaysRetuns.Visible = true;
            DgvTomorrow.Visible = false;
            DgvLate.Visible = false;

            //Today
            DateTime today = new DateTime();
            today = DateTime.Today;

            List<Management> orderListToday = new List<Management>();
            orderListToday = _libraryContext.Management.Include("Person").Where(m => m.BookReturnDate == today).Distinct().ToList();

            foreach (var item in orderListToday)
            {
                int books;
                books = _libraryContext.Management.Where(m => m.Person.PersonID == item.Person.PersonID && m.returned == false).Count();
                DgvTodaysRetuns.Rows.Add(item.Person.PersonID, item.Person.Name, item.Person.Surname, item.Person.Phone, books);
            }

            //Tomorrow
            DateTime tomorrow = new DateTime();
            tomorrow = today.AddDays(1);

            List<Management> orderListTmr = new List<Management>();
            orderListTmr = _libraryContext.Management.Include("Person").Where(m => m.BookReturnDate == tomorrow).Distinct().ToList();

            foreach (var item in orderListTmr)
            {
                int books;
                books = _libraryContext.Management.Where(m => m.Person.PersonID == item.Person.PersonID && m.returned == false).Count();
                DgvTomorrow.Rows.Add(item.Person.PersonID, item.Person.Name, item.Person.Surname, item.Person.Phone, books);


            }

            //Late
            DateTime now = new DateTime();
            now = DateTime.Now;

            List<Management> orderListLate = new List<Management>();
            orderListLate = _libraryContext.Management.Include("Person").Where(m => m.BookReturnDate < now).Distinct().ToList();
        }


    }
}
