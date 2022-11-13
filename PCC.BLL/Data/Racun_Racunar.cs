using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL.Data
{
    public class Racun_Racunar
    {

        public int Id { get; set; }
        public int Kolicina { get; set; }
        public int RacunID { get; set; }
        public int RacunarID { get; set; }

        public Racun Racun { get; set; }
        public Racunar Racunar { get; set; }
    }
}
