using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skills
{
    public partial class frmRegister : Form
    {
        frmLogin login = new frmLogin();
        List<Login> users = null;
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnStoppen_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private bool IsValidData() {
            return Validator.IsPresent(txtUsername) &&
                    Validator.IsPresent(txtPassword);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //if all textboxes are filled with info i save the new login to .xml file
            if (IsValidData())
            {

                Login log = new Login(txtUsername.Text, txtPassword.Text);
                users.Add(log);
                LoginDB.SaveLogin(users);

                //reopens the login form
                login.Show();
                this.Close();

            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            users = LoginDB.GetLogin();
        }
    }
}
