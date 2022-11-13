using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL.Data
{
    public class Nalog
    {
        

        public int NalogID { get; set; }

        public DateTime Izdato { get; set; }
        public DateTime? Izvrsen { get; set; }

        public List<Racunar> RacunariZaProizvodnju { get; set; }

        public List<int> Kolicina { get; set; }


        

    }
}
