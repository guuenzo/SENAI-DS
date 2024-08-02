using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos.Test
{
    public class CalculoUnitTest
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //Organizar (Arrange) 
            var n1 = 3.3;
            var n2 = 2.2;
            var valorEsperado = 5.5;

            //Agir (Act)
            var soma = Calculo.Somar(n1, n2);

            //Provar (Assert)
            Assert.Equal(valorEsperado, soma);
        }

        [Fact]
        public void SubtrairDoisNumeros()
        {
            var n1 = 2.5;
            var n2 = 0.5;
            var valorEsperado = 2.0;

            var subtração = Calculo.Subtrair(n1, n2);

            Assert.Equal(valorEsperado, subtração);
        }

        [Fact]
        public void MultiplicarDoisNumeros()
        {
            var n1 = 5;
            var n2 = 8;
            var valorEsperado = 40;
            x
            var multiplicação = Calculo.Multiplicar(n1, n2);

            Assert.Equal(valorEsperado, multiplicação);
        }

        [Fact]
        public void DividirDoisNumeros()
        {
            var n1 = 10;
            var n2 = 5;
            var valorEsperado = 2;

            var divisão = Calculo.Dividir(n1, n2);

            Assert.Equal(valorEsperado, divisão);
        }
    }
}
