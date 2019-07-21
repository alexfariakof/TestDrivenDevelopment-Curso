using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using twc = Treinaweb.Calculadora.Util;
using Xunit;

namespace Treinaweb.CalculadoraT.XUnit
{
    public class TestCalculadora : IDisposable
    {
        private twc.Calculadora calc;

        public TestCalculadora()
        {
            calc = new twc.Calculadora();
        }
        [Fact]
        public void TestSomar()
        {
            Assert.Equal(15, calc.Somar(9, 6));
        }


        [Fact]
        public void TestSomarComLimite()
        {
            calc = new twc.Calculadora(2);
            Assert.Equal(8, calc.Somar(4, 4));
        }

        [Fact]
        public void TestSomarForaDoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                twc.Calculadora calc = new twc.Calculadora(3);
                calc.Somar(2, 2);
            });
        }
        
        public void Dispose()
        {
            calc = null;
        }
    }
}
