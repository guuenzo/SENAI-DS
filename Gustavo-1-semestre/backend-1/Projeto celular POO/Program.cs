// Faça em sua máquina utilizando os mesmos conceitos dado em aula.
// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

using Projeto_celular_POO;
Celular c1 = new Celular();

bool celularLigado = true;
do
{
    Console.WriteLine($"Deseja ligar o celular (digite s para sim e n para nao)?");
    string respostaCelular = Console.ReadLine()!.ToLower();

    switch (respostaCelular)
    {
        case "s":
            celularLigado = true;
            c1.Ligado = true;
            c1.Ligar();
            break;
        case "n":
            celularLigado = false;
            c1.Ligado = false;
            Console.WriteLine($"O celular continua desligado");
            break;
        default:
            Console.WriteLine($"Opcao invalida");
            celularLigado = false;
            break;
    }

} while (celularLigado == false);

checkMenuLular:

Console.WriteLine(@$"
    Digite a opcao que deseja.

       1- Desligar
    2- Fazer ligacao
    3- Mandar mensagem
    ");

string decisaoMenu = Console.ReadLine()!;


switch (decisaoMenu)
{
    case "1":
        c1.Desligar();
        break;
    case "2":
        c1.FazerLigacao();
        goto checkMenuLular;
    case "3":
        c1.EnviarMensagem();
        goto checkMenuLular;
    default:
        Console.WriteLine($"Opcao invalida, tente novamente.");
        goto checkMenuLular;
}






