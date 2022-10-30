using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL
{
    public class Proizvodnja
    {

        public int ProizvodnjaID { get; set; }
        

        private Komponenta _komponentaId { get; set; }

        public static List<Stanje> StanjeFabrike = new List<Stanje> {
            new Stanje { Lokacija=new Lokacija {lokid=1 } Komponenta.KomponentaID = 1, , StanjeID = 1, RacunarID = null, Kolicina = 10 },
           /* new Stanje { KomponentaID = 2, LokacijaID = 1, StanjeID = 2, RacunarID = null, Kolicina = 10 },
            new Stanje { KomponentaID = 3, LokacijaID = 1, StanjeID = 3, RacunarID = null, Kolicina = 10 },
            new Stanje { KomponentaID = null, LokacijaID = 1, StanjeID = 4, RacunarID = 1, Kolicina = 10 },
            new Stanje { KomponentaID = 3, LokacijaID = 1, StanjeID = 5, RacunarID = null, Kolicina = 10 },
            new Stanje { KomponentaID = 3, LokacijaID = 1, StanjeID = 5, RacunarID = null, Kolicina = 10 },*/
        };

        public Nalog Nalog { get; set; }


       /* public static void UnesiKomponente()
        {   
            StanjeFabrike.Add(new Stanje { KomponentaID = 1, LokacijaID = 1, StanjeID = 1, RacunarID = null, Kolicina = 10 });
            StanjeFabrike.Add(new Stanje { KomponentaID = 2, LokacijaID = 1, StanjeID = 2, RacunarID = null, Kolicina = 10 });
            StanjeFabrike.Add(new Stanje { KomponentaID = 3, LokacijaID = 1, StanjeID = 3, RacunarID = null, Kolicina = 10 });
            StanjeFabrike.Add(new Stanje { KomponentaID = null, LokacijaID = 1, StanjeID = 4, RacunarID = 1, Kolicina = 10 });
            StanjeFabrike.Add(new Stanje { KomponentaID = 3, LokacijaID = 1, StanjeID = 5, RacunarID = null, Kolicina = 10 });
        }*/

        public void IzvrsiProizvodnju(Racunar r)
        {

            


        }

        public bool ValidirajNalog(Nalog n)
        {
            var b = false;

            



            return b;
        }

        public void ValidirajKomponentu(Komponenta k)
        {


            

        }


        public int IzbrojKolicinu(int kompid)
        {
            //UnesiKomponente();
            int kolicina=0;
            foreach(Stanje q in StanjeFabrike)
            {
                if(q.KomponentaID == kompid)
                {
                    kolicina += q.Kolicina;
                }

            }

            return kolicina;
        }

    }
}
