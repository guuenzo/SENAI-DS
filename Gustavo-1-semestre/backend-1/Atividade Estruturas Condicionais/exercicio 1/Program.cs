// Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.

Console.WriteLine($"qual o valor do salario?");
float salario = float.Parse(Console.ReadLine());

Console.WriteLine($"qual o valor em gastos?");
float gastos = float.Parse(Console.ReadLine());

if (salario > gastos)
{
    Console.WriteLine($"Gastos dentro do orçamento");
}
else
{
    Console.WriteLine($"Orçamento estourado");
}






