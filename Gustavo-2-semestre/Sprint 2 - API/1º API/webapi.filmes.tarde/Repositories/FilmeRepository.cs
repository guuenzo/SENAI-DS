using System.Data.SqlClient;
using webapi.filmes.tarde.Domains;
using webapi.filmes.tarde.Interfaces;

namespace webapi.filmes.tarde.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        /// <summary>
        /// String de conexao com o banco de dados que recebe os seguintes parametros:
        /// Data Source: Nome do servidor do banco
        /// Initial Catalog: Nome do banco de dados
        /// Autenticacao:
        ///        - windows: Integrated Security = True
        ///        - SqlServer: User Id = sa; Pwd = senha
        /// </summary>
        private string StringConexao = "Data Source = NOTE17-S14; Initial Catalog = Filmes_Tarde; User Id = sa; Pwd = Senai@134";

        public void AtualizarIdCorpo(FilmeDomain filme)
        {
            
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryUpdateIdBody = "UPDATE Filme SET Titulo = @Titulo, IdGenero = @IdGenero WHERE IdFilme = @IdFilme";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryUpdateIdBody, con))
                {
                    cmd.Parameters.AddWithValue("@Titulo", filme.Titulo);

                    cmd.Parameters.AddWithValue("@IdFilme", filme.IdFilme);

                    cmd.Parameters.AddWithValue("@IdGenero", filme.IdGenero);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AtualizarIdUrl(int id, FilmeDomain filme)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryUpdateUrl = "UPDATE Filme SET Titulo = @Titulo, IdGenero = @IdGenero WHERE IdFilme = @IdFilme";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryUpdateUrl, con))
                {
                    cmd.Parameters.AddWithValue("@Titulo", filme.Titulo);

                    cmd.Parameters.AddWithValue("@IdFilme", id);

                    cmd.Parameters.AddWithValue("@IdGenero", filme.IdGenero);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public FilmeDomain BuscarPorId(int id)
        {
            FilmeDomain filmeBuscado = new FilmeDomain();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryBusca = "SELECT * FROM Filme WHERE IdFilme = @IdFilme";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(queryBusca, con))
                {
                    cmd.Parameters.AddWithValue("@IdFilme", id);

                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        filmeBuscado.IdFilme = id;

                        filmeBuscado.Titulo = rdr["Titulo"].ToString();

                        return filmeBuscado;
                    }
                }
            }
            return null;
        }

        public void Cadastrar(FilmeDomain novoFilme)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryInsert = "INSERT INTO Filme(IdGenero, Titulo) VALUES(@IdGenero, @Titulo)";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@IdGenero", novoFilme.IdGenero);

                    cmd.Parameters.AddWithValue("@Titulo", novoFilme.Titulo);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Deletar(int id)
        {
            FilmeDomain filmeDeletado = new FilmeDomain();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryDelete = "DELETE FROM Filme WHERE IdFilme = @IdFilme";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                {
                    cmd.Parameters.AddWithValue("@IdFilme", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<FilmeDomain> ListarTodos()
        {
            List<FilmeDomain> ListaFilmes = new List<FilmeDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string querySelectAll = "SELECT Filme.IdFilme, Filme.IdGenero, Genero.Nome, Filme.Titulo FROM Filme INNER JOIN Genero on Filme.IdGenero = Genero.IdGenero";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        FilmeDomain filme = new FilmeDomain()
                        {
                            IdFilme = Convert.ToInt32(rdr["IdFilme"]),

                            IdGenero = Convert.ToInt32(rdr["IdGenero"]),

                            Titulo = rdr["Titulo"].ToString(),

                            Genero = new GeneroDomain()
                            {
                                Nome = rdr["Nome"].ToString(),
                                IdGenero = Convert.ToInt32(rdr["IdGenero"])
                            }
                        };
                        ListaFilmes.Add(filme);
                    }
                }

            }
            return ListaFilmes;
        }




    }
}
