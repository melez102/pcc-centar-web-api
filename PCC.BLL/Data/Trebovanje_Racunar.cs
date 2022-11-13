using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL.Data
{
    public class Trebovanje_Racunar
    {

        public int Id { get; set; }
        public int Kolicina { get; set; }
        public int TrebovanjeID { get; set; }
        public int RacunarID { get; set; }

        public Trebovanje Trebovanje { get; set; }
        public Racunar Racunar { get; set; }
    }
}
