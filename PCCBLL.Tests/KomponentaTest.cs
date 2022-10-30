using PCC.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PCCBLL.Tests
{
    [TestClass]
    public class KomponentaTest
    {

        [TestMethod]

        public void ProveriPovracajImenaTipa()
        {
            //arrange

            var Odgovor = Komponenta.VratiImeTipa(3);

            //act

            var Ocekivano = "Monitor";
            
            //assert

            Assert.AreEqual(Odgovor, Ocekivano);


        }



    }
}
