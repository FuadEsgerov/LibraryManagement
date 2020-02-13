using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;
using Library.Forms;
using Library.Data;


namespace Library.Forms
{
    public partial class RegistrationForm : Form
    {
        private readonly LibraryContext _context;
        public RegistrationForm()
        {
            _context = new LibraryContext();
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

      

        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtRegFullname.Text))
            {
                MessageBox.Show("Adınızı ve Soyadınızı yazın");
                return;
            }
            if (string.IsNullOrEmpty(TxtRegUsername.Text))
            {
                MessageBox.Show("Username yazın");
                return;
            }
            if (string.IsNullOrEmpty(TxtRegEmail.Text))
            {
                MessageBox.Show("E-poçt yazın");
                return;
            }

            if (string.IsNullOrEmpty(TxtRegPassword.Text))
            {
                MessageBox.Show("Şifrə yazın");
                return;
            }
            if (string.IsNullOrEmpty(comboBoxUsertype.Text))
            {
                MessageBox.Show("Level secin");
                return;
            }
            if (comboBoxUsertype.Text == "Admin" || comboBoxUsertype.Text == "Moderator")
            {
                Models.User user = new Models.User()
                {
                    Fullname = TxtRegFullname.Text,
                    Username = TxtRegUsername.Text,
                    Email = TxtRegEmail.Text,
                    Password = TxtRegPassword.Text,
                    Level = (comboBoxUsertype.Text == "Admin") ? UserLevel.Admin : UserLevel.Moderator,
                    Status = true
                };
                _context.User.Add(user);
                _context.SaveChanges();
                MessageBox.Show("Qeydiyyat ugurla aparildi");
            }
            else
            {
                MessageBox.Show("Level Duzgun Secilmeyib");
                return;
            }

     
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
