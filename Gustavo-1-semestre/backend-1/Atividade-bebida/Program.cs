//Coca cola
//Pepsi
//Fanta
//Monster

//crie um menu de opções e peça para o usuário escolher uma das opções
//a depender da opção, exiba uma mensagem se gostaria de acrescentar gelo
//se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo
//caso contrário, a bebida é sem gelo adicional

Console.WriteLine(@$"
---------------------------
| Bebidas burguer king    |   
|                         | 
|   Informe a bebida      |
|                         |
|    (1) coca cola        |
|    (2) pepsi            |
|    (3) fanta            |
|    (4) monster          |
---------------------------
");

Console.WriteLine($"Informe o numero da bebida no menu:");
float bebida = float.Parse(Console.ReadLine());

switch (bebida)
{
    case 1:
        Console.WriteLine($"A bebida escolhida foi coca cola, deseja acrescentar gelo?");
        string geloCoca = Console.ReadLine().ToUpper();

        if (geloCoca == "SIM")
        {
            Console.WriteLine($"Bebida (coca cola) escolhida com gelo");
        }
        else
        {
            Console.WriteLine($"Bebida escolhida sem gelo");
        }
        break;
    case 2:
        Console.WriteLine($"A bebida escolhida foi pepsi, deseja acrescentar gelo?");
        string geloPepsi = Console.ReadLine().ToUpper();

        if (geloPepsi == "SIM")
        {
            Console.WriteLine($"Bebida (pepsi) escolhida com gelo");
        }
        else
        {
            Console.WriteLine($"Bebida escolhida sem gelo");
        }
        break;
    case 3:
        Console.WriteLine($"A bebida escolhida foi fanta, deseja acrescentar gelo?");
        string geloFanta = Console.ReadLine().ToUpper();

        if (geloFanta == "SIM")
        {
            Console.WriteLine($"Bebida (fanta) escolhida com gelo");
        }
        else
        {
            Console.WriteLine($"Bebida escolhida sem gelo");
        }
        break;
    case 4:
        Console.WriteLine($"A bebida escolhida foi monster, deseja acrescentar gelo?");
        string geloMonster = Console.ReadLine().ToUpper();

        if (geloMonster == "SIM")
        {
            Console.WriteLine($"Bebida (fanta) escolhida com gelo");
        }
        else
        {
            Console.WriteLine($"Bebida escolhida sem gelo");
        }
        break;
    default:
    Console.WriteLine($"Nenhuma das opcoes escolhidas sao valida(s)");
    
        break;
}





