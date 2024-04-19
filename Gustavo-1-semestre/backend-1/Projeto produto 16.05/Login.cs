namespace Projeto_produto_16._05
{
    public class Login
    {
        public bool Logado { get; set; }
        public Login()
        {
            Usuario usuario = new Usuario();

            Logar(usuario);

            if (Logado == true)
            {
                GerarMenu();
            }

        }

        public string Logar(Usuario usuario)
        {
            bool validarLogin = true;
            do
            {
                Console.WriteLine($"Insira o seu email:");
                string email = Console.ReadLine()!;

                Console.WriteLine($"Insira a sua senha:");
                string senha = Console.ReadLine()!;

                if (email == usuario.Email && senha == usuario.Senha)
                {
                    validarLogin = false;
                    this.Logado = true;
                    Console.WriteLine($"Logado com sucesso!");

                }
                else
                {
                    validarLogin = true;
                    this.Logado = false;
                    Console.WriteLine($"Falha no login :( tente novamente!!");

                }


            } while (validarLogin == true);

            return "";
        }

        public string Deslogar()
        {
            Logado = false;
            return "Deslogado.";
        }

        public void GerarMenu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();

            string opcaoMenu;
            do
            {
                Console.WriteLine(@$"
            [1] - Cadastrar Produto
            [2] - Listar Produtos
            [3] - Remover Produto
            ----------------------
            [4] - Cadastrar Marca
            [5] - Listar Marcas
            [6] - Remover Marca

            [0] - Sair
            ");
                opcaoMenu = Console.ReadLine()!;

                switch (opcaoMenu)
                {
                    case "1":
                        produto.Cadastrar(produto);
                        break;
                    case "2":
                        produto.Listar();
                        break;
                    case "3":
                        Console.WriteLine($"Informe o código do produto a ser removido:");
                        int codigoProduto = int.Parse(Console.ReadLine()!);

                        produto.Deletar(codigoProduto);
                        Console.WriteLine($"Marca cujo codigo e de: {codigoProduto} removida.");
                        break;
                    case "4":
                        marca.Cadastrar(marca);
                        break;
                    case "5":
                        marca.Listar();
                        break;
                    case "6":
                        Console.WriteLine($"Informe o código da marca a ser removida:");
                        int codigoMarca = int.Parse(Console.ReadLine()!);

                        marca.Deletar(codigoMarca);
                        Console.WriteLine($"Marca cujo codigo e de: {codigoMarca} removida.");
                        
                        break;
                    case "0":
                        Console.WriteLine($"Programa encerrado.");
                        break;
                    default:
                        Console.WriteLine($"Opcao invalida!!");
                        break;
                }
            } while (opcaoMenu != "0");
        }

    }
}