using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadrovska.Models {
    public class Zahtjev {

        public int ID_zahtjev { get; set; }

        public string VrstaZahtjeva { get; set; }

        public DateTime DatumPodnosenja { get; set; }

        public string Status { get; set; }

        public string Napomena { get; set; }

        public int DjelatnikID { get; set; }
    }
}
