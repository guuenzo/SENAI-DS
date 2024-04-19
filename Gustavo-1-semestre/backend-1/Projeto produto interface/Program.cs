//instancia do objeto carrinho
using Projeto_produto_interface;

Carrinho carrinho = new Carrinho();

//instanciar objeto(s) da classe produto
Produto p1 = new Produto(1, "GTA V", 52.90f);
Produto p2 = new Produto(2, "Detroit Become Human", 120.50f);
Produto p3 = new Produto(3, "Forza", 100f);

carrinho.Adcionar(p1);
carrinho.Adcionar(p2);
carrinho.Adcionar(p3);

carrinho.Listar();

carrinho.TotalCarrinho();

carrinho.Remover(p2);

Console.WriteLine($"Apos a remocao de um item:");

carrinho.Listar();

carrinho.TotalCarrinho();

Console.WriteLine($"Agora vamos atualizar um objeto");

//criar um objeto com os dados atualizados 
Produto _novoProduto = new Produto();
_novoProduto.Nome = "Fifa 2023";
_novoProduto.Preco = 300f;

carrinho.Atualizar(1, _novoProduto);

carrinho.Listar();

carrinho.TotalCarrinho();