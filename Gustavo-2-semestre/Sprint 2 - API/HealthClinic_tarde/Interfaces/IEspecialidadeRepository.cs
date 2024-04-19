using HealthClinic_tarde.Domains;

namespace HealthClinic_tarde.Interfaces
{
    public interface IEspecialidadeRepository
    {
        void Cadastrar(Especialidade especialidade);

        void Atualizar(Guid id, Especialidade especialidade);

        void BuscarPorId(Guid id);
    }
}
