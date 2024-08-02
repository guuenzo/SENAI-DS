namespace GerenciamentoLivros.Test
{
    public class GerenciamentoLivrosUnitTest
    {
        [Fact]
        public void AdicionarUmLivroNaListaDeLivros()
        {
            var livro = new GerenciamentoLivro.Livro();
            var respostaEsperada = true;

            var resposta = GerenciamentoLivro.AdcionarLivro(livro);

            Assert.Equal(respostaEsperada, resposta);
        }
    }
}