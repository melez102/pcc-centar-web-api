﻿using PCC.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PCCBLL.Tests
{
    [TestClass]
    public class ProizvodnjaTest
    {

        [TestMethod]

        public void ProveriBrojanje()
        {
            //arrange
            var broj = 0;
            Proizvodnja p=new Proizvodnja();
            broj=p.IzbrojKolicinu(3);
            var broj2 = p.IzbrojKolicinu(1);

            
            //act
            var g = 20;
            var g2 = 10;
            //assert

            Assert.AreEqual(broj, g);
            Assert.AreEqual(broj2, g2);

        }

        [TestMethod]

        public void IzbrojIsteElemente()
        {
            //arrange
           



            //act


            //assert
        }



    }
}