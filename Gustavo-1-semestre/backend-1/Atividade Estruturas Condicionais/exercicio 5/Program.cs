// As    maçãs custam R$ 0,30 cada se forem compradas    menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor    total    da compra.

Console.WriteLine($"Insira a quantidade de macas que pegou:");
float macas = float.Parse(Console.ReadLine());

if (macas >= 12) 
{
    float quantidadeMeiaDuzia = (macas * 0.30f);
    Console.WriteLine($"Todas as macas custam: {quantidadeMeiaDuzia}");
}

else
{
    float quantidadeDuzia = (macas * 0.25f);
    Console.WriteLine($"Todas as macas custam: {quantidadeDuzia}");
    
}
