// Vamos desenvolver um programa que cadastre e mostre os dados de um aluno.

// Crie uma classe Aluno com as seguintes propriedades:

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.

namespace Projeto_mensalidade_POO
{
    public class Aluno
    {
        public string Nome;
        public string Curso;
        public string Idade;
        public string Rg;
        public bool Bolsista;
        public int MediaFinal;
        public float ValorMensalidade;


        public void VerMediaFinal()
        {
            Console.WriteLine($"Media final do aluno {Nome}: {MediaFinal} ");

        }

        public float VerMensalidade()
        {
            //CONDICIONAL
            //IF ENCADEADO

            float valor;
            if (Bolsista == true && MediaFinal >= 8)
            {
                valor = ValorMensalidade * 0.5f;
            }

            else if (Bolsista == true && MediaFinal > 6)
            {
               valor = ValorMensalidade * 0.7f;
            }

            else
            {
                valor = ValorMensalidade;
            }
            return valor;
        }
    }
}