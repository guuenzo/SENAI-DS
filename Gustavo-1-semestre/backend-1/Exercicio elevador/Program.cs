// 1. Crie uma classe denominada Elevador para armazenar as informações de um elevador
// dentro de um prédio. A classe deve armazenar o andar atual (térreo = 0), total de andares
// no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão
// presentes nele. A classe deve também disponibilizar os seguintes métodos:
// Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de
// andares no prédio (os elevadores sempre começam no térreo e vazio);
// Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver
// espaço);
// Sair : para remover uma pessoa do elevador (só deve remover se houver alguém
// dentro dele);
// Subir : para subir um andar (não deve subir se já estiver no último andar);
// Descer : para descer um andar (não deve descer se já estiver no térreo);
// Encapsular todos os atributos da classe (criar os métodos set e get).

using Exercicio_elevador;
Elevador e1 = new Elevador();

Console.WriteLine($"Quantas pessoas o elevador suporta?");
e1.capacidadeElevador = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Qual o total de andares do predio?");
e1.totalAndares = int.Parse(Console.ReadLine()!);

e1.Inicializar(e1.capacidadeElevador, e1.totalAndares);

string opcao;
do
{
    Console.WriteLine(@$"
Digite uma das opcoes abaixo:

1- Entrar
2- Sair
3- Subir
4- Descer
5- Encerrar
");
    opcao = Console.ReadLine()!;

    switch (opcao)
    {
        case "1":
            e1.Entrar();
            break;
        case "2":
            e1.Sair();
            break;
        case "3":
            e1.Subir();
            break;
        case "4":
            e1.Descer();
            break;
        case "5":
            break;
        default:
            Console.WriteLine($"Opcao invalida, tente novamente");
            break;
    }
} while (opcao != "5");


