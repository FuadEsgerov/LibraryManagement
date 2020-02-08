using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void FormClosed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtRegName.Text))
            {
                MessageBox.Show("Adınızı yazın");
                return;
            }
            if (string.IsNullOrEmpty(TxtRegSurname.Text))
            {
                MessageBox.Show("Soyadınızı yazın");
                return;
            }
            if (string.IsNullOrEmpty(TxtPhone.Text))
            {
                MessageBox.Show("Telefon nömrənizi yazın");
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

            //User user = _context.Users.FirstOrDefault(u => u.Status && u.Email == TxtEmail.Text && u.Password == TxtPassword.Text);

            //if(user!=null)
            //{
            //    DashboardForm dashboard = new DashboardForm();
            //    dashboard.User = user;

            //    dashboard.Show();

            //    this.Hide();
            //    return;
            //}
            MessageBox.Show("Qeydiyyatdan uğurla keçdiniz");
            this.Close();
        }

      
    }
}
