using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using twc = Treinaweb.Calculadora.Util;
using Xunit;

namespace Treinaweb.CalculadoraT.XUnit
{
    public class SubtrairTest : IDisposable
    {
        private twc.Calculadora calc;

        public SubtrairTest()
        {
            calc = new twc.Calculadora();
        }
        [Fact]
        public void TestSubtrair()
        {
            Assert.Equal(3, calc.Subtrair(9, 6));
        }


        [Fact]
        public void TestSubtrairComLimite()
        {
            Assert.Equal(0, calc.Subtrair(4, 4));
        }

        [Fact]
        public void TestSubtrairPrimeiroArgumentoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                calc = new twc.Calculadora(3);
                calc.Subtrair(2, 2);
            });
        }

        [Fact]
        public void TestSubtrairSegundoArgumentoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                calc = new twc.Calculadora(5);
                calc.Subtrair(3, 3);
            });
        }

        public void Dispose()
        {
            calc = null;
        }
    }
}
