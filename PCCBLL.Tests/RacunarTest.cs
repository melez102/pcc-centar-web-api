using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCC.BLL;

namespace PCCBLL.Tests
{
    [TestClass]
    public class RacunarTest
    {
        [TestMethod]
        public void VracanjeNizaKomponenataIDIzRacunara()
        {
            //arrange

            /*var r = new Racunar(1, "Opasnost", 50000);
            r.ListaKomponenata.Add(new Komponenta { KomponentaID = 1415, Info = "stagod", Cena = 2500, Model = "x1", Proizvodjac = "micubisi", TipID = 2 });
            r.ListaKomponenata.Add(new Komponenta { KomponentaID = 2262, Info = "stagodd", Cena = 5000, Model = "x2", Proizvodjac = "micubisi", TipID = 3 });
            r.ListaKomponenata.Add(new Komponenta { KomponentaID = 3232, Info = "stagoddd", Cena = 25000, Model = "x3", Proizvodjac = "micubisi", TipID = 1 });
            r.ListaKomponenata.Add(new Komponenta { KomponentaID = 3232, Info = "stagoddd", Cena = 25000, Model = "x3", Proizvodjac = "micubisi", TipID = 1 });
            r.ListaKomponenata.Add(new Komponenta { KomponentaID = 2262, Info = "stagodd", Cena = 5000, Model = "x2", Proizvodjac = "micubisi", TipID = 3 });
            */
            var ListaID = new List<int>();
            

            //act


            var ZaProveru = new List<int> { 1415, 2262, 3232, 3232, 2262 };
            //ListaID = r.VratiKomponente();



            //assert

            CollectionAssert.AreEqual(ListaID, ZaProveru);

        }
    }
}
