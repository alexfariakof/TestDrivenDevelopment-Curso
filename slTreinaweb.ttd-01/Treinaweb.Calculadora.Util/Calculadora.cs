using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinaweb.Calculadora.Util
{
    public class Calculadora
    {
        public int _limiteMinimo;

        public Calculadora(int limiteMinimo = 0)
        {
            _limiteMinimo = limiteMinimo;
        }

        public int Somar(int a, int b)
        {
            if ((a < _limiteMinimo) || (b < _limiteMinimo))
            {
                throw new ArgumentOutOfRangeException("Argumento está abaixo do limite mínimo.");
            }
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            if ((a < _limiteMinimo) || (b < _limiteMinimo))
            {
                throw new ArgumentOutOfRangeException("Argumento está abaixo do limite mínimo.");
            }
            return a - b;
        }

        public int Mutiplicar(int a, int b)
        {
            throw new ArgumentOutOfRangeException();
        }


        public int Dicidir (int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
