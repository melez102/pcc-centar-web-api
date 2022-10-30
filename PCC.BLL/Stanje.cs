using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL
{
    public class Stanje
    {

        public Stanje(Lokacija lok, Racunar rac, int kolicina)
        {
            ID++;
            StanjeID = ID;
            Lokacija = lok;
            Racunar = rac;
            
        }

        public Stanje(Lokacija lok, Komponenta komp, int kolicina)
        {
            ID++;
            StanjeID = ID;
            Lokacija = lok;
            Komponenta = komp;

        }

        public int StanjeID { get; set; }
        private static int ID { get; set; }
        

        public Lokacija Lokacija { get; set; }

        public Racunar? Racunar { get; set; }
        public Komponenta? Komponenta { get; set; }
        public int Kolicina { get; set; }

        




    }
}
