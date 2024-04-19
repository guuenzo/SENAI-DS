// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.

class Program
{
    static string[] nome = new string[10];

    static float[] preco = new float[10];

    static string[] promocao = new string[10];

    static int quantidadeProduto = 0;

    // funcoes
    static void CadastrarProduto()
    {
        bool novoCadastro = false;
        do
        {
            Console.WriteLine($"Informe o produto a ser cadastrado:");
            nome[quantidadeProduto] = Console.ReadLine()!;

            Console.WriteLine($"Qual preco deseja colocar no produto cadastrado? :");
            preco[quantidadeProduto] = float.Parse(Console.ReadLine()!);

            Console.WriteLine($"O produto cadastrado esta em promocao? s/n");
            char respostaPromocao = char.Parse(Console.ReadLine()!.ToLower());

            bool respostaValida = false;
            do
            {
                switch (respostaPromocao)
                {
                    case 's':
                        promocao[quantidadeProduto] = "sim";
                        respostaValida = true;
                        break;
                    case 'n':
                        promocao[quantidadeProduto] = "nao";
                        respostaValida = true;
                        break;
                    default:
                        Console.WriteLine($"Opcao invalida.");
                        respostaValida = false;
                        break;
                }
            } while (respostaValida == false);

            quantidadeProduto++;

            Console.WriteLine($"Deseja efetuar um novo cadastro? (digite s para sim e n para nao):");
            char decisaoCadastro = char.Parse(Console.ReadLine()!.ToLower());


            switch (decisaoCadastro)
            {
                case 's':
                    novoCadastro = true;
                    break;
                case 'n':
                    novoCadastro = false;
                    break;
                default:
                    Console.WriteLine($"Opcao escolhida e invalida.");
                    break;
            }
        } while (novoCadastro == true && quantidadeProduto < 10);

    }

    static void ListarProdutos()
    {
        for (var i = 0; i < 10; i++)
        {
            Console.WriteLine(@$"
Produto: {nome[i]}
Preco : {preco[i]}
Promocao : {promocao[i]}
");
        }
    }

    static void MostrarMenu()
    {
        int opcao = 1;
        while (opcao != 0 && opcao != 2)
        {
            Console.WriteLine(@$"
-------------------------
|  Digte o que deseja:  |
|                       |
| 1- Cadastrar produtos |
|                       |
| 2- Listar produtos    |
|                       |
| 0- Sair               |
|                       |
-------------------------
");

            int decisaoMenu = int.Parse(Console.ReadLine()!);
            bool opcaoValida = true;
            do
            {
                switch (decisaoMenu)
                {
                    case 1:
                        CadastrarProduto();
                        break;

                    case 2:
                        ListarProdutos();
                        break;

                    case 0:
                        break;
                    default:
                        Console.WriteLine($"Opcao invalida, tente novamente.");
                        break;
                }
            } while (opcaoValida == false);

        }


    }

    public static void Main(string[] args)
    {
        MostrarMenu();
    }
}
