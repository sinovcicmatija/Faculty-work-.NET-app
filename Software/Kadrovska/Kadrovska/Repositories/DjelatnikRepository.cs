using DBLayer;
using Kadrovska.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Kadrovska.Repositories {
    internal class DjelatnikRepository {

        public bool PronadiIme(string korisnickoIme, string lozinka) {

            string sql = $"SELECT COUNT(*) FROM djelatnik WHERE username = '{korisnickoIme}' AND password = '{lozinka}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            if (reader.Read()) {
                int count = reader.GetInt32(0);
                DB.CloseConnection();

                return count > 0;
            }

            DB.CloseConnection();
            return false;
        }


    }
}
