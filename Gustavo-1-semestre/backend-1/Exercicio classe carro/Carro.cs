//Criar um projeto de console
//Criar uma classe carro
// -marca, -cor
//Criar construtor vazio e completo
//Receber dados no console para adcionar dois objetos em uma lista
//Exibir os dois objetos da lista no console 

namespace Exercicio_classe_carro
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Cor { get; set; }

        public Carro()
        {
        }

        public Carro(string marca, string cor)
        {
            Marca = marca;
            Cor = cor;
        }
    }
}