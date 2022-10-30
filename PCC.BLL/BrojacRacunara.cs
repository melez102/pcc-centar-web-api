using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCC.BLL
{
    public interface BrojacRacunara
    {

        public abstract List<int> Glavna { get; }
        private List<int> BrojanjeKomponenata(List<int> r)
        {
            var Glavna = new List<int>();
            return Glavna;
        }


    }
}
