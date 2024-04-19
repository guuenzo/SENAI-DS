// // Criar um programa em c# que receba 5 números inteiros e ao final exiba o seu dobro

// // Você deve utilizar a estrutura array com tamanho 5 para o armazenamento dos números, a estrutura for para a leitura dos números e a estrutura foreach para exibí-los

int[] numero = new int [5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite um numero:");
    numero[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"O numero escolhido foi:{numero[i]} e o dobro e:{numero[i] * 2}");
    
}
