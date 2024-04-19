using HealthClinic_tarde.Domains;
using HealthClinic_tarde.Interfaces;
using webapi.event_.tarde.Contexts;

namespace HealthClinic_tarde.Repositories
{
    public class ComentarioRepository : IComentarioRepository
    {
        private readonly HealthContext ctx;

        public ComentarioRepository()
        {
            ctx = new HealthContext();
        }

        public void Cadastrar(Comentario comentario)
        {
            try
            {
                ctx.Comentario.Add(comentario);

                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
