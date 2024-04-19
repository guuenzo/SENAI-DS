// Faça um programa que receba um número inteiro e mostre a sua tabuada

int resultado, multiplicador;
Console.WriteLine($"Digite seu numero para surgir sua tabuada");
int numero = int.Parse(Console.ReadLine());


for (multiplicador = 1; multiplicador <= 10; multiplicador++)
{
    resultado = numero * multiplicador;
    Console.WriteLine($"{numero} x {multiplicador} = {resultado}");
}


