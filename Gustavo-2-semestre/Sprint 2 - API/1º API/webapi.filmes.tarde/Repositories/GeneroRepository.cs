using Microsoft.AspNetCore.Identity;
using System.Data.SqlClient;
using webapi.filmes.tarde.Domains;
using webapi.filmes.tarde.Interfaces;

namespace webapi.filmes.tarde.Repositories
{
    public class GeneroRepository : IGeneroRepository
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

        public void AtualizarIdCorpo(GeneroDomain genero)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryUpdateIdBody = "UPDATE Genero SET Nome = @Nome WHERE IdGenero = @IdGenero";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryUpdateIdBody, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", genero.Nome);

                    cmd.Parameters.AddWithValue("@IdGenero", genero.IdGenero);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AtualizarIdUrl(int id, GeneroDomain genero)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryUpdateUrl = "UPDATE Genero SET Nome = @Nome WHERE IdGenero = @IdGenero";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(queryUpdateUrl, con))
                {
                    cmd.Parameters.AddWithValue("@IdGenero", id);

                    cmd.Parameters.AddWithValue("@Nome", genero.Nome);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Metodo para buscar um genero pelo id
        /// </summary>
        /// <param name="id">Id do genero a ser buscado</param>
        /// <returns>Genero buscado</returns>
        public GeneroDomain BuscarPorId(int id)
        {
            //Instancia do objeto do genero que ira ser buscado
            GeneroDomain generoBuscado = new GeneroDomain();

            //Declara a SqlConnection passando a string de conexao como parametro
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                //script que sera realizado dentro do banco de dados 
                string queryBusca = "SELECT * FROM Genero WHERE IdGenero = @IdGenero";

                //Abre a conexao com o banco de dados
                con.Open();

                SqlDataReader rdr;
                //Declara o SqlCommand passando a query que sera executada e a conexao com o banco de dados
                using (SqlCommand cmd = new SqlCommand(queryBusca, con))
                {
                    //Comando que da valor ao "@IdGenero"
                    cmd.Parameters.AddWithValue("@IdGenero", id);

                    //Executa a query
                    rdr = cmd.ExecuteReader();

                    //Atribui valor ao generoBuscado
                    if (rdr.Read())
                    {
                        generoBuscado.IdGenero = id;
                        generoBuscado.Nome = rdr["Nome"].ToString();

                        return generoBuscado;
                    }
                }
            }
            //Retorna o genero buscado
            return null;
        }

        /// <summary>
        /// Cadastrar um novo genero
        /// </summary>
        /// <param name="novoGenero">Objeto com as informacoes que serao cadastradas</param>

        public void Cadastrar(GeneroDomain novoGenero)
        {
            //Declara a SqlConnection passando a string de conexao como parametro
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryInsert = "INSERT INTO Genero(Nome) values(@Nome)";

                //Declara o SqlCommand passando a query que sera executada e a conexao com o banco de dados
                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    //Passa o valor do parametro @Nome
                    cmd.Parameters.AddWithValue("@Nome", novoGenero.Nome);

                    //Abre a conexao com o banco de dados
                    con.Open();

                    //Executa a query
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Deletar um genero existente
        /// </summary>
        /// <param name="id">Id do genero a ser deletado</param>
        public void Deletar(int id)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryDelete = "DELETE FROM Genero WHERE IdGenero = @IdGenero";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                {
                    cmd.Parameters.AddWithValue("@IdGenero", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Listar todos os objetos do tipo genero
        /// </summary>
        /// <returns>Lista de objetos do tipo genero</returns>
        public List<GeneroDomain> ListarTodos()
        {
            //Cria uma lista de generos onde serao armazenados os generos
            List<GeneroDomain> ListaGeneros = new List<GeneroDomain>();

            //Declara a SqlConnection passando a string de conexao como parametro
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                //Declara a instrucao a ser executada
                string querySelectAll = "SELECT IdGenero, Nome FROM Genero";

                //Abre a conexao com o banco de dados
                con.Open();

                //Declara o SqlDataReader para percorrer e/ou ler a tabela no banco de dados
                SqlDataReader rdr;

                //Declara o SqlCommand passando a query que sera executada e a conexao
                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    //Executa a query e armazena os dados no rdr
                    rdr = cmd.ExecuteReader();

                    //Enquanto houver registros para serem lidos no rdr o laco se repetira
                    while (rdr.Read())
                    {
                        GeneroDomain genero = new GeneroDomain()
                        {
                            //Atribui a propriedade IdGenero o valor da primeira coluna da tabela
                            IdGenero = Convert.ToInt32(rdr[0]),

                            //Atribui a propriedade Nome o valor da coluna Nome
                            Nome = rdr["Nome"].ToString()
                        };

                        //Adciona o objeto criados dentro da lista
                        ListaGeneros.Add(genero);
                    }
                }
            }
            //Retorna a lista de generos
            return ListaGeneros;
        }
    }
}



