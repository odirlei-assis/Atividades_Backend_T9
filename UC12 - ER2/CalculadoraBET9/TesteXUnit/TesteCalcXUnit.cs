using CalculadoraBET9;
using System;

namespace TesteXUnit
{
    public class TesteCalcXUnit
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //Arrange - Prepara��o
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //Act - A��o
            var resultado = Calculadora.Somar(pNum, sNum);

            //Assert - Verfica��o
            Assert.Equal(rNum, resultado);
        }



        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 2, 5)]
        [InlineData(5, 1, 6)]
        [InlineData(3, 4, 7)]
        [InlineData(6, 2, 3)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act - A��o
            var resultado = Calculadora.Somar(pNum, sNum);

            //Assert - Verfica��o
            Assert.Equal(rNum, resultado);
        }

    }
}