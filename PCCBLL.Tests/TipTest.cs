using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCC.BLL;
using System.Collections.Generic;

namespace PCCBLL.Tests
{
    [TestClass]
    public class TipTest
    {
        [TestMethod]
        public void PrikazSvihTipovaToStringTest()
        {


            //arrange

            var lista = new List<Tip>();
            lista=Tip.PrikaziSveTipove();
            var a="";
            var b="";

            //act

            var ZaProveru = new List<Tip>();

            ZaProveru.Add(new Tip() { TipID = 0, Ime = "GPU", ZaProdaju = false });
            ZaProveru.Add(new Tip() { TipID = 1, Ime = "CPU", ZaProdaju = false });
            ZaProveru.Add(new Tip() { TipID = 2, Ime = "Tastatura", ZaProdaju = true });
            ZaProveru.Add(new Tip() { TipID = 3, Ime = "Monitor", ZaProdaju = true });

            foreach(Tip tip in lista)
            {
                a += tip.ToString();
            }
            foreach (Tip tip in ZaProveru)
            {
                b += tip.ToString();
            }

            //assert

            Assert.AreEqual(a, b);

        }

        
            [TestMethod]
            public void PrikaziSveTipoveZaProdajuTest()
            {


            //arrange

            var tipp = new Tip();
            tipp = Tip.PrikaziSveTipoveZaProdaju(3);
                

                //act

                var ZaProveru = new Tip();

                ZaProveru.TipID = 3;
                ZaProveru.Ime = "Monitor";
                ZaProveru.ZaProdaju = true;
                
                

                

                //assert

                Assert.AreEqual(tipp.Ime, ZaProveru.Ime);
                Assert.AreEqual(tipp.TipID, ZaProveru.TipID);
                Assert.AreEqual(tipp.ZaProdaju, ZaProveru.ZaProdaju);

        }
        }
}