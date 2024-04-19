// Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade &lt;= 5 o desconto será de 2%
// - Se quantidade &gt; 5 e quantidade &lt;=10 o desconto será de 3%
// - Se quantidade &gt; 10 o desconto será de 5%
// Dica: utilize if / else if / else

Console.WriteLine($"Digite o nome do produto:");
string produto = Console.ReadLine()!;

Console.WriteLine($"Quantos {produto} voce quer?");
int quantidadeProduto = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Qual preco deseja colocar no {produto}?");
float precoProduto = float.Parse(Console.ReadLine()!);

float totalProduto = quantidadeProduto * precoProduto;
float totalPagar;

if (quantidadeProduto <= 5)
{
    totalPagar = totalProduto * 0.98f;
    Console.WriteLine($"O total a ser pago com desconto incluso e: {totalPagar}");
}
else if (quantidadeProduto > 5 && quantidadeProduto <= 10)
{
    totalPagar = totalProduto * 0.97f;
    Console.WriteLine($"O total a ser pago com desconto incluso e: {totalPagar}");
}
else 
{
     totalPagar = totalProduto * 0.95f;
    Console.WriteLine($"O total a ser pago com desconto incluso e: {totalPagar}");
}







