using webapi.event_.tarde.Contexts;
using webapi.event_.tarde.Domains;
using webapi.event_.tarde.Interfaces;

namespace webapi.event_.tarde.Repositories
{
    public class InstituicaoRepository : IInstituicaoRepository
    {
        private readonly EventContext _eventContext;

        public InstituicaoRepository()
        {
            _eventContext = new EventContext();
        }

        public void Atualizar(Guid id, Instituicao instituicao)
        {
            Instituicao novaInstituicao = _eventContext.Instituicao.Find(id);

            if(novaInstituicao != null)
            {
                novaInstituicao.CNPJ = instituicao.CNPJ;
                novaInstituicao.Endereco = instituicao.Endereco;
                novaInstituicao.NomeFantasia = instituicao.NomeFantasia;

                _eventContext.SaveChanges();
            }
        }

        public Instituicao BuscarPorId(Guid id)
        {
            Instituicao instituicaoBuscada = _eventContext.Instituicao.Find(id);

            if (instituicaoBuscada != null)
            {
                return instituicaoBuscada;
            }
            return null;
        }

        public void Cadastrar(Instituicao instituicao)
        {
                try
                {
                    _eventContext.Instituicao.Add(instituicao);

                    _eventContext.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
        }

        public void Deletar(Guid id)
        {
            Instituicao instituicaoBuscada = _eventContext.Instituicao.Find(id);

            if(instituicaoBuscada != null)
            {
                _eventContext.Instituicao.Remove(instituicaoBuscada);

                _eventContext.SaveChanges();
            }
        }

        public List<Instituicao> Listar()
        {
            return _eventContext.Instituicao.ToList();
        }
    }
}
