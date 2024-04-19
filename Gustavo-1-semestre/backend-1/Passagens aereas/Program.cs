// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de passagens aéreas pelo console:

// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N). 

class Program
{

    // ARRAYS E VARIAVEIS GLOBAIS
    static string[] nome = new string[5];
    static string[] origem = new string[5];
    static string[] destino = new string[5];
    static float[] data = new float[5];
    static int passagens = 0;

    // FUNCOES
    // LOGIN
    static bool Login(string senhaInformada)
    {
        string senhaDefinida = "123456";
        bool senhaCerta;

        if (senhaInformada == senhaDefinida)
        {
            senhaCerta = true;
        }
        else
        {
            senhaCerta = false;
            Console.WriteLine($"Senha invalida, digite novamente.");

        }
        return senhaCerta;
    }


    // CADASTRO
    static void Cadastro()
    {
        bool novoCadastro = false;
        do
        {
                Console.WriteLine($"Digite o nome do {passagens + 1}º passageiro:");
                nome[passagens] = Console.ReadLine()!;

                Console.WriteLine($"Digite a origem do {passagens + 1}º passageiro:");
                origem[passagens] = Console.ReadLine()!;

                Console.WriteLine($"Aonde o {passagens + 1}º passageiro deseja ir?? :");
                destino[passagens] = Console.ReadLine()!;

                Console.WriteLine($"Quando o {passagens + 1}º passageiro quer ir?? (digite a data desejada assim, exemplo: 17.04.2023):");
                data[passagens] = float.Parse(Console.ReadLine()!);

                passagens++;

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
                    Console.WriteLine($"Opcao esolhida e invalida.");
                    break;
            }

        } while (novoCadastro == true && passagens < 5);
    }

    // LISTAR PASSAGENS
    static void ListarPassagens()
    {
        for (var i = 0; i < 5; i++)
        {
            Console.WriteLine(@$"    
    nome: {nome[i]}
    origem: {origem[i]}
    destino: {destino[i]}
    data: {data[i]}    
    ");

        }
    }


    public static void Main(string[] args)
    {
        // LOGIN
        string senha;
        do
        {
            Console.WriteLine($"Digite a senha:");
            senha = Console.ReadLine()!;
        } while (Login(senha) == false);


        // MENU
        int opcao = 1;
        while (opcao != 0 && opcao != 2)
        {
            Console.WriteLine(@$"
 ----------------------
|     Menu de opcoes    |
|                       | 
| 1- Cadastrar passagem |
| 2- Listar Passagens   |
| 0- Sair               |
|                       |
 ----------------------");

        int decisao = int.Parse(Console.ReadLine()!);
        if (decisao == 1)
        {
            Cadastro();
        }
        else if (decisao == 2)
        {
            ListarPassagens();
        }
        else if (decisao == 0)
        {
            Console.WriteLine($"VOLTE SEMPRE!!!!");
        }
        }
        
    }
}