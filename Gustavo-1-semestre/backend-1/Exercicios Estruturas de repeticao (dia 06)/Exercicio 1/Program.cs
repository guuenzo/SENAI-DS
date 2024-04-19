// Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.

int nota;

do 
{
    Console.WriteLine($"Informe uma nota de 0 a 10?");
    nota = int.Parse(Console.ReadLine());

} while ((nota < 0 || nota > 10));




