using DBLayer;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kadrovska {
    public partial class FrmAddChange : Form {
        public FrmAddChange() {
            InitializeComponent();
            this.Load += FrmAddChange_Load;
        }

        private void txtNapomena_TextChanged(object sender, EventArgs e) {

        }


        private void cbmZahtjevi_SelectedIndexChanged(object sender, EventArgs e) {

        }
        private void vrsteZahtjeva() {
            cbmZahtjevi.Items.Add("Godišnji odmor");
            cbmZahtjevi.Items.Add("Slobodan dan");
            cbmZahtjevi.Items.Add("Stručno usavršavanje");
            cbmZahtjevi.Items.Add("Službeni put");
        }

        private void FrmAddChange_Load(object sender, EventArgs e) {
            vrsteZahtjeva();
        }

        private void btnPosalji_Click(object sender, EventArgs e) {

            
            var t1 = cbmZahtjevi.Text;
            var t2 = txtNapomena.Text;
           /* string sql = $"INSERT INTO [Zahtjevi] (VrstaZahtjeva, DatumPodnosenja, Status, Napomena) VALUES('{tb1}', GETDATE(), 'Zaprimljen', '{tb2}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();*/
            ZahtjevRepository.InsertZahtjev(t1, t2);
            FrmOverview frmOverview = new FrmOverview();
            this.Hide();
            frmOverview.ShowDialog();
            this.Close();
        }

        private void btnNatrag_Click(object sender, EventArgs e) {
            FrmOverview frmOverview = new FrmOverview();
            this.Hide();
            frmOverview.ShowDialog();
            this.Close();

        }

        private void FrmAddChange_Load_1(object sender, EventArgs e) {

        }
    }
}
