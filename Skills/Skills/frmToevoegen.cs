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
    public partial class frmToevoegen : Form
    {
        Login user;
        Database instance = new Database();
        public frmToevoegen(Login _user)
        {
            user = _user;
            InitializeComponent();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            if (IsValidData()) {
                pbGame.Load(txtImgUrl.Text);
                btnToevoegen.Enabled = true;
            }
        }

        private bool IsValidData() {
           return Validator.IsDecimal(txtDuration) &&
                    Validator.IsInt32(txtMaxAge) &&
                     Validator.IsInt32(txtMinAge) &&
                    Validator.IsInt32(txtMaxPlayers) &&
                    Validator.IsInt32(txtMinPlayers) &&
                     Validator.IsPresent(txtName) &&
                     Validator.IsPresent(txtType) &&
                     Validator.IsValidUrl(txtImgUrl) &&
                     Validator.IsDecimal(txtPrice);
        }

        private void frmToevoegen_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmHome home = new frmHome(user);
            home.Show();
        }
         
        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            //inserts new data in the database (new product)
            instance.Insert(instance.Count(), txtName.Text, Convert.ToDecimal(txtPrice.Text), Convert.ToInt32(txtMinPlayers.Text), Convert.ToInt32(txtMaxPlayers.Text), txtType.Text, Convert.ToInt32(txtMinAge.Text), Convert.ToInt32(txtMaxAge.Text), Convert.ToDouble(txtDuration.Text), txtImgUrl.Text); ;
            this.Close();
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
