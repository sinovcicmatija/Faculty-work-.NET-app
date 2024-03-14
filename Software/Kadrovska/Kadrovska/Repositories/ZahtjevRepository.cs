using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;
using Kadrovska.Models;

namespace Kadrovska.Repositories {
    public class ZahtjevRepository {

        public static Zahtjev GetZahtjev(int id) {
            Zahtjev zahtjev = null;
            string sql = $"SELECT * FROM Zahtjevi WHERE ID_zahtjeva = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows) {
                reader.Read();
                zahtjev = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return zahtjev;
        }


        public static List<Zahtjev> GetZahtjevi() {
            List<Zahtjev> zahtjevi = new List<Zahtjev>();
            string sql = "SELECT * FROM Zahtjevi";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {

                

                Zahtjev zahtjev = CreateObject(reader);
                zahtjevi.Add(zahtjev);
            }
            reader.Close();
            DB.CloseConnection();
            return zahtjevi;
        }
        public static void InsertZahtjev(string tb1, string tb2) {
            string sql = $"INSERT INTO [Zahtjevi] (VrstaZahtjeva, DatumPodnosenja, Status, Napomena) VALUES('{tb1}', GETDATE(), 'Zaprimljen', '{tb2}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
            MessageBox.Show("Uspješno slanje zahtjeva!");
        }
        public static void DeleteZahtjev(int zahtjevId) {
            string sql = $"DELETE FROM [Zahtjevi] WHERE ID_zahtjeva = {zahtjevId}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static List<Zahtjev> SearchZahtjev(string trazenaVrsta) {

            string sql = $"SELECT * FROM Zahtjevi WHERE VrstaZahtjeva LIKE '%{trazenaVrsta}%'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            List<Zahtjev> rezultati = new List<Zahtjev>();

            while (reader.Read()) {
                Zahtjev zahtjev = CreateObject(reader);
                rezultati.Add(zahtjev);
            }

            reader.Close();
            DB.CloseConnection();
            return rezultati;
        }
        public static void UpdateZahtjev(int zahtjevId, string novaNapomena) {
            string sql = $"UPDATE Zahtjevi SET Napomena = '{novaNapomena}' WHERE ID_zahtjeva = {zahtjevId}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

            private static Zahtjev CreateObject(SqlDataReader reader) {
            int id = int.Parse(reader["ID_zahtjeva"].ToString());
            string vrstaZahtjeva = reader["VrstaZahtjeva"].ToString();
            DateTime datumPodnosenja = (DateTime)reader["DatumPodnosenja"];
            string status = reader["Status"].ToString();
            string napomena = reader["Napomena"].ToString();
            var zahtjev = new Zahtjev {
                ID_zahtjev = id,
                VrstaZahtjeva = vrstaZahtjeva,
                DatumPodnosenja = datumPodnosenja.Date,
                Status = status,
                Napomena = napomena
            };
            return zahtjev;
        }



    }
}
