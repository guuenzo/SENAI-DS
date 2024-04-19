using Atividade_MVC_eventos.Model;
using Atividade_MVC_eventos.View;

namespace Atividade_MVC_eventos.Controller
{
    public class EventoController
    {
        //instancia das classes
        Evento evento = new Evento();
        EventoView eventoView = new EventoView();

        public void ListarEventos()
        {
            List<Evento> eventos = evento.Ler();

            eventoView.Listar(eventos);
        }

        public void Cadastrar()
        {
            Evento novoEvento = eventoView.Cadastrar();

            evento.Inserir(novoEvento);
        }
    }
}