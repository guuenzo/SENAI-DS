using Microsoft.EntityFrameworkCore;
using webapi.event_.tarde.Contexts;
using webapi.event_.tarde.Domains;
using webapi.event_.tarde.Interfaces;

namespace webapi.event_.tarde.Repositories
{
    public class PresencaEventoRepository : IPresencaEventoRepository
    {
        private readonly EventContext _eventContext;

        public PresencaEventoRepository()
        {
            _eventContext = new EventContext();
        }

        public void Atualizar(Guid id, PresencaEvento presencaEvento)
        {
            PresencaEvento novaPresenca = _eventContext.PresencaEvento.Find(id);

            if (novaPresenca != null) 
            {
                novaPresenca.Situacao = presencaEvento.Situacao;
                novaPresenca.IdUsuario = presencaEvento.IdUsuario;
                novaPresenca.IdEvento = presencaEvento.IdEvento;

                _eventContext.SaveChanges();
            }
        }

        public PresencaEvento BuscarPorId(Guid id)
        {
            PresencaEvento presencaBuscada = _eventContext.PresencaEvento.Find(id);

            return presencaBuscada;
        }

        public void Cadastrar(PresencaEvento presencaEvento)
        {
            _eventContext.Add(presencaEvento);

            _eventContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            PresencaEvento presencaBuscada = _eventContext.PresencaEvento.Find(id);

            if(presencaBuscada != null)
            {
                _eventContext.PresencaEvento.Remove(presencaBuscada);

                _eventContext.SaveChanges();
            }
        }

        public List<PresencaEvento> Listar()
        {
            return _eventContext.PresencaEvento.ToList();
        }
    }
}
