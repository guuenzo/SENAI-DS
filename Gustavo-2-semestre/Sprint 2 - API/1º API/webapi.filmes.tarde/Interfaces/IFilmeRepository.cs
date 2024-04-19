using webapi.filmes.tarde.Domains;

namespace webapi.filmes.tarde.Interfaces
{
    public interface IFilmeRepository
    {
        //CRUD

        //TipoDeRetorno NomeMetodo(TipoParametro NomeParametro)

        /// <summary>
        /// Cadastrar um novo filme
        /// </summary>
        /// <param name="novoFilme">Este parametro é o objeto que será cadastrado</param>
        void Cadastrar(FilmeDomain novoFilme);

        /// <summary>
        /// Retornar todos os filme cadastrados
        /// </summary>
        /// <returns>Retorna uma lista de filmes</returns>
        List<FilmeDomain> ListarTodos();

        /// <summary>
        /// Buscar um objeto atraves do seu id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        FilmeDomain BuscarPorId(int id);

        /// <summary>
        /// Atualizar um filme existente, passando o id pelo corpo da requisicao
        /// </summary>
        /// <param name="genero">Objeto genero com novas informacões</param>
        void AtualizarIdCorpo(FilmeDomain filme);

        /// <summary>
        /// Atualizar um filme existente passando o id pela url da requisicao
        /// </summary>
        /// <param name="id">id do obj a ser att</param>
        /// <param name="genero">obj com as novas infos</param>
        void AtualizarIdUrl(int id, FilmeDomain filme);

        /// <summary>
        /// Deletar um filme existente
        /// </summary>
        /// <param name="id">id do objeto a ser deletado</param>
        void Deletar(int id);
    }

}

