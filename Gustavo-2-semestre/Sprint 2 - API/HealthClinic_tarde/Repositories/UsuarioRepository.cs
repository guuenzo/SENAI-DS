using HealthClinic_tarde.Domains;
using HealthClinic_tarde.Interfaces;
using HealthClinic_tarde.Utils;
using Microsoft.EntityFrameworkCore;
using webapi.event_.tarde.Contexts;

namespace HealthClinic_tarde.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly HealthContext ctx;

        public UsuarioRepository()
        {
            ctx = new HealthContext();
        }

        public void Atualizar(Guid id, Usuario usuario)
        {
            Usuario novoUsuario = ctx.Usuario.Find(id);

            if (novoUsuario != null)
            {
                novoUsuario.Nome = usuario.Nome;
                novoUsuario.Email = usuario.Email;
                novoUsuario.Senha = usuario.Senha;

                ctx.SaveChanges();
            }
        }

        public Usuario BuscarPorId(Guid id)
        {
            Usuario usuarioBuscado = ctx.Usuario.Find(id);

            return usuarioBuscado;
        }

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                usuario.Senha = Criptografia.GerarHash(usuario.Senha!);

                ctx.Usuario.Add(usuario);

                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuario Login(string email, string senha)
        {
            try
            {
                Usuario usuarioBuscado = ctx.Usuario.Include(x => x.TipoUsuario)
                     .Select(u => new Usuario
                     {
                         IdUsuario = u.IdUsuario,
                         Nome = u.Nome,
                         Email = u.Email,
                         Senha = u.Senha,
                         TipoUsuario = new TipoUsuario
                         {
                             IdTipoUsuario = u.IdTipoUsuario,
                             Nome = u.TipoUsuario.Nome
                         }
                     }).FirstOrDefault(u => u.Email == email)!;

                if (usuarioBuscado != null)
                {
                    bool confere = Criptografia.CompararHash(senha, usuarioBuscado.Senha);

                    if (confere)
                    {
                        return usuarioBuscado;
                    }
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
