using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL.ViewModels
{
    public class PorudzbinaVM
    {

        public int PorudzbinaID { get; set; }
        public DateTime VremePorudzbine { get; set; }


        public bool Preuzeto { get; set; } = false;

        public int LokacijaID { get; set; }

        public List<int> KomponentaIDs { get; set; }

        public List<int> Kolicine { get; set; }
    }

    public class PorudzbinaPrikazVM
    {
        public int PorudzbinaID { get; set; }
        public DateTime VremePorudzbine { get; set; }

        public string Adresa { get; set; }
        public string Grad { get; set; }
        public int LokacijaID { get; set; }
        //public LokacijaVM Lokacija { get; set; }

        public List<KomponentaPrikazVM> Komponente { get; set; }
    }

    public class KomponentaPrikazVM
    {
        public int KomponentaID { get; set; }
        public string Model { get; set; }
        public double Cena { get; set; }
        public string Proizvodjac { get; set; }
        public int Kolicina { get; set; }
    }

    public class PorudzbinaLokacijaKomponentaVM
    {

        public int PorudzbinaID { get; set; }
        public DateTime VremePorudzbine { get; set; }

        public bool Preuzeto { get; set; }

        
        
        public string Adresa { get; set; }
        public string Grad { get; set; }

        public List<KomponentaZaPorudzbinuVM> Komponente { get; set; }

        public List<int> Kolicine { get; set; }
    }

    public class LokacijaVM
    {
        public string Adresa { get; set; }
        public string Grad { get; set; }

    }



}
