using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using twc = Treinaweb.Calculadora.Util;


namespace Treinaweb.CalculadoraT.NUnit
{
    [TestFixture]
    public class CalculadoraTest
    {
        private twc.Calculadora calc;
        [TestFixtureSetUp]
        public void SetUp()
        {
            calc = new twc.Calculadora();
        }

        [Test]
        public void TestSomar()
        {
            
            Assert.AreEqual(11, calc.Somar(5, 6));
        }

        [Test]
        public void TestSubtrair()
        {

            Assert.IsTrue(calc.Subtrair(6, 6) == 0);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMultiplicar()
        {
            Assert.AreEqual(12, calc.Mutiplicar(6, 2));
        }

        [Test]
        [Ignore("Método ainda não foi implementado.")]
        public void TestDividir()
        {

        }

        [TestFixtureTearDown]
        public void TeatDown()
        {
            calc = null;
        }

    }
}
