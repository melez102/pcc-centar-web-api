using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL
{
    internal class Trebovanje
    {
        public int TrebovanjeID { get; set; }
        public Zaposleni Poslao { get; set; }
        public DateTime VremeSlanja { get; set; }
        public DateTime VremePreuzimanja { get; set; }

        public Lokacija SaLokacije { get; set; }
        public Lokacija NaLokaciju { get; set; }

        public bool Preuzeto { get; set; }

        public Stanje Stanje { get; set; }
        public List<Racunar> ListaRacunar { get; set; }
        public List<Komponenta> ListaKomponenta { get; set; }


    }
}
