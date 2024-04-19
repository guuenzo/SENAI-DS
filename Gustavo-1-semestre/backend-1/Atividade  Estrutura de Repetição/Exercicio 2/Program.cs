//  Idade: entre 0 e 100 anos
int idade;
do
{
    Console.WriteLine($"Digite uma idade de 0 a 100:");
    idade = int.Parse(Console.ReadLine());

    
} while (idade >0 && idade >=100 );
