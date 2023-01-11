using PCC.BLL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL.ViewModels
{
    public class NalogVM
    {
        

        public DateTime Izdato { get; set; }
        public DateTime? Izvrsen { get; set; }

        public List<int> RacunariIDs { get; set; }
        public List<int> Kolicine { get; set; }

    }

    public class NalogBezSadrzajaVM
    {
        public int NalogID { get; set; }
        public DateTime Izdato { get; set; }
        public DateTime? Izvrsen { get; set; }
        
    }


    public class NalogSaRacunarimaIKomponentamaVM
    {
        public int NalogID { get; set; }

        public DateTime Izdato { get; set; }
        public DateTime? Izvrsen { get; set; }

        public List<RacunariKomponenteVM> Racunari { get; set; }
        //public List<int> Kolicina { get; set; }

    }

    public class RacunariKomponenteVM
    {

        public int RacunarID { get; set; }
        public string Ime { get; set; }

        public int Kolicina { get; set; }

        //public List<int> KomponenteID { get; set; }
        //public List<string> KomponentaModel { get; set; }
        //public List<string> Proizvodjac { get; set; }
        public List<KomponenteVM> Komponente { get; set; }

    }

    public class KomponenteVM
    {
        public Komponenta.TipEnum Tip { get; set; }
        public int KomponentaID { get; set; }
        public string KomponentaModel { get; set; }
        public string Proizvodjac { get; set; }

        public int Kolicina { get; set; }
        
    }
}
