using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL.Data
{
    public class Racunar
    {
        
        public int RacunarID { get; set; }
        public string Ime { get; set; }

        public double Cena { get; set; }

        //Nav
        public List<Racunar_Komponenta> Racunar_Komponentas { get; set; }
        public List<Racunar_Nalog> Racunar_Nalogs { get; set; }
        public List<Trebovanje_Racunar> Trebovanje_Racunars { get; set; }
        
        public List<Racun_Racunar> Racun_Racunars { get; set; }




    }
}
