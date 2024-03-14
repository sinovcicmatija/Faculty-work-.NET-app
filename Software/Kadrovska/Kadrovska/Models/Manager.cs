using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadrovska.Models {
    internal class Manager : Person {

        public string username { get; set; }

        public string password { get; set; }

        public string uloga { get; set; }
    }
}
