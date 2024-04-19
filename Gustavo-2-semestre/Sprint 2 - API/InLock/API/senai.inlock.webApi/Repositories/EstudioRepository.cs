using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using System.Data.SqlClient;
using System.Globalization;

namespace senai.inlock.webApi.Repositories
{
    public class EstudioRepository : IEstudioRepository
    {
        private string StringConexao = "Data Source = NOTE17-S14; Initial Catalog = inlock_games_tarde; User Id = sa; Pwd = Senai@134";

        public void Cadastrar(EstudioDomain novoEstudio)
        {
            using(SqlConnection con = new SqlConnection(StringConexao)) 
            {
                string queryInsert = "INSERT INTO Estudio VALUES(@Nome)";

                con.Open();

                using(SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", novoEstudio.Nome);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<EstudioDomain> ListarEstudios()
        {
            throw new NotImplementedException();
        }
    }
}
