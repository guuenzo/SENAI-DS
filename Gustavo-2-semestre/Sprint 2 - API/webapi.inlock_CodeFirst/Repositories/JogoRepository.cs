using System.Runtime.CompilerServices;
using webapi.inlock_codefirst.Context;
using webapi.inlock_codefirst.Domains;
using webapi.inlock_CodeFirst.Interfaces;

namespace webapi.inlock_CodeFirst.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private readonly InLockContext ctx;

        public JogoRepository()
        {
            ctx = new InLockContext();
        }

        public void AtualizarIdCorpo(Jogo jogo)
        {
            Jogo jogoUpdate = ctx.Jogo.Find(jogo.IdJogo);

            jogoUpdate.Nome = jogo.Nome;
            jogoUpdate.Descricao = jogo.Descricao;
            jogoUpdate.DataLancamento = jogo.DataLancamento;
            jogoUpdate.Preco = jogo.Preco;
            jogoUpdate.IdEstudio = jogo.IdEstudio;

            ctx.SaveChanges();
        }

        public void AtualizarIdUrl(Guid id, Jogo jogo)
        {
            Jogo jogoUpdate = ctx.Jogo.Find(id);

            jogoUpdate.Nome = jogo.Nome;
            jogoUpdate.Descricao= jogo.Descricao;
            jogoUpdate.DataLancamento = jogo.DataLancamento;
            jogoUpdate.Preco= jogo.Preco;
            jogoUpdate.IdEstudio= jogo.IdEstudio;

            ctx.SaveChanges();
        }

        public Jogo BuscarPorId(Guid id)
        {
            Jogo jogoBuscado = ctx.Jogo.Find(id);

            return jogoBuscado;
        }

        public void Cadastrar(Jogo novoJogo)
        {
            ctx.Jogo.Add(novoJogo);

            ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Jogo jogoDeletado = ctx.Jogo.Find(id);

            if(jogoDeletado != null)
            {
                ctx.Jogo.Remove(jogoDeletado);
            }

            ctx.SaveChanges();
        }

        public List<Jogo> ListarTodos()
        {
            return ctx.Jogo.ToList();
        }
    }
}
