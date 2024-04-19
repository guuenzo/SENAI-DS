// Exercício : Faça um programa de conversão de moedas(câmbio) usando classe, membro e métodos estáticos.
// Menu de opções : dólar para real, real para dólar, sair
// Personalizar a resposta, usando recursos da linguagem(Bibliotecas)

using System.Globalization;
using Exercicio_dolar;

string decisao;
do
{
    Console.WriteLine(@$"
Digite a opcao que deseja:

1- Conversao de real para dolar 
2- Conversao de dolar para real
3- Sair 
");
    decisao = Console.ReadLine()!;

    switch (decisao)
    {
        case "1":
            Console.WriteLine($"Digite a quantidade de dinheiro em reais para converter em dolar:");
            float dolar = float.Parse(Console.ReadLine()!);
            float resultadoReal = ConversorDolar.RealParaDolar(dolar);
            Console.WriteLine($"A quantia de dinheiro em reais convertida em dolar e de: {resultadoReal}");
            break;
        case "2":
            Console.WriteLine($"Digite a quantidade de dinheiro em dolares para converter em reais:");
            float reais = float.Parse(Console.ReadLine()!);
            float resultadoDolar = ConversorDolar.DolarParaReal(reais);
            Console.WriteLine($"A quantia de dinheiro em dolares convertida em reais e de: {resultadoDolar.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
            break;
        default:
            Console.WriteLine($"Opcao invalida, tente novamente!!");
            break;
    }
} while (decisao != "3");




// float resultadoDolar = ConversorDolar.RealParaDolar(float.Parse(Console.ReadLine()));
// float resultadoReal = ConversorDolar.DolarParaReal(float.Parse(Console.ReadLine()));