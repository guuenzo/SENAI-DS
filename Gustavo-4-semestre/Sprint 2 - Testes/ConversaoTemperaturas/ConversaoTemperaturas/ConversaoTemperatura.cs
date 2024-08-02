using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConversaoTemperaturas
{
    public class ConversaoTemperatura
    {
        //Crie um teste unitário para o método ConverterCelsiusParaFahrenheit que verifica se a conversão de Celsius para Fahrenheit é calculada corretamente.

        public static double ConverterCelsiusParaFahrenheit(double celsius)
        {
            var formula = (celsius  * 9 / 5) +32;

            return formula;
        }
    }
}
