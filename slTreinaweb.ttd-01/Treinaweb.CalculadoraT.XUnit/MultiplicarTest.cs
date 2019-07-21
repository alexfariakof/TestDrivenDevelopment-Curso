using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using twc = Treinaweb.Calculadora.Util;

namespace Treinaweb.CalculadoraT.XUnit
{
    public class MultiplicarTest : IDisposable
    {
        private twc.Calculadora _calc;

        public MultiplicarTest()
        {
            _calc = new twc.Calculadora();
        }

        public void Dispose()
        {
            _calc = null;
        }

        [Fact]
        public void TestMultiplicar()
        {
            Assert.Equal(16, _calc.Mutiplicar(8, 2));
        }

        [Fact]
        public void TestMultiplicarPrimeiroArgumentoAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _calc = new twc.Calculadora(2);
                _calc.Mutiplicar(1, 2);
            });
        }

        [Fact]
        public void TestMultiplicarSegundoArgumentoAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _calc = new twc.Calculadora(2);
                _calc.Mutiplicar(2, 1);
            });
        }

    }
}
