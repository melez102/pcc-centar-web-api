using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PCC.BLL.Data.Komponenta;

namespace PCC.BLL.ViewModels
{
    public class RacunarVM
    {

        public int RacunarID { get; set; }
        public string Ime { get; set; }

        public double Cena { get; set; }

        public List<int> KomponenteID { get; set; }

        
    }
}
