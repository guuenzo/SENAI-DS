// Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
// menor valor lido.

int[] numeros = new int[10];

for (var i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Digite um valor:");
    numeros[i] = int.Parse(Console.ReadLine()!);
}

Console.WriteLine(@$"menor : {numeros.Min()}
maior : {numeros.Max()}   ");

