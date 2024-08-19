// Exercício 2
// Crie um programa que permita que o usuário cadastre 5 nomes em um vetor. Após o
// cadastro, o programa deve imprimir na tela os nomes cadastrados em ordem alfabética.
// Utilize um laço for para o cadastro e um método de ordenação de sua preferência (por
// exemplo, bubble sort) para ordenar os nomes.

string[] nomes = new string[6];

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Digite o nome do {i}º usuário: ");
    nomes[i] = Console.ReadLine()!;
}
Console.WriteLine($"Nomes em ordem alfabética:");
foreach (string nome in nomes)
{
    Array.Sort(nomes);
    Console.WriteLine(nome);
}