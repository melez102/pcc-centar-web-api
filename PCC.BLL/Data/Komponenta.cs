using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL.Data
{
    public class Komponenta
    {

        public enum TipEnum { Monitor, GPU, CPU, Kuciste, Tastatura, MaticnaPloca, RAM, HDD };
        public TipEnum Tip { get; set; }
        public int KomponentaID { get; set; }


        public string Model { get; set; }
        public string Proizvodjac { get; set; }

        public string Info { get; set; }
        public double Cena { get; set; }

        public double? ProdajnaCena { get; set; }

        //Navigation prop

        public List<Racunar_Komponenta> Racunar_Komponentas { get; set; }
        public List<Komponenta_Porudzbina> Komponenta_Porudzbinas { get; set; }
        public List<Racun_Komponenta> Racun_Komponentas { get; set; }
        public List<Trebovanje_Komponenta> Trebovanje_Komponentas { get; set; }



       /* public static string VratiImeTipa(int tipid)
        {
            string ImeTipa = "";

            var lista = Tip.PrikaziSveTipove();

            foreach (var item in lista)
            {
                if (item.TipID == tipid)
                {
                    ImeTipa = item.Ime;
                    break;
                }
            }


            return ImeTipa;

        }
       */








    }
}
