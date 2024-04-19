// 1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
// ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

Console.WriteLine($"Digite o ano em que nasceu para saber se pode votar:");
int anoNascimento = int.Parse(Console.ReadLine());

int idade = (DateTime.Now.Year - anoNascimento);
{
    if (idade >= 16)
    {
        Console.WriteLine($"Voce podera votar esse ano!!");
    }

    else
    {
        Console.WriteLine($"Voce nao podera votar esse ano.");
        
    }
}





