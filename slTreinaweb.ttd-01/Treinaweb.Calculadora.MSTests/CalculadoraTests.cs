using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using twc = Treinaweb.Calculadora.Util;

namespace Treinaweb.Calculadora.MSTests
{
    [TestClass]
    public class CalculadoraTests
    {
        private twc.Calculadora calc;


        [TestInitialize]
        public void SetUp()
        {
            calc = new twc.Calculadora();
        }

        [TestMethod]
        public void TestSomar()
        {            
            Assert.AreEqual(4, calc.Somar(2, 2));
        }

        [TestMethod]
        public void TestSubtrair()
        {
            Assert.AreEqual(0, calc.Subtrair(20, 30));
        }

        [TestMethod]
        public void TestMultiplicar()
        {
            Assert.AreEqual(0, calc.Subtrair(20, 30));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMultiplicarComException()
        {
            twc.Calculadora calc2 = new twc.Calculadora(limiteMinimo: 2);
            calc2.Mutiplicar(1, 1);
        }


        [TestMethod]
        [Ignore]
        public void TestDividir()
        {

        }

        [TestCleanup]
        public void CleanUp()
        {
            calc = null;
        }


    }
}
