using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCC.BLL;

namespace PCCBLL.Tests
{
    [TestClass]
    public class NalogTest
    {
        [TestMethod]
        public void NalogIdProver()
        {
            //arrange

            Nalog n1 = new Nalog();
            Nalog n2 = new Nalog();
            Nalog n3 = new Nalog();

            //act




            //assert

            Assert.AreEqual(n1.NalogID, 1);
            Assert.AreEqual(n2.NalogID, 2);
            Assert.AreEqual(n3.NalogID, 3);
        }

    }
}
