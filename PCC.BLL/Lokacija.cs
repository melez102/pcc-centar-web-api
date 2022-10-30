using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL
{
    public class Lokacija
    {
        public Lokacija(int lokid, string adr, string grad, string tele, OdeljenjeEnum od)
        {
            LokacijaID = lokid;
            Adresa = adr;
            Grad = grad;
            Telefon = tele;
            Odeljenje = od;
            

        }

        public enum OdeljenjeEnum { Administracija, Skladiste, Proizvodnja, Prodaja, Racunovodstvo };

        public OdeljenjeEnum Odeljenje { get; set; }

        public int LokacijaID { get; set; }
        public string Adresa { get; set; }
        public string Grad { get; set; }

        public string Telefon { get; set; }
        //public Odeljenje Odeljenje { get; set; }






    }
}
