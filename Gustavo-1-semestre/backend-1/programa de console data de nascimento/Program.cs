Console.WriteLine($"Informe o nome da pessoa: ");
string nome = Console.ReadLine();

Console.WriteLine($"Informe o ano de nascimento da pessoa: ");
float anoNascimento = float.Parse(Console.ReadLine());

float anoAtual = DateTime.Now.Year;

float idade = anoAtual - anoNascimento;
Console.WriteLine($"A idade da pessoa baseada no ano do nascimento e: {idade}");

float idadeSemana = idade * 52;
Console.WriteLine($"A idade da pessoa baseada no ano do nascimento em semanas e: {idadeSemana} ");

