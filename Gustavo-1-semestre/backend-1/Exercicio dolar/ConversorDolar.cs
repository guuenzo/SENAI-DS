namespace Exercicio_dolar
{
    public class ConversorDolar
    {
        public static float dinheiro  { get; set; }
        
        public static float RealParaDolar (float real)
        {
            dinheiro = real;

            float dolar = dinheiro * 4.99f;

            return dolar;
        }

        public static float DolarParaReal (float dolar)
        {
            dinheiro = dolar;

            float real = dinheiro * 4.99f;

            return real;
        }
        
    }
}