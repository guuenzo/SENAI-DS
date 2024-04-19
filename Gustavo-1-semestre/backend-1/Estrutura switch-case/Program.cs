Console.WriteLine($"Informe o numero corresponfente ao dia da semana: ");
int diaSemana = int.Parse(Console.ReadLine());

switch (diaSemana)
{
    case 1:
        Console.WriteLine($"Hoje e domingo");
        break;

    case 2:
        Console.WriteLine($"Hoje e segunda");
        break;

    case 3:
        Console.WriteLine($"Hoje e terca");
        break;

    case 4:
        Console.WriteLine($"Hoje e quarta");
        break;

    case 5:
        Console.WriteLine($"Hoje e quinta");
        break;

    case 6:
        Console.WriteLine($"Hoje e sexta");
        break;

    case 7:
        Console.WriteLine($"Hoje e sabado");
        break;

    default:
        Console.WriteLine($"O dia informado e invalido");
        break;
}















