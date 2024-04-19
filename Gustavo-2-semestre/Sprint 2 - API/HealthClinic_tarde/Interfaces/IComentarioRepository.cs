using HealthClinic_tarde.Domains;

namespace HealthClinic_tarde.Interfaces
{
    public interface IComentarioRepository
    {
        void Cadastrar(Comentario comentario);
    }
}
