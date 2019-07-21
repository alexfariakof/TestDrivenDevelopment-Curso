using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using twc = Treinaweb.Calculadora.Util;

namespace Treinaweb.CalculadoraT.XUnit
{
    public class SomaTest : IDisposable
    {
        private twc.Calculadora _calc;

        public SomaTest()
        {
            _calc = new twc.Calculadora();
        }

        public void Dispose()
        {
            _calc = null;
        }

        [Fact]
        public void TestNumerosPositivos()
        {
            Assert.Equal(4, _calc.Somar(2, 2));
        }

        [Fact]
        public void TestSOmarAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _calc.Somar(-1, 0);
            });
        }

        [Fact]
        public void TestAbaixoLimiteSegundoArgumento()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _calc = new twc.Calculadora(limiteMinimo:1);
                _calc.Somar(1, -1);
            });
        }

        [Fact]
        public void TestAbaixoLimiteTodosArgumento()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _calc = new twc.Calculadora(1);
                _calc.Somar(-1, 1);
            });
        }

    }
}
