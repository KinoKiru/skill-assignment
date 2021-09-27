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
    public partial class frmVerwijderen : Form
    {
        Login user;
        Database instance = new Database();
        public frmVerwijderen(Login _user)
        {
            InitializeComponent();
            user = _user;
        }

        private void frmVerwijderen_Load(object sender, EventArgs e)
        {
            retrieveProducts();
        }

        private void frmVerwijderen_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmHome home = new frmHome(user);
            home.Show();
        }

        private void retrieveProducts()
        {
            try
            {
                Row[] products = instance.Select();
                foreach (Row product in products)
                {
                    lbGames.Items.Add(product.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            //if the selected index and name is the same as the product id and name remove the product
            Row[] products = instance.Select();
            foreach (Row product in products)
            {
                if (product.Id == lbGames.SelectedIndex && product.Name == lbGames.SelectedItem.ToString())
                {
                    instance.Delete(product.Id);
                    lbGames.Items.RemoveAt(product.Id);
                }
            }
        }

        private void btnnStoppen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
