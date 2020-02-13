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
    public partial class Dashboard : Form
    {
        private Form activeForm;

        public PersonForm User { get; internal set; }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            {
                activeForm=childForm;
                childForm.TopLevel=false;
                childForm.FormBorderStyle=FormBorderStyle.None;
                childForm.Dock=DockStyle.Fill;
                this.PanelDesktop.Controls.Add(childForm);
                childForm.BringToFront();
                childForm.Show();
                
            }
        
        }

        private void ActiveButton(object btnSender)
        {
                  
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.PersonForm(), sender);
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Book(), sender);
        }

        private void BtnStore_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.BookStore(), sender);
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ReturnsForm(), sender);
        }

        private void BtnAdminDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AdminDasboard(), sender);
        }

    }
}
