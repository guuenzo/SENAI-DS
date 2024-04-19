using webapi.event_.tarde.Contexts;
using webapi.event_.tarde.Domains;
using webapi.event_.tarde.Interfaces;

namespace webapi.event_.tarde.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        private readonly EventContext _eventContext;

        public EventoRepository()
        {
            _eventContext = new EventContext();
        }

        public void Atualizar(Guid id, Evento evento)
        {
            Evento novoEvento = _eventContext.Evento.Find(id);

            if (novoEvento != null)
            {
                novoEvento.DataEvento = novoEvento.DataEvento;
                novoEvento.NomeEvento = novoEvento.NomeEvento;
                novoEvento.Descricao = novoEvento.Descricao;
                novoEvento.IdTipoEvento = novoEvento.IdTipoEvento;
                novoEvento.IdInstituicao = novoEvento.IdInstituicao;

                _eventContext.SaveChanges();
            }
        }

        public Evento BuscarPorId(Guid id)
        {
            Evento eventoBuscado = _eventContext.Evento.Find(id);

            return eventoBuscado;
        }

        public void Cadastrar(Evento evento)
        {
            try
            {
                _eventContext.Evento.Add(evento);

                _eventContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            Evento eventoBuscado = _eventContext.Evento.Find(id);

            if (eventoBuscado != null)
            {
                _eventContext.Evento.Remove(eventoBuscado);

                _eventContext.SaveChanges();
            }
        }

        public List<Evento> Listar()
        {
            if (_eventContext.TipoEvento.ToList() != null)
            {
                return _eventContext.Evento.ToList();
            }
            return null;
        }
    }
}
