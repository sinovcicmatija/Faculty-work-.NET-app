using Kadrovska.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kadrovska {
    public partial class FrmLogin : Form {
        public FrmLogin() {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e) {

        }

       

       

        private void txtUserName_TextChanged(object sender, EventArgs e) {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e) {

        }
        private void btnLogin_Click(object sender, EventArgs e) {

            var user = txtUserName.Text;
            var pass = txtPassword.Text;

            DjelatnikRepository repository = new DjelatnikRepository();

            if (repository.PronadiIme(user, pass)) {
                FrmOverview frmOverview = new FrmOverview();
                MessageBox.Show("Uspješna prijava!");
                frmOverview.ShowDialog();
                this.Hide();
            } else {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka.");
            }
            

        }
    }
}
