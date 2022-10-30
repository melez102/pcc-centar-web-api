using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL
{
    public class Komponenta
    {

        public int KomponentaID { get; set; }

        public int TipID { get; set; }
        public string Model { get; set; }
        public string Proizvodjac { get; set; }

        public string Info { get; set; }
        public double Cena { get; set; }

        private List<Racunar> Racunari { get; set; } = new List<Racunar>();
        private List<Racun> Racuni { get; set; } = new List<Racun>();

        

        public static string VratiImeTipa(int tipid)
        {
            string ImeTipa = "";

            var lista = Tip.PrikaziSveTipove();

            foreach(var item in lista)
            {
                if(item.TipID==tipid)
                {
                    ImeTipa = item.Ime;
                    break;
                }
            }


            return ImeTipa;

        }

        


        
        



    }
}
