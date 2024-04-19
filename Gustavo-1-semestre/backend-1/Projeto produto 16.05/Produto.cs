namespace Projeto_produto_16._05
{
    public class Produto
    {
        public int Codigo { get; private set; }
        public string NomeProduto { get; private set; }
        public float Preco { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public Marca Marca { get; private set; }
        public Usuario CadastradoPor { get; private set; }



        List<Produto> Produtos = new List<Produto>();
        public string Cadastrar(Produto _produto)
        {
            Produto p = new Produto();

            Console.WriteLine($"Digite o codigo do produto:");
            p.Codigo = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Digite o nome do produto:");
            p.NomeProduto = Console.ReadLine()!;

            p.DataCadastro = DateTime.Now;

            Produtos.Add(p);

            Console.WriteLine($"Produto cadastrado com sucesso!!");


            return "";
        }

        public void Listar()
        {
            if (Produtos.Count > 0)
            {
                foreach (var item in Produtos)
                {
                    Console.WriteLine(@$"
                {Produtos.IndexOf(item) + 1}º Produto
                Codigo do produto: {item.Codigo}
                Nome do produto: {item.NomeProduto}
                Data de cadastro do produto: {item.DataCadastro}
                ");

                }
            }
            else
            {
                Console.WriteLine($"Nao e possivel listar os produtos pois nao possui nenhum cadastrado.");

            }
        }

        public string Deletar(int codigo)
        {
            Produto p = Produtos.Find(x => x.Codigo == codigo);
            Produtos.Remove(p);
            return "";
        }
    }
}