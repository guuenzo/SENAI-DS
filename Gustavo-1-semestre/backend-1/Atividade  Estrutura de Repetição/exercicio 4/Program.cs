// Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viúvo(a)), 'd'(divorciado(a))
char civil;

do 
{
    Console.WriteLine($"Qual o seu estado civil?");
    civil = char.Parse(Console.ReadLine());     

} while ((civil != 's' && civil != 'c' && civil != 'v' && civil != 'd') );
