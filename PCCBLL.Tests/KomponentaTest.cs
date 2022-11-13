using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCC.BLL.Data;

namespace PCCBLL.Tests
{
    [TestClass]
    public class KomponentaTest
    {

        [TestMethod]

        public void ProveriPovracajImenaTipa()
        {
            //arrange

            //var Odgovor = Komponenta.VratiImeTipa(3);
            var Odgovor = "";

            //act

            var Ocekivano = "Monitor";
            
            //assert

            Assert.AreEqual(Odgovor, Ocekivano);


        }



    }
}
