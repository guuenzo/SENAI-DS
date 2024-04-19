// Nesta aula vamos fazer um pequeno sistema de calculadora, em um projeto de console no VsCode.

// Vamos desenvolver um programa orientado a objeto que faça as 4 operações matemáticas.

// Crie uma classe Calculadora;
// Criar um método para cada uma das operações matemáticas(retornar float);
// Fazer o menu de opções;
// Solicitar a entrada de 2 números para o cálculo e exiba o resultado do cálculo no console.

using Calculadora_POO;
Calculadora c1 = new Calculadora();

Console.WriteLine(@$"

Digite a opcao de operacao que deseja:
-------------------------
|                       |
|      A- Adicao        |
|     B- Subtracao      |
|                       |
|   C- Multiplicacao    |
|     D- Divisao        |
|                       |
|                       |
|                       |
-------------------------
");
string decisaoOperacao = Console.ReadLine()!.ToLower();

switch (decisaoOperacao)
{
    case "a":
        Console.WriteLine($"Operacao de adicao escolhida!!");

        Console.WriteLine($"Digite o primeiro numero para soma:");
        float primeiroSoma = float.Parse(Console.ReadLine()!);

        Console.WriteLine($"Digite o segundo numero para soma:");
        float segundoSoma = float.Parse(Console.ReadLine()!);

        float resultadoSoma = c1.somar(primeiroSoma, segundoSoma);
        Console.WriteLine($"O resultado da sua soma e de : {resultadoSoma}");
        break;

    case "b":
        Console.WriteLine($"Operacao de subtracao escolhida!!");

        Console.WriteLine($"Digite o primeiro numero para subtracao:");
        float primeiroSubtracao = float.Parse(Console.ReadLine()!);

        Console.WriteLine($"Digite o segundo numero para subtracao:");
        float segundoSubtracao = float.Parse(Console.ReadLine()!);

        float resultadoSubtracao = c1.subtrair(primeiroSubtracao, segundoSubtracao);
        Console.WriteLine($"O resultado da sua subtracao e de : {resultadoSubtracao}");
        break;

    case "c":
        Console.WriteLine($"Operacao de multiplicacao escolhida!!");

        Console.WriteLine($"Digite o primeiro numero para multiplicacao:");
        float primeiroMultiplicacao = float.Parse(Console.ReadLine()!);

        Console.WriteLine($"Digite o segundo numero para Multiplicacao:");
        float segundoMultiplicacao = float.Parse(Console.ReadLine()!);

        float resultadoMultiplicacao = c1.multiplicar(primeiroMultiplicacao, segundoMultiplicacao);
        Console.WriteLine($"O resultado da sua Multiplicacao e de : {resultadoMultiplicacao}");
        break;

    case "d":
        Console.WriteLine($"Operacao de divisao escolhida!!");

        Console.WriteLine($"Digite o primeiro numero para divisao:");
        float primeiroDivisao = float.Parse(Console.ReadLine()!);

        Console.WriteLine($"Digite o segundo numero para Divisao:");
        float segundoDivisao = float.Parse(Console.ReadLine()!);

        float resultadoDivisao = c1.dividir(primeiroDivisao, segundoDivisao);
        Console.WriteLine($"O resultado da sua Divisao e de : {resultadoDivisao}");
        break;
    default:
        Console.WriteLine($"Opcao invalida, tente novamente!!!");
        break;
}