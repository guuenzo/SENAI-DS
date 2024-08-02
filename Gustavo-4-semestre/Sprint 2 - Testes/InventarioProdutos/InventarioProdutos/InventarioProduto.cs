using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace InventarioProdutos
{
    // Crie um teste unitário para o método AdicionarProduto que verifica se um produto(nome e quantidade) é adicionado corretamente ao inventário (se já houver um produto incrementar a quantidade, senão adicione).
    //Teste também um método para obter a quantidade de um produto buscando pelo nome.
    public class InventarioProduto
    {
        public static List<Produto> AdicionarProduto(Produto produto, List<Produto> inventario)
        {
            var produtoExistente = inventario.FirstOrDefault(x => x.Nome == produto.Nome);
            if (produtoExistente == null){ 
                inventario.Add(produto);
                return (inventario);
            }
            else
            {
                produtoExistente.Quantidade += produto.Quantidade;
                return (inventario);
            }
        }

        public static int BuscarQtdProdutoPeloNome(Produto produto, List<Produto> inventario) {
            var produtoBuscado = inventario.FirstOrDefault(x => x.Nome == produto.Nome);

            return produtoBuscado.Quantidade;
        }

        public class Produto
        {
            public string? Nome { get; set; }

            //public float? Preco { get; set; }

            public int Quantidade = 0;
        }
    }
}
