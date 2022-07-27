using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tema_1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAdunare()
        {
            double expectedResult = 3+2;

            //Act
            double result = Program.adunare(2, 3);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestMethodScadere()
        {
            double expectedResult = 3-2;

            //Act
            double result = Program.scadere(2, 3);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestMethodInmultire()
        {
            double expectedResult = 3*2;

            //Act
            double result = Program.inmultire(2, 3);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestMethodImpartire()
        {
            double expectedResult = (double)3/2;

            //Act
            double result = Program.impartire(2, 3);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void TestVerificareNumere()
        {
            bool expectedResult = true;

            //Act
            bool result = Program.verificare_numere(0, 0);

            //Assert
            Assert.AreNotEqual(expectedResult, result);
        }
    }
}
