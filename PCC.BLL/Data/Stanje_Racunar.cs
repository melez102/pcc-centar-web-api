using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL.Data
{
    public class Stanje_Racunar
    {

        public int Id { get; set; }

        public int LokacijaID { get; set; }
        public int RacunarID { get; set; }
        public int Kolicina { get; set; }

        public Racunar Racunar { get; set; }
        public Lokacija Lokacija { get; set; }



    }
}
