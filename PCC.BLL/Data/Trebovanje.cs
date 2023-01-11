using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL.Data
{
    public class Trebovanje
    {
        public int TrebovanjeID { get; set; }
        public Zaposleni Poslao { get; set; }
        public DateTime VremeSlanja { get; set; }
        public DateTime? VremePreuzimanja { get; set; }

        public Lokacija SaLokacije { get; set; }
        public Lokacija NaLokaciju { get; set; }

        

        //public Stanje Stanje { get; set; }
        public List<Trebovanje_Racunar> Trebovanje_Racunars { get; set; }
        public List<Trebovanje_Komponenta> Trebovanje_Komponentas { get; set; }

        //public List<int> KolicineRacunara { get; set; }
        //public List<int> KolicineKomponenti { get; set; }
        

    }
}
