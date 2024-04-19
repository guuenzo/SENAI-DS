using Console_MVC_tarde.Model;
using Console_MVC_tarde.View;

namespace Console_MVC_tarde.Controller
{
    public class ProdutoController
    {
        //instancia das classes
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        //metodo controlador para acessar a listagem de produtos
        public void ListarProdutos()
        {
            //chamada da model trazendo a lista
            List<Produto> produtos = produto.Ler();

            //chamada da view passando a lista
            produtoView.Listar(produtos);
        }

        public void Cadastrar()
        {
            Produto novoProduto = produtoView.Cadastrar();

            produto.Inserir(novoProduto);
        }
    }
}