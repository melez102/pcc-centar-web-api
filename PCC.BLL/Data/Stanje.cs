using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL.Data
{
    public class Stanje
    {

        

        public int StanjeID { get; set; }
        


        public Lokacija Lokacija { get; set; }

        public Racunar? Racunar { get; set; }
        public Komponenta? Komponenta { get; set; }
        public int Kolicina { get; set; }






    }
}
