namespace InventarioProdutos.Test
{
    public class InventarioProdutosUnitTest
    {
        [Fact]
        public void AdcionarUmProdutoAoInventario()
        {
            InventarioProduto.Produto produto1 = new InventarioProduto.Produto();
            InventarioProduto.Produto produto2 = new InventarioProduto.Produto();
            produto1.Nome = "banana";
            produto1.Quantidade = 1;
            produto2.Nome = "banana";
            List<InventarioProduto.Produto> inventario = new List<InventarioProduto.Produto>();
            InventarioProduto.AdicionarProduto(produto1, inventario);
            InventarioProduto.AdicionarProduto(produto2, inventario);

            var quantidadeProduto = inventario[0].Quantidade;

            if (inventario.Count == 1)
            {
                //realiza o teste se o produto esta sendo adicionado corretamente ao inventario (certo)
                Assert.True(inventario.Count > 0);
            }
            else {
                //realiza o teste se o produto ""banana" incrementou 1 na propriedade "quantidade" (certo)
                Assert.True(quantidadeProduto == 2);
            }           
        }
    }
}