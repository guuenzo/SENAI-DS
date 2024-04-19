// Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.

using System.Globalization;

const float alcool = 4.9f;
const float gasolina = 5.3f;

Console.WriteLine($"Voce deseja alcool ou gasolina (digite 'a' para alcool ou 'g' para gasolina):");
char tipoCombustivel = char.Parse(Console.ReadLine()!.ToLower());

while (tipoCombustivel != 'a' && tipoCombustivel != 'g')
{
    Console.WriteLine($"Voce deseja alcool ou gasolina (digite 'a' para alcool ou 'g' para gasolina):");
    tipoCombustivel = char.Parse(Console.ReadLine());
}


Console.WriteLine($"Quantos litros deseja? :");
float litro = float.Parse(Console.ReadLine());

while (litro <= 0)
{
    Console.WriteLine($"Quantos litros deseja? :");
    litro = float.Parse(Console.ReadLine());
}

switch (tipoCombustivel)
{
    case 'a':
        float total, desconto, valor;
        if (litro <= 20)
        {
            valor = litro * alcool;
            desconto = valor * 0.03f;
            total = valor - desconto;
            Console.WriteLine($"O preco do alcool inserido com desconto e de : {total.ToString("C", new CultureInfo("pt-BR"))} ");
        }
        else
        {
            valor = litro * alcool;
            desconto = valor * 0.05f;
            total = valor - desconto;
            Console.WriteLine($"O preco do alcool inserido com desconto e de : {total.ToString("C", new CultureInfo("pt-BR"))} ");
        }
        break;

        case 'g':
        if (litro <= 20)
        {
            valor = litro * gasolina;
            desconto = valor * 0.04f;
            total = valor - desconto;
            Console.WriteLine($"O preco da gasolina inserida com desconto e de : {total.ToString("C", new CultureInfo("pt-BR"))} ");
        }
        else
        {
            valor = litro * gasolina;
            desconto = valor * 0.06f;
            total = valor - desconto;
            Console.WriteLine($"O preco do gasolina inserida com desconto e de : {total.ToString("C", new CultureInfo("pt-BR"))} ");
        }
        break;


    default:
        break;
}


