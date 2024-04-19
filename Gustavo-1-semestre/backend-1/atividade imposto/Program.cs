//faça um método para calcular imposto sobre a renda

//regras de negócio
//tabela de imposto vs renda
//até $1500 - isento
//de $1501 até $3500 - 20% de imposto
//de $3501 até $6000 - 25% de imposto
//acima de $6000 - 35% de imposto


//receber o renda via console
//chamar o método passando a renda como parâmetro
//exibir o valor do imposto referente á renda

using System.Globalization;

static float Imposto(float renda)
{
    if (renda <= 1500)
    {
        return 0;
    }

    if (renda >= 1501 && renda <= 3500)
    {
        return renda * 0.20f;
    }
    
    if (renda >= 3501 && renda <= 6000)
    {
        return renda * 0.25f;
    }

    if (renda > 6000)
    {
        return renda * 0.35f;
    }
    return 0;
}

Console.WriteLine($"Digite a sua renda:");
float renda = float.Parse(Console.ReadLine());

float resultado = Imposto(renda);
Console.WriteLine($"O imposto sobre a sua renda sera de: {resultado.ToString("C", new CultureInfo("pt-BR"))}");