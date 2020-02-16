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
    public partial class LoginForm : Form
    {
        private readonly LibraryContext _libraryContext;
        private bool LogedIn = false;
        public LoginForm()
        {
            _libraryContext = new LibraryContext();
            InitializeComponent();
        }
        RegistrationForm frm2 = new RegistrationForm();
        private void LoginForm_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void Registerlink(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (RegistrationForm frm = new RegistrationForm())
            {
                frm.ShowDialog();
                this.Close();
            }

        }
     

        private void TxtPassword_Click(object sender, EventArgs e)
        {
            TxtPassword.PasswordChar = '*';
        }

        private void ToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (RegistrationForm regfrm = new RegistrationForm())
            {
                regfrm.ShowDialog();
            }
        }

        public void LoginUser(string username, string password)
        {
            List<User> userList = new List<User>();
            userList = _libraryContext.User.ToList();

            foreach (User user in userList)
            {
                //Check if the admin or user exists
                if (username == user.Username && password == user.Password)
                {
                    MessageBox.Show("Welcome Admin");
                    LogedIn = true;

                    this.Hide();

                    AdminDasboard adminDash = new AdminDasboard();
                    adminDash.Show();

                    return;
                }
            }


        }

        public void LoginPerson(string email, string password)
        {
            List<Person> personList = new List<Person>();
            personList = _libraryContext.Person.ToList();

            foreach (Person person in personList)
            {
                if (email == person.Email && password == person.Password)
                {
                    MessageBox.Show("Welcome " + person.Name);
                    LogedIn = true;

                    this.Hide();

                    BookStoreForm bookStore = new BookStoreForm(person.PersonID);
                    bookStore.Show();

                    return;
                }
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            LoginUser(TxtEmail.Text, TxtPassword.Text);
            LoginPerson(TxtEmail.Text, TxtPassword.Text);
            //if no one logged in
            if (!LogedIn)
            {
                MessageBox.Show("Wrong Username or Password");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }


                       
       



       




   

      


      

  
   
 

