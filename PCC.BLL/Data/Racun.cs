using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL.Data
{
    public class Racun
    {

        public int RacunID { get; set; }
        public int Cena { get; set; }
        public DateTime Vreme { get; set; }




        //private List<Stanje> Stanje { get; set; }

        //Navigation props

        public Zaposleni IzvrsioProdaju { get; set; }
        public int ZaposleniID { get; set; }
        public Lokacija NaLokaciji { get; set; }
        public int LokacijaID { get; set; }
        public List<Racun_Komponenta> Racun_Komponentas { get; set; }
        public List<Racun_Racunar> Racun_Racunars { get; set; }



    }
}
