using webapi.inlock_codefirst.Domains;

namespace webapi.inlock_CodeFirst.Interfaces
{
    public interface IUsuarioRepository
    {
        Usuario Login(string email, string senha);

        void Cadastrar(Usuario usuario);
    }
}
