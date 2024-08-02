namespace ConversaoTemperaturas.Test
{
    public class ConversaoTemperaturasUnitTest
    {
        [Fact]
        public void ConverterUmaTemperaturaEmCelsiusParaFahrenheit()
        {
            var celsius = 8;
            var respostaEsperada = 46.4;

            var resposta = ConversaoTemperatura.ConverterCelsiusParaFahrenheit(celsius);

            Assert.Equal(respostaEsperada, resposta);
        }
    }
}