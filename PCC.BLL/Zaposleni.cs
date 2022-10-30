using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL
{
    public class Zaposleni
    {

        public int ZaposleniID { get; set; }
        public string Ime { get; set; }
        public string JMBG { get; set; }
        public string Adresa { get; set; }
        public Lokacija Lokacija { get; set; }

        public int OdeljenjeID { get; }

        //private string Username { set; }

        //private string Password { set; }


    }
}
