// Faça um programa que leia três números e mostre o maior e o menor deles.

Console.WriteLine($"Digite um numero:");
float numero1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite um numero:");
float numero2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite um numero:");
float numero3 = float.Parse(Console.ReadLine());


if (numero1 > numero2 && numero1 > numero3)
{
    Console.WriteLine($"O numero maior e: {numero1}");
}
else if (numero2 > numero1 && numero2 > numero3)
{
    Console.WriteLine($"O numero maior e: {numero2}");
}
else
{
    Console.WriteLine($"O numero maior e: {numero3}");
}

if (numero1 < numero2 && numero1 < numero3)
{

    Console.WriteLine($"O numero menor e: {numero1}");
}

else if (numero2 < numero1 && numero2 < numero3)
{
    Console.WriteLine($"O numero menor e: {numero2}");
}
else
{
    Console.WriteLine($"O numero menor e: {numero3}");
}














//numero1
//numero2
//numero3

// if (numero1 > numero2 && numero1 > numero3)
// {
//     Console.WriteLine($"");    
// }
// else if(numero2 > numero1 && numero2 > numero3 )
// {
//     Console.WriteLine($"");
// }
// else
// {
//     Console.WriteLine($"");

// }
