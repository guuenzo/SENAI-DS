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
            produto2.Quantidade = 1;
            List<InventarioProduto.Produto> inventario = new List<InventarioProduto.Produto>();
            InventarioProduto.AdicionarProduto(produto1, inventario);
            InventarioProduto.AdicionarProduto(produto2, inventario);

            var quantidadeProduto = inventario[0].Quantidade;

            //verifica se o produto esta sendo adicionado corretamente ao inventario 
            Assert.True(inventario.Count > 0);

            //verifica se o produto ""banana" incrementou 1 na propriedade "quantidade"
            Assert.True(quantidadeProduto == 2);
        }
    }
}