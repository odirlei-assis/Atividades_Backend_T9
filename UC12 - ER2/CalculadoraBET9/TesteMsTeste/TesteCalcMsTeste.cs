using CalculadoraBET9;

namespace TesteMsTeste
{
    [TestClass]
    public class TesteCalcMsTeste
    {
        [TestMethod]
        public void TesteSomaDoisNumeros()
        {
            //Arrange - Preparação
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;


            //Act - Ação
            var resultado = Calculadora.Somar(pNum, sNum);

            //Assert - Verificação
            Assert.AreEqual(rNum, resultado);
        }




        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 2, 5)]
        [DataRow(3, 3, 6)]
        [DataRow(3, 4, 8)]
        public void TesteSomaDoisNumerosList(double pNum, double sNum, double rNum)
        {
            //Act - Ação
            var resultado = Calculadora.Somar(pNum, sNum);

            //Assert - Verificação
            Assert.AreEqual(rNum, resultado);
        }

    }
}