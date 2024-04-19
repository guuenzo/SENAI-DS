// Faça um programa que verifique se uma letra digitada é vogal ou consoante

Console.WriteLine($"Digite uma letra:");
string letra = Console.ReadLine().ToUpper();

if (letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U")
{
    Console.WriteLine($"A letra digitada e vogal");
}

else
{
    Console.WriteLine($"A letra digitada e consoante");
}





