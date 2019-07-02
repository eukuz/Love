using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Love.DB
{
    class AnketaShown
    {
        public int Id { get; set; }

        public string FIO { get; set; }

        public int? Age { get; set; }

        public string Pol { get; set; }

        public string Phone { get;  set; }

        public string City { get; set; }

        public  Uvlechenia Uvlechenia { get; set; }

    }
}
