// Salário: maior que zero

float salario;
do
{
    Console.WriteLine($"Digite o seu salario (maior que 0):");
    salario = float.Parse(Console.ReadLine());

    
} while (salario <= 0);
