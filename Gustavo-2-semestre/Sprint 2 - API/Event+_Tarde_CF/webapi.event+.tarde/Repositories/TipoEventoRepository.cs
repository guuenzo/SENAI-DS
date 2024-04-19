using webapi.event_.tarde.Contexts;
using webapi.event_.tarde.Domains;
using webapi.event_.tarde.Interfaces;

namespace webapi.event_.tarde.Repositories
{
    public class TipoEventoRepository : ITipoEventoRepository
    {
        private readonly EventContext _eventContext;

        public TipoEventoRepository()
        {
            _eventContext = new EventContext();
        }

        public void Atualizar(Guid id, TipoEvento tipoEvento)
        {
            TipoEvento novoTipoEvento = _eventContext.TipoEvento.Find(id);

            if (novoTipoEvento != null)
            {
                novoTipoEvento.Titulo = tipoEvento.Titulo;

                _eventContext.SaveChanges();
            }
        }

        public TipoEvento BuscarPorId(Guid id)
        {
            TipoEvento tipoEventoBuscado = _eventContext.TipoEvento.Find(id);

            return tipoEventoBuscado;
        }

        public void Cadastrar(TipoEvento tipoEvento)
        {
            _eventContext.Add(tipoEvento);

            _eventContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            TipoEvento tipoEventoBuscado = _eventContext.TipoEvento.Find(id);

            if (tipoEventoBuscado != null)
            {
                _eventContext.TipoEvento.Remove(tipoEventoBuscado);

                _eventContext.SaveChanges();
            }
        }

        public List<TipoEvento> Listar()
        {
            if (_eventContext.TipoEvento.ToList() != null)
            {
                return _eventContext.TipoEvento.ToList();
            }
            return null;
        }
    }
}
