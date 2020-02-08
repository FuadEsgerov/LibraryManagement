using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Library.Data;
//using Library.Models;


namespace Library.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

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

        private void FormClosed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
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
                //User user = _context.Users.FirstOrDefault(u => u.Status && u.Email == TxtEmail.Text && u.Password == TxtPassword.Text);

                //if(user!=null)
                //{
                //    DashboardForm dashboard = new DashboardForm();
                //    dashboard.User = user;

                //    dashboard.Show();

                //    this.Hide();
                //    return;
                //}
                MessageBox.Show("E-poçt və ya şifrə yalnışdır");
            }
        }
    }


                       
       



       




   

      


      

  
   
 

