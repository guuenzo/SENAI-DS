// Nesta aula vamos fazer um pequeno sistema de cadastro de alunos, em um projeto de console no VsCode.

// Vamos desenvolver um programa que cadastre e mostre os dados de um aluno.

// Crie uma classe Aluno com as seguintes propriedades:

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.

using Projeto_mensalidade_POO;
Aluno a1 = new Aluno();

Console.WriteLine($"Digite o seu nome aluno(a):");
a1.Nome = Console.ReadLine()!;

Console.WriteLine($"Qual o curso do aluno(a)?");
a1.Curso = Console.ReadLine()!;

Console.WriteLine($"Qual a idade do aluno(a)?");
a1.Idade = Console.ReadLine()!;

Console.WriteLine($"RG do aluno(a):");
a1.Rg = Console.ReadLine()!;

bool validarBolsista = true;
do
{
    Console.WriteLine($"O aluno e bolsista? (digite 's' para afirmar e 'n' para negar)");
    string respostaBolsista = Console.ReadLine()!.ToLower();

    switch (respostaBolsista)
    {
        case "s":
            validarBolsista = false;
            a1.Bolsista = true;
            break;
        case "n":
            validarBolsista = false;
            a1.Bolsista = false;
            break;
        default:
            validarBolsista = true;
            Console.WriteLine($"Opcao invalida, tente novamente!!");
            break;
    }
} while (validarBolsista == true);

Console.WriteLine($"Qual foi a media final do aluno(a)?");
a1.MediaFinal = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Qual o valor da mensalidade do aluno(a)?");
a1.ValorMensalidade = float.Parse(Console.ReadLine()!);

string validarMenu;
do
{
    Console.WriteLine(@$"
    Escolha uma das opcoes
------------------------------
|                            |
|   1- Vizualizar a media    |
|                            |
|                            | 
| 2- Vizualizar o valor da   |
|        mensalidade         |
|                            |
|                            |
|         0- Sair            |
------------------------------
");

validarMenu = Console.ReadLine()!;

switch (validarMenu)
{
    case "1":
        a1.VerMediaFinal();
        break;

    case "2":
        Console.WriteLine($"O valor da mensalidade e de: {a1.VerMensalidade()}");
        break;

    case "0":
        Console.WriteLine($"Programa finalizado");
        break;

    default:
        Console.WriteLine($"Opcao invalida, tente novamente");
        break;
}
} while (validarMenu != "0");





