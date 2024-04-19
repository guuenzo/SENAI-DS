namespace Projeto_produto_16._05
{
    public class Marca
    {
        public int Codigo { get; private set; }
        public string NomeMarca { get; private set; }
        public DateTime DataCadastro { get; private set; }



        List<Marca> Marcas = new List<Marca>();
        public string Cadastrar(Marca _marca)
        {
            Marca m = new Marca();

            Console.WriteLine($"Digite o codigo da marca:");
            m.Codigo = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Digite o nome da marca:");
            m.NomeMarca = Console.ReadLine()!;

            m.DataCadastro = DateTime.Now;

            Marcas.Add(m);

            Console.WriteLine($"Marca cadastrada com sucesso!!");


            return "";
        }

        public void Listar()
        {
            if (Marcas.Count > 0)
            {
                foreach (var item in Marcas)
                {
                    Console.WriteLine(@$"
                    {Marcas.IndexOf(item) + 1}º Produto
                Codigo da marca: {item.Codigo}
                Nome da marca: {item.NomeMarca}
                Data de cadastro da marca: {item.DataCadastro}
                ");

                }
            }
            else
            {
                Console.WriteLine($"Nao e possivel listar as marcas pois nao possui nenhuma cadastrada.");

            }

        }

        public string Deletar(int codigo)
        {
            Marca m = Marcas.Find(x => x.Codigo == codigo);
            Marcas.Remove(m);
            return "";
        }
    }
}