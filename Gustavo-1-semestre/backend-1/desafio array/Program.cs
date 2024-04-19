//DESAFIOS
//Faça um programa que carregue um array de tamanho 6 com números inteiros. Calcule e imprima a quantidade de números ímpares e a quantidade de números pares.

int[] numero = new int[6];

for (int i = 0; i < 6; i++)
{

    Console.WriteLine($"Digite o número desejado: ");
    numero[i] = int.Parse(Console.ReadLine()!);
}

int numeroPar = 0;
int numeroImpar= 0;

for (int i = 0; i < 6; i++)
{
    if (numero[i] % 2 == 0)
    {
        numeroPar++;
    }
    else
    {
        numeroImpar++;
    }
}

Console.WriteLine($"{numeroPar} números são pares, e {numeroImpar} números são impares");