// Nome: diferente de vazio

bool nomeCerto = true;

do
{
    Console.WriteLine($"Digite o seu nome:");
    string nome = Console.ReadLine();

    if (nome != "")
    {
        nomeCerto = true;
        Console.WriteLine($"concluido!!");
        
    }

    else
    {
        nomeCerto = false;
        Console.WriteLine($"tente novamente!");
        
    }

} while (nomeCerto = false);






