//  Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.
string nome;
string senha;

Console.WriteLine($"Digite o seu nome de usuario:");
nome = Console.ReadLine();

Console.WriteLine($"Digite a sua senha (nao pode ser a mesma que seu nome):");
senha = Console.ReadLine();

while (senha == nome)
{
    Console.WriteLine($"Erro!! digite novamente");
    senha = Console.ReadLine();  
}





// Console.WriteLine($"Digite a sua senha (nao pode ser a mesma que seu nome):");
// float senha = float.Parse(Console.ReadLine());

