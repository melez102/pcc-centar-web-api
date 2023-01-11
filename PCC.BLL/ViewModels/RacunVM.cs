using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCC.BLL.Data;

namespace PCC.BLL.ViewModels
{
    public class RacunVM
    {

        public int Cena { get; set; }
        public DateTime Vreme { get; set; }

        public Lokacija Lokacija { get; set; }

        public Zaposleni Zaposleni { get; set; }

        public List<int> RacunariID { get; set; }
        public List<int> KomponenteID { get; set; }

        public List<int> KolicineRacunara { get; set; }
        public List<int> KolicineKomponenti { get; set; }

        //public List<RacunariVM> Racunari { get; set; }
        //public List<KomponenteVM> Komponente { get; set; }

    }

    public class RacunBezSadrzajaVM
    {
        public int Cena { get; set; }
        public DateTime Vreme { get; set; }

        public string Adresa { get; set; }
        public string Grad { get; set; }
        public string ImeZaposlenog { get; set; }
    }

    public class RacunZaGetVM2
    {
        //public Lokacija Lokacija { get; set; }
        public string ZaposleniIme { get; set; }
        public string LokacijaAdresa { get; set; }
        public string LokacijaGrad { get; set; }

        public DateTime VremeProdaje { get; set; }

        public List<RacunariVM> Racunari { get; set; }
        public List<KomponenteVM> Komponente { get; set; }

        public List<int> KolicineRacunara { get; set; }
        public List<int> KolicineKomponenti { get; set; }

    }

   

    public class LokacijaZaRacunVM
    {
        public string Adresa { get; set; }
        public int LokacijaID { get; set; }
        public string Grad { get; set; }
        
        
        
    }

    public class ZaposleniZaRacunVM
    {
        public string ZaposleniIme { get; set; }
        public int ZaposleniID { get; set; }
        public LokacijaZaRacunVM LokacijaZaRacunVM { get; set; }
    }
}
