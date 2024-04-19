// Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.

Console.WriteLine($"quantos gols o time x fez?");
float timeX = float.Parse(Console.ReadLine());

Console.WriteLine($"quantos gols o time y fez?");
float timeY = float.Parse(Console.ReadLine());

if (timeX > timeY)
{
    Console.WriteLine($"Vitoria do time X");
}

else if (timeY > timeX)
{
    Console.WriteLine($"Vitoria do time y");
}

else
{
    Console.WriteLine($"empate");
}








