using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL
{
    internal class Racun
    {

        public int RacunID { get; set; }
        public int Cena { get; set; }
        public DateTime Vreme { get; set; }
        public Zaposleni Zaposleni { get; set; }

        public Lokacija Lokacija { get; set; }

        private List<Stanje> Stanje { get; set; }

        public List<Racunar> ListaRacunar { get; set; }
        public List<Komponenta> ListaKomponenta { get; set; }



    }
}
