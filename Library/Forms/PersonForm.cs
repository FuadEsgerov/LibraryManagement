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


namespace Library.Forms
{
    public partial class PersonForm : Form
    {
        private LibraryContext _libraryContext;
        private Person _selectedPerson;
        public PersonForm()
        {
            _libraryContext = new LibraryContext();
            InitializeComponent();
           

            TbPersonID.Enabled = false;
            BtnAdd.Enabled = true;
            BtnDelete.Enabled = false;
            BtnUpdate.Enabled = false;
        }
        private void PersonForm_Load(object sender, EventArgs e)
        {
        
            this.peopleTableAdapter1.Fill(this.DataSet1.People);

        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {


            Person person = new Person()
            {
                    
                    Name = TbName.Text,
                    Surname = TbSurname.Text,
                    Email = TbEmail.Text,
                    Password = TbPassword.Text
                };

            _libraryContext.Person.Add(person);

            _libraryContext.SaveChanges();

             this.peopleTableAdapter1.Fill(this.DataSet1.People);

        }
       

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            _selectedPerson.Name = TbName.Text;
            _selectedPerson.Surname = TbSurname.Text;
            _selectedPerson.Email = TbEmail.Text;
            _selectedPerson.Password = TbPassword.Text;

            _libraryContext.SaveChanges();

            this.peopleTableAdapter1.Fill(this.DataSet1.People);

            BtnAdd.Enabled = true;
            BtnDelete.Enabled = false;
            BtnUpdate.Enabled = false;

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            _libraryContext.Person.Remove(_selectedPerson);
            _libraryContext.SaveChanges();

            this.peopleTableAdapter1.Fill(this.DataSet1.People);
            BtnAdd.Enabled = true;
            BtnDelete.Enabled = false;
            BtnUpdate.Enabled = false;
        }

        private void DgvUserCrud_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Edit Buttons
            BtnAdd.Enabled = false;
            BtnDelete.Enabled = true;
            BtnUpdate.Enabled = true;

            //Find the user object
            _selectedPerson = _libraryContext.Person.Find(DgvUserCrud.Rows[e.RowIndex].Cells[0].Value);

            //Edit the textboxes
            TbPersonID.Text = _selectedPerson.PersonID.ToString();
            TbName.Text = _selectedPerson.Name;
            TbSurname.Text = _selectedPerson.Surname;
            TbEmail.Text = _selectedPerson.Email;
            TbPassword.Text = _selectedPerson.Password;



        }
    }
}
