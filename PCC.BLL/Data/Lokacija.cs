using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL.Data
{
    public class Lokacija
    {
        

        public enum OdeljenjeEnum { Administracija, Skladiste, Proizvodnja, Prodaja, Racunovodstvo };

        public OdeljenjeEnum Odeljenje { get; set; }

        public int LokacijaID { get; set; }
        public string Adresa { get; set; }
        public string Grad { get; set; }

        public string Telefon { get; set; }
        
        public List<Zaposleni> Zaposleni { get; set; }

        public List<Racun> Racuni { get; set; }




    }
}
