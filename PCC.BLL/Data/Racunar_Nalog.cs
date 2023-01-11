using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL.Data
{
    public class Racunar_Nalog
    {

        

        public int Id { get; set; }

        public int Kolicina { get; set; }

        public int RacunarID { get; set; }
        public int NalogID { get; set; }

        public Racunar Racunar { get; set; }
        public Nalog Nalog { get; set; }
    }
}
