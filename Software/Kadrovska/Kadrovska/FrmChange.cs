using DBLayer;
using Kadrovska.Models;
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
    public partial class FrmChange : Form {
        private int zahtjevID;

        public FrmChange(int zahtjevId, string vrstaZahtjeva, string napomena) {
            InitializeComponent();
            txtVrstaZahtjeva.Text = vrstaZahtjeva;
            txtNapomena.Text = napomena;
            txtVrstaZahtjeva.Enabled = false;
            zahtjevID = zahtjevId;
        }

        private void FrmChange_Load(object sender, EventArgs e) {

        }

        private void btnNatrag_Click(object sender, EventArgs e) {
            FrmOverview frmOverview = new FrmOverview();
            this.Hide();
            frmOverview.ShowDialog();
            this.Close();
        }

        private void txtVrstaZahtjeva_TextChanged(object sender, EventArgs e) {

        }

        private void txtNapomena_TextChanged(object sender, EventArgs e) {

        }

        private void btnSpremiPromjene_Click(object sender, EventArgs e) {

            string novaNapomena = txtNapomena.Text;
            ZahtjevRepository.UpdateZahtjev(zahtjevID,txtNapomena.Text);
            MessageBox.Show("Promjene uspješno spremljene!");
            FrmOverview frmOverview = new FrmOverview();
            this.Hide();
            frmOverview.ShowDialog();
            this.Close();

        }

      

        private void txtID_TextChanged(object sender, EventArgs e) {

        }
    }
}
