using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL.Data
{
    public class Zaposleni
    {

        public int ZaposleniID { get; set; }
        public string Ime { get; set; }
        public string JMBG { get; set; }
        public string Adresa { get; set; }

        //nav
        public Lokacija Lokacija { get; set; }

        public int LokacijaID { get; set; }

        public List<Racun> Racuni { get; set; }

        //private string Username { set; }

        //private string Password { set; }


    }
}
