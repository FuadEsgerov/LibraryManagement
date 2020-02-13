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
        private readonly LibraryContext _context;
        public LoginForm()
        {
            _context = new LibraryContext();
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

   
      

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
                if (string.IsNullOrEmpty(TxtEmail.Text))
                {
                    MessageBox.Show("E-poçt yazın");
                    return;
                }

                if (string.IsNullOrEmpty(TxtPassword.Text))
                {
                    MessageBox.Show("Şifrə yazın");
                    return;
                }
            User user = _context.User.FirstOrDefault(u => u.Status && u.Email == TxtEmail.Text && u.Password == TxtPassword.Text);

            if (user != null)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();



                return;
            }
            MessageBox.Show("E-poçt və ya şifrə yalnışdır");
            }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }


                       
       



       




   

      


      

  
   
 

