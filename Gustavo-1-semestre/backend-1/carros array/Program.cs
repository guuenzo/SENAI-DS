string[]carros = new string[3];

for (int i = 0; i < 3; i++)
{
//  bloco de codigo
Console.WriteLine($"Digite o {i + 1} do carro:");
carros[i] = Console.ReadLine();
}

 for (int i = 0; i < 300; i++)    //alt=167 = º
{
    Console.WriteLine($"O {i + 1}º carro e: {carros[i]}");
}
