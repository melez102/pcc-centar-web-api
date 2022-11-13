using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL.Data
{
    public class Komponenta_Porudzbina
    {

        public int Id { get; set; }
        public int PorudzbinaID { get; set; }
        public int KomponentaID { get; set; }
        

        public int Kolicina { get; set; }

        public Komponenta Komponenta { get; set; }
        public Porudzbina Porudzbina { get; set; }

    }
}
