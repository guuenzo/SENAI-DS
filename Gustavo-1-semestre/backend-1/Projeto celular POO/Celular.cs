// Faça em sua máquina utilizando os mesmos conceitos dado em aula.
// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

namespace Projeto_celular_POO
{
    public class Celular
    {
        public string Cor;
        public string Modelo;
        public string Tamanho;
        public bool Ligado;

        //metodos
         public void Ligar()
     {
        Console.WriteLine($"O celular esta ligado!!!");
        
     }  

     public void Desligar()
     {
        Console.WriteLine($"O celular desligou!!!");
        
     }

     public void FazerLigacao()
     {
        Console.WriteLine($"Disque o numero para realizar a ligacao:");
        string numeroDiscado = Console.ReadLine()!;

        Console.WriteLine($"O celular esta fazendo uma ligacao para {numeroDiscado}!!!");
     }

     public void EnviarMensagem()
     {
        Console.WriteLine($"Digite a mensagem que quer enviar:");
        string mensagemDigitada = Console.ReadLine()!;

        Console.WriteLine($"A mensagem {mensagemDigitada} esta sendo enviada.");
     }
    }
}