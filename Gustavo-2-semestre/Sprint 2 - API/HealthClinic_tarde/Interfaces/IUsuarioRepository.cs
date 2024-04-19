using HealthClinic_tarde.Domains;
using System.Reflection.Metadata;

namespace HealthClinic_tarde.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);

        Usuario Login(string email, string senha);

        void Atualizar(Guid id, Usuario usuario);

        Usuario BuscarPorId(Guid id);  
    }
}
