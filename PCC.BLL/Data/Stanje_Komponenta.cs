using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL.Data
{
    public class Stanje_Komponenta
    {

        public int Id { get; set; }

        public int KomponentaID { get; set; }
        public int Kolicina { get; set; }

        public Komponenta Komponenta { get; set; }
        public Lokacija Lokacija { get; set; }

        public int LokacijaID { get; set; }
        


    }
}
