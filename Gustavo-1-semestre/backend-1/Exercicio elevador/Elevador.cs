// 1. Crie uma classe denominada Elevador para armazenar as informações de um elevador
// dentro de um prédio. A classe deve armazenar o andar atual (térreo = 0), total de andares
// no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão
// presentes nele. A classe deve também disponibilizar os seguintes métodos:
// Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de
// andares no prédio (os elevadores sempre começam no térreo e vazio);
// Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver
// espaço);
// Sair : para remover uma pessoa do elevador (só deve remover se houver alguém
// dentro dele);
// Subir : para subir um andar (não deve subir se já estiver no último andar);
// Descer : para descer um andar (não deve descer se já estiver no térreo);
// Encapsular todos os atributos da classe (criar os métodos set e get).

namespace Exercicio_elevador
{
    public class Elevador
    {
        public int andarAtual { get; set; }
        public int totalAndares { get; set; }
        public int capacidadeElevador { get; set; }
        public int pessoasElevador { get; set; }

        public void Inicializar(int capacidadeElevador, int totalAndares)
        {
            capacidadeElevador = this.capacidadeElevador;
            totalAndares = this.totalAndares;
            Console.WriteLine($"O predio tem {totalAndares} andares (exceto o terreo) e capacidade para {capacidadeElevador} pessoas no elevador");
        }

        public void Entrar()
        {
            // Console.WriteLine($"Quantas pessoas estao no elevador?");
            // this.pessoasElevador = int.Parse(Console.ReadLine()!);


            if (this.pessoasElevador >= this.capacidadeElevador)
            {
                Console.WriteLine($"Nao ha espaco para mais pessoas no elevador");

            }
            else
            {
                pessoasElevador++;
                Console.WriteLine($"Pode entrar no elevador, agora o elevador possui {pessoasElevador} pessoas");
            }
        }

        public void Sair()
        {
            // Console.WriteLine($"Quantas pessoas estao no elevador?");
            // this.pessoasElevador = int.Parse(Console.ReadLine()!);

            if (this.pessoasElevador == 0)
            {
                Console.WriteLine($"Nao ha nenhuma pessoa no elevador para poder sair");

            }
            else
            {
                pessoasElevador--;
                Console.WriteLine($"Saiu do elevador, agora o elevador possui {pessoasElevador} pessoas");

            }

        }
        public void Subir()
        {
            // Console.WriteLine($"Em qual andar esta o elevador?");
            // this.andarAtual = int.Parse(Console.ReadLine()!);

            if (andarAtual >= totalAndares)
            {
                Console.WriteLine($"Nao e possivel subir, o elevador esta no ultimo andar");

            }
            else
            {
                andarAtual++;
                Console.WriteLine($"O elevador subiu e esta no {andarAtual}º  andar");

            }

        }
        public void Descer()
        {
            // Console.WriteLine($"Em qual andar esta o elevador?");
            // this.andarAtual = int.Parse(Console.ReadLine()!);

            if (andarAtual == 0)
            {
                Console.WriteLine($"Nao e possivel descer, o elevador esta no terreo");
                
            } 
            else
            {
                andarAtual --;
                Console.WriteLine($"O elevador desceu e esta no {andarAtual}º andar");
                
            }
        }
    }
}