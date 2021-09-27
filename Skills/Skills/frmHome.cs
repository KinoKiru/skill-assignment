using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skills
{
    public partial class frmHome : Form
    {
        Login user;
        Database instance = new Database();
        public frmHome(Login _user)
        {
            InitializeComponent();
            user = _user;
            check(user);
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            retrieveProducts();
        }

        private void check (Login login){
            if (login.Username == "admin")
            {

            }
            else {
                menuStrip1.Hide();
            }
            btnUser.Text = login.Username;
          }

        private void toevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmToevoegen Toevoegen = new frmToevoegen(user);
            Toevoegen.Show();
            this.Close();
        }

        private void verwijderenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerwijderen remove = new frmVerwijderen(user);
            remove.Show();
            this.Close();
        }

        //gets all the products from the database
        private void retrieveProducts() {
            try
            {
                 Row[] products = instance.Select();
                foreach (Row product in products) {
                    lbGames.Items.Add(product.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checks if the selected index is the same as the prodcut.id
            Row[] products = instance.Select();
            foreach (Row product in products)
            {
                if (product.Id == lbGames.SelectedIndex) {
                txtInfo.Text =  String.Format("naam: " + product.Name + "\r\n"
                                + "prijs: " + (product.Price / 100m) + "\r\n"
                                + "aantal spelers: " + product.MinPlayers + "-" + product.MaxPlayers + "\r\n"
                                + "type: " + product.Type + "\r\n"
                                + "leeftijd: " + product.MinAge + "-" + product.MaxAge + "\r\n"
                                + "speelduur: " + product.PlayDuration);
                    pbGame.Load(product.ImgUrl);
                }
            }
        }
    }
}
