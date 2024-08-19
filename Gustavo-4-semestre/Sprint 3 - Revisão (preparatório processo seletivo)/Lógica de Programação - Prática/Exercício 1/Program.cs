//Exercício 1
// Escreva um programa que peça ao usuário para digitar um número inteiro e informe se o
// número é par ou ímpar. Utilize uma estrutura condicional if/else para realizar o teste.

double numero;

Console.WriteLine($"Digite um número e descubra se é ímpar ou par: ");
numero = double.Parse(Console.ReadLine()!);

Console.WriteLine(numero % 2 == 0 ? "O número informado é par" : "O número informado é ímpar");