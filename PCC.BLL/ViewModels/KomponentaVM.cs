using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCC.BLL.Data;

namespace PCC.BLL.ViewModels
{
    public class KomponentaVM
    {
        //public enum TipEnum { Monitor, GPU, CPU, Kuciste, Tastatura, MaticnaPloca, RAM, HDD };
        public Komponenta.TipEnum Tip { get; set; }
        public int KomponentaID { get; set; }


        public string Model { get; set; }
        public string Proizvodjac { get; set; }

        public string Info { get; set; }
        public double Cena { get; set; }

        public double? ProdajnaCena { get; set; }

        
    }

    public class KomponentaZaPorudzbinuVM
    {

        public Komponenta.TipEnum Tip { get; set; }
        public int KomponentaID { get; set; }
        public string Model { get; set; }
        public string Proizvodjac { get; set; }
        public double Cena { get; set; }



    }
}
