using webapi.event_.tarde.Contexts;
using webapi.event_.tarde.Domains;
using webapi.event_.tarde.Interfaces;

namespace webapi.event_.tarde.Repositories
{
    public class ComentarioEventoRepository : IComentarioEventoRepository
    {

        private readonly EventContext _eventContext;

        public ComentarioEventoRepository()
        {
            _eventContext = new EventContext();
        }

        public void Atualizar(Guid id, ComentarioEvento comentarioEvento)
        {
            ComentarioEvento novoComentario = _eventContext.ComentarioEvento.Find(id);

            if(novoComentario != null) 
            {
                novoComentario.Descricao = comentarioEvento.Descricao;
                novoComentario.Exibe= comentarioEvento.Exibe;
                novoComentario.IdUsuario = comentarioEvento.IdUsuario;
                novoComentario.IdEvento = comentarioEvento.IdEvento;

                _eventContext.SaveChanges();
            }
        }

        public ComentarioEvento BuscarPorId(Guid id)
        {
            ComentarioEvento comentarioBuscado = _eventContext.ComentarioEvento.Find(id);

            return comentarioBuscado;
        }

        public void Cadastrar(ComentarioEvento comentarioEvento)
        {
            _eventContext.Add(comentarioEvento);

            _eventContext.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            ComentarioEvento comentarioBuscado = _eventContext.ComentarioEvento.Find(id);

            if (comentarioBuscado != null)
            {
                _eventContext.ComentarioEvento.Remove(comentarioBuscado);

                _eventContext.SaveChanges();
            }
        }

        public List<ComentarioEvento> Listar()
        {
            return _eventContext.ComentarioEvento.ToList();
        }
    }
}

        

