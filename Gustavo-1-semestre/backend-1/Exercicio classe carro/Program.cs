//Criar um projeto de console
//Criar uma classe carro
// -marca, -cor
//Criar construtor vazio e completo
//Receber dados no console para adcionar dois objetos em uma lista
//Exibir os dois objetos da lista no console 

using Exercicio_classe_carro;
List<Carro> carros = new List<Carro>();

for (var i = 0; i < 2; i++)
{
    Carro carro = new Carro();

    Console.WriteLine($"Informe a marca do {i + 1}º carro:");
    carro.Marca = Console.ReadLine()!;

    Console.WriteLine($"Informe a cor do {i + 1}º carro:");
    carro.Cor = Console.ReadLine()!;
    
    carros.Add(carro);
}

foreach (var item in carros)
{
    Console.WriteLine($"{carros.IndexOf(item)+ 1}º Carro - Marca: {item.Marca}, Cor: {item.Cor}");
    
}