using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL
{
    public class Racunar
    {
        public Racunar(int racid, string ime, double cena)
        {
            RacunarID= racid;
            Ime= ime;
            Cena= cena;
            this.ListaKomponenata = new List<Komponenta>();
        }
        public int RacunarID { get; set; }
        public string Ime { get; set; }

        public double Cena { get; set; }


        public List<Komponenta> ListaKomponenata { get; set; }

        

        public void UnesiKomponente() 
        {
            

        }


        public List<int> VratiKomponente()
        {
            var k=new List<int>();
            foreach(Komponenta komp in ListaKomponenata)
            {
                k.Add(komp.KomponentaID);
            }

            return k;
            


        }
        
    }
}
