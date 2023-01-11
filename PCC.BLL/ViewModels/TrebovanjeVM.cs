using PCC.BLL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL.ViewModels
{
    public class TrebovanjeVM
    {

        public Zaposleni Poslao { get; set; }
        public DateTime VremeSlanja { get; set; }
        public DateTime? VremePreuzimanja { get; set; }

        public Lokacija SaLokacije { get; set; }
        public Lokacija NaLokaciju { get; set; }


        //public Stanje Stanje { get; set; }
        public List<int> RacunariID { get; set; }
        public List<int> KomponenteID { get; set; }

        public List<int> KolicineRacunara { get; set; }
        public List<int> KolicineKomponenti { get; set; }


    }

    public class TrebovanjeBezSadrzajaVM
    {
        public String Poslao { get; set; }

        public DateTime VremeSlanja { get; set; }
        public DateTime? VremePreuzimanja { get; set; }

        public string SaAdrese { get; set; }
        public string IzGrada { get; set; }
        public string NaAdresu { get; set; }
        public string UGrad { get; set; }



    }

    public class TrebovanjeGlavnoVM
    {
        public string SaLokacijeAdresa { get; set; }
        public string NaLokacijuAdresa { get; set; }

        public string Poslao { get; set; }
        public DateTime VremeSlanja { get; set; }

        public DateTime? VremePreuzimanja { get; set; }
        public List<RacunariVM> Racunari { get; set; }
        public List<KomponenteVM> Komponente { get; set; }

        public List<int> KolicineRacunara { get; set; }
        public List<int> KolicineKomponenti { get; set; }

    }


    public class LokacijaTVM
    {
        public string Adresa { get; set; }
        public string Grad { get; set; }

        public Zaposleni Poslao { get; set; }

    }
    
    public class ZaposleniVM
    {
        public int ZaposleniID { get; set; }
        public string Ime { get; set; }
    }

    public class RacunariVM
    {
        public int RacunarID { get; set; }
        public string Ime { get; set; }

        public int Kolicina { get; set; }

    }
}
