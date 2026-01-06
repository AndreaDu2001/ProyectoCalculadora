using Xunit;
namespace CalculadoraApp.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Sumar_DosNumeros_RetornaSumaCorrecta()
        {
            // Arrange
            var calc = new CalculadoraApp.Calculadora();
            var resultado = calc.Sumar(1, 3);
            Assert.Equal(4, resultado);
            
        }
    }
}

