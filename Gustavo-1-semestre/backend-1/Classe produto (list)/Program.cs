//Crie uma classe produto
//Com as propriedades: int Codigo, string Nome, float preco
//Crie um construtor vazio
//Crie um construtor completo

using Classe_produto__list_;

List<Produto> produtos = new List<Produto>();

Console.WriteLine($"Lista sem alteracao");

produtos.Add(
    new Produto(2563, "camiseta QuickSilver", 19.90f)
);

produtos.Add
(
    new Produto(1025, "tenis Naiki", 50f)
);

Produto calcaDiesel = new Produto(1526, "calca Diesel Calvo klein", 15f);
produtos.Add(calcaDiesel);

foreach (var item in produtos)
{
    Console.WriteLine($"Codigo:{item.Codigo}, Nome:{item.Nome}, Preco:{item.Preco:C} {produtos.IndexOf(item)+1}");

}

Console.WriteLine($"Lista atualizada com preco alterado");

Produto produtoBuscado = produtos.Find(x => x.Codigo == 2563);

int Index = produtos.IndexOf(produtoBuscado);

produtoBuscado.Preco = 199.90f;

produtos.RemoveAt(Index);

produtos.Insert(Index, produtoBuscado);

foreach (var item in produtos)
{
    Console.WriteLine($"Codigo:{item.Codigo}, Nome:{item.Nome}, Preco:{item.Preco:C} {produtos.IndexOf(item)+1}");

}