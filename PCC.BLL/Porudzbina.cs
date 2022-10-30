using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL
{
    public class Porudzbina
    {
        public Porudzbina(Lokacija l) {
            Preuzeto = false;
            VremePorudzbine = DateTime.Now;
            VremeIsporuke = null;
            Lokacija = l;
            ListaKomponenta = null;
            PorudzbinaID = 1;


        }
        int PorudzbinaID { get; set; }
        public DateTime VremePorudzbine { get; set; }
        public DateTime? VremeIsporuke { get; set; }

        public Lokacija Lokacija { get; set; }
        public bool Preuzeto { get; set; }

        public List<Komponenta> ListaKomponenta { get; set; }

        private static List<Komponenta> Korpa { get; set; }

        public Porudzbina NapraviPorudzbinu()
        {
            var lok = new Lokacija(1, "Pancevacka 4", "Beograd", "06525232", Lokacija.OdeljenjeEnum.Racunovodstvo);
            var p = new Porudzbina(lok);

            p.ListaKomponenta.AddRange(Korpa);
            Korpa.Clear();
            

            return p;
        }

        public void NapuniKorpu()
        {
            Korpa.Add(new Komponenta { KomponentaID = 1, Info = "stagod", Cena = 2500, Model = "x1", Proizvodjac = "micubisi", TipID = 2 });
            Korpa.Add(new Komponenta { KomponentaID = 2, Info = "stagodd", Cena = 5000, Model = "x2", Proizvodjac = "micubisi", TipID = 3 });
            Korpa.Add(new Komponenta { KomponentaID = 3, Info = "stagoddd", Cena = 25000, Model = "x3", Proizvodjac = "micubisi", TipID = 1 });

        }
    }
}
