using webapi.inlock_codefirst.Domains;

namespace webapi.inlock_CodeFirst.Interfaces
{
    public interface IJogoRepository
    {
        //CRUD 

        void Cadastrar(Jogo novoJogo);

        List<Jogo> ListarTodos();

        Jogo BuscarPorId(Guid id);

        void AtualizarIdCorpo(Jogo jogo);

        void AtualizarIdUrl(Guid id, Jogo jogo);

        void Deletar(Guid id);
    }
}
