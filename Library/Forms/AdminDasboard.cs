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
                DgvTodaysRetuns.Rows.Add(item.Person.PersonID, item.Person.Name, item.Person.Surname, item.Person.Password, books);
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
                DgvTomorrow.Rows.Add(item.Person.PersonID, item.Person.Name, item.Person.Surname, item.Person.Password, books);


            }

            //Late
            DateTime now = new DateTime();
            now = DateTime.Now;

            List<Management> orderListLate = new List<Management>();
            orderListLate = _libraryContext.Management.Include("Person").Where(m => m.BookReturnDate < now).Distinct().ToList();

        }

        private void AdminDasboard_Load(object sender, EventArgs e)
        {

        }
        private void BtnTodayR_Click(object sender, EventArgs e)
        {
            DgvTodaysRetuns.Visible = true;
            DgvTomorrow.Visible = false;
            DgvLate.Visible = false;
        }

        private void BtnTomorrow_Click(object sender, EventArgs e)
        {
            DgvTodaysRetuns.Visible = false;
            DgvTomorrow.Visible = true;
            DgvLate.Visible = false;
        }

        private void BtnLate_Click(object sender, EventArgs e)
        {
            DgvTodaysRetuns.Visible = false;
            DgvTomorrow.Visible = false;
            DgvLate.Visible = true;
        }

        private void BtnPurchView_Click(object sender, EventArgs e)
        {

            //Interval

            DateTime start = new DateTime();
            start = dateTimePickerStart.Value;

            DateTime end = new DateTime();
            end = dateTimePickerEnd.Value;

            _libraryContext = new LibraryContext();

            List<Purchase> purchasesList = new List<Purchase>();

            purchasesList = _libraryContext.Purchase.Include("Management").Where(p => p.BookReturnededDate > start && p.BookReturnededDate < end).ToList();

            foreach (var item in purchasesList)
            {
                DgvExel.Rows.Add(item.PurchaseID, item.Money, item.BookReturnededDate);
            }
        }



        private void BtnExport_Click(object sender, EventArgs e)
        {
            //Export to excel at selected location
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                ToCsV(DgvExel, sfd.FileName);
            }

        }

        //Make en excel file
        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }

            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void BtnOpenUser_Click(object sender, EventArgs e)
        {
            PersonForm userForm = new PersonForm();
            userForm.Show();
        }

        private void BtnOpenBookCrud_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.Show();
        }
    }


  
}
