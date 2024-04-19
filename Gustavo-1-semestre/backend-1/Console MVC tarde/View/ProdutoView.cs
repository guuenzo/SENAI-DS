using Console_MVC_tarde.Model;

namespace Console_MVC_tarde.View
{
    public class ProdutoView
    {
        //metodo para exibir os dados da lista no console 
        public void Listar(List<Produto> produto)
        {
            foreach (var item in produto)
            {
                Console.WriteLine($"\nCodigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preco: {item.Preco:C}");
            }
        }

        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Informe o codigo:");
            novoProduto.Codigo = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Informe o nome:");
            novoProduto.Nome = Console.ReadLine();

            Console.WriteLine($"Informe o preco:");
            novoProduto.Preco = float.Parse(Console.ReadLine()!);

            return novoProduto;
        }
    }
}