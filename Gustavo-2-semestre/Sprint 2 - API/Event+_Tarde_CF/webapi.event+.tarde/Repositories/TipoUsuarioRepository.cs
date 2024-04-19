using webapi.event_.tarde.Contexts;
using webapi.event_.tarde.Domains;
using webapi.event_.tarde.Interfaces;

namespace webapi.event_.tarde.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        private readonly EventContext _eventContext;

        public TipoUsuarioRepository()
        {
            _eventContext = new EventContext();
        }

        public void Atualizar(Guid id, TipoUsuario tipoUsuario)
        {
            TipoUsuario novoTipoUsuario = _eventContext.TipoUsuario.Find(id);

            if (novoTipoUsuario != null)
            {
                novoTipoUsuario.Titulo = tipoUsuario.Titulo;

                _eventContext.SaveChanges();
            }
        }

        public TipoUsuario BuscarPorId(Guid id)
        {
            TipoUsuario tipoUsuarioBuscado = _eventContext.TipoUsuario.Find(id);

            if (tipoUsuarioBuscado != null)
            {
                return tipoUsuarioBuscado;
            }
            return null!;
        }

        public void Cadastrar(TipoUsuario tipoUsuario)
        {
            try
            {
                _eventContext.TipoUsuario.Add(tipoUsuario);

                _eventContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            TipoUsuario tipoUsuarioBuscado = _eventContext.TipoUsuario.Find(id);

            if (tipoUsuarioBuscado != null)
            {
                _eventContext.TipoUsuario.Remove(tipoUsuarioBuscado);
            }

            _eventContext.SaveChanges();
        }

        public List<TipoUsuario> Listar()
        {
            return _eventContext.TipoUsuario.ToList();
        }
    }
}
