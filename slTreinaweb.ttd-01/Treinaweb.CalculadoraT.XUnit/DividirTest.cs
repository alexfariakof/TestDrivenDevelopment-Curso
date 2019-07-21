using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using twc = Treinaweb.Calculadora.Util;

namespace Treinaweb.CalculadoraT.XUnit
{
    public class DividirTest : IDisposable
    {
        private twc.Calculadora _calc;

        public DividirTest()
        {
            _calc = new twc.Calculadora();
        }

        public void Dispose()
        {
            _calc = null;
        }
        
        [Fact]
        public void TestDivisao()
        {
            Assert.Equal(2, _calc.Dividir(4, 2));
        }

        [Fact]
        public void TestDivisaoPrimeiroArgumentoAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => 
            {
                _calc = new twc.Calculadora(2);
                _calc.Dividir(1, 2);
            });
        }

        [Fact]
        public void TestDivisaoSegundoArgumentoAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _calc = new twc.Calculadora(2);
                _calc.Dividir(2, 1);
            });
        }

        [Fact]
        public void TestDivisaoPorZero()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                _calc.Dividir(2, 0);
            });
        }



    }
}
