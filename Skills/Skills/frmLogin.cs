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
    public partial class frmLogin : Form
    {
        List<Login> users = new List<Login>();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            users = LoginDB.GetLogin();
            foreach (Login user in users) {
                if (txtUsername.Text == user.Username && txtPassword.Text == user.Password)
                {
                    frmHome form = new frmHome(user);
                    form.Show();
                    this.Hide();
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            register.Show();
            this.Hide();
        }
    }
}
