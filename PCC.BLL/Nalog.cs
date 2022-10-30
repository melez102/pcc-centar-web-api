using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL
{
    public class Nalog
    {
        public Nalog()
        {
            ID++;
            NalogID = ID;
            List<Racunar> RacunariZaporizvodnju = new List<Racunar>();
            List<int> Kolicina = new List<int>();
        }
       
        private static int ID;

        public int NalogID { get; }

        public DateTime Izdato { get; set; }
        public DateTime Izvrsen { get; set; }
        
        List<Racunar> RacunariZaProizvodnju { get; set; }

        List<int> Kolicina { get; set; }


        public void UnesiRacunar(Racunar r, int k)
        {
            RacunariZaProizvodnju.Add(r);
            Kolicina.Add(k);

        }

    }
}
