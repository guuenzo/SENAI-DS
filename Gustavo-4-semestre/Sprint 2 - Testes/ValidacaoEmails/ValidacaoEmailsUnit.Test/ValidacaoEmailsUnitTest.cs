using ValidacaoEmails;

namespace ValidacaoEmailsUnit.Test
{
    public class ValidacaoEmailsUnitTest
    {
        [Fact]
        public void ValidarSeUmEmailContemCaracteresEspecificos()
        {
            var email = "gustavoenzo463@gmail.com";
            var respostaEsperada = true;

            var resposta = ValidacaoEmail.ValidarEmail(email);

            Assert.Equal(respostaEsperada, resposta);
        }
    }
}