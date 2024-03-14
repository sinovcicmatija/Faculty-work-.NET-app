using DBLayer;
using Kadrovska.Models;
using Kadrovska.Repositories;
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


namespace Kadrovska {
    public partial class FrmOverview : Form {
        public FrmOverview() {
            InitializeComponent();
            this.Load += FrmOverview_Load;
        }


        private void FrmOverview_Load(object sender, EventArgs e) {
            ShowZahtjevi();
        }
        private void ShowZahtjevi() {
            List<Zahtjev> zahtjevi = ZahtjevRepository.GetZahtjevi();
            DataGridView1.DataSource = zahtjevi;

        }



        private void button1_Click(object sender, EventArgs e) {

            FrmAddChange frmAddChange = new FrmAddChange();
            Hide();
            frmAddChange.ShowDialog();
            Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {



        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e) {


        }



        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e) {

        }

        private void btnDelete_Click(object sender, EventArgs e) {

            if (DataGridView1.SelectedRows.Count > 0) {
                // Dohvatite ID zahtjeva odabranog retka
                int zahtjevId = Convert.ToInt32(DataGridView1.SelectedRows[0].Cells["ID_zahtjev"].Value);

                // Pozovite funkciju za brisanje podataka 
                /*string sql = $"DELETE FROM [Zahtjevi] WHERE ID_zahtjeva = {zahtjevId}";
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();*/
                ZahtjevRepository.DeleteZahtjev(zahtjevId);

                // Osvježite prikaz (popis zahtjeva)
                ShowZahtjevi();



            }
        }

        private void txtPretrazi_TextChanged(object sender, EventArgs e) {

        }

        private void btnPretrazi_Click(object sender, EventArgs e) {

            var trazenaVrsta = txtPretrazi.Text;
            List<Zahtjev> rezultati = ZahtjevRepository.SearchZahtjev(trazenaVrsta);


            if (rezultati.Count > 0) {
                DataGridView1.DataSource = rezultati;
                txtPretrazi.Text = string.Empty;
            } else {
                MessageBox.Show("Nema rezultata za pretragu.");
            }

        }

        private void btnOsvjezi_Click(object sender, EventArgs e) {
            ShowZahtjevi();
        }

        private void FrmOverview_Load_1(object sender, EventArgs e) {

        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == DataGridView1.Columns["Uredi"].Index && e.RowIndex >= 0) {
                // Dohvatite podatke iz odabranog retka
                int zahtjevId = Convert.ToInt32(DataGridView1.Rows[e.RowIndex].Cells["ID_zahtjeva"].Value);
                string vrstaZahtjeva = DataGridView1.Rows[e.RowIndex].Cells["VrstaZahtjeva"].Value.ToString();
                string napomena = DataGridView1.Rows[e.RowIndex].Cells["Napomena"].Value.ToString();

                // Stvorite FrmChange formu i prenesite podatke
                FrmChange frmChange = new FrmChange(zahtjevId, vrstaZahtjeva, napomena);
                frmChange.ShowDialog();

                // Osvježite prikaz nakon uređivanja (ako je potrebno)
                
            }
        }


        private void btnUredi_Click(object sender, EventArgs e) {


            if (DataGridView1.SelectedRows.Count > 0) {
                int zahtjevId = Convert.ToInt32(DataGridView1.SelectedRows[0].Cells["ID_zahtjev"].Value);
                string vrstaZahtjeva = DataGridView1.SelectedRows[0].Cells["VrstaZahtjeva"].Value.ToString();
                string napomena = DataGridView1.SelectedRows[0].Cells["Napomena"].Value.ToString();

                FrmChange frmChange = new FrmChange(zahtjevId, vrstaZahtjeva, napomena);
                this.Hide();
                frmChange.ShowDialog();
                this.Close();

            }
            
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}

