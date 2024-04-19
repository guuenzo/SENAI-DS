// Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
// lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
// pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
// entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.

string[] nome = new string [10];
for (var i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o nome da {i + 1}º pessoa");
    nome[i] = Console.ReadLine()!;
}

Console.WriteLine($"Digite o nome da pessoa que quer achar:");
string nomeProcurado = Console.ReadLine();

if (nome.Contains(nomeProcurado))
{
    Console.WriteLine($"ACHOOOOOO!!!!");
    
}
else
{
    Console.WriteLine($"Nao encontrado");
    
}


