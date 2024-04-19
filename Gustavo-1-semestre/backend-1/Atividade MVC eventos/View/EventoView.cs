using Atividade_MVC_eventos.Model;

namespace Atividade_MVC_eventos.View
{
    public class EventoView
    {
        public void Listar(List<Evento> eventos)
        {
            foreach (var item in eventos)
            {
                Console.WriteLine($"\nNome: {item.Nome}");
                Console.WriteLine($"Descricao: {item.Descricao}");
                Console.WriteLine($"Data: {item.Data}");
            }
        }

        public Evento Cadastrar()
        {
            Evento novoEvento = new Evento();

            Console.WriteLine($"Informe o nome do evento:");
            novoEvento.Nome = Console.ReadLine();

            Console.WriteLine($"Informe a descricao do evento:");
            novoEvento.Descricao = Console.ReadLine();

            Console.WriteLine($"Informe a data do evento");
            novoEvento.Data = Console.ReadLine();

            return novoEvento;
        }
    }
}