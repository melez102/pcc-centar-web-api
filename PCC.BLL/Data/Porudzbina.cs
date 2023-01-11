using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL.Data
{
    public class Porudzbina
    {
        


        public int PorudzbinaID { get; set; }
        public DateTime VremePorudzbine { get; set; }
        public DateTime? VremeIsporuke { get; set; }

        //Navigation props
        public Lokacija Lokacija { get; set; }
        public int LokacijaID { get; set; }
        public List<Komponenta_Porudzbina> Komponenta_Porudzbinas { get; set; }

        



       
    }
}
