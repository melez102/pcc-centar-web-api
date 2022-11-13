using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL.Data
{
    public class Racun_Komponenta
    {

        public int Id { get; set; }
        public int Kolicina { get; set; }
        public int RacunID { get; set; }
        public int KomponentaID { get; set; }

        public Racun Racun { get; set; }
        public Komponenta Komponenta { get; set; }
    }
}
