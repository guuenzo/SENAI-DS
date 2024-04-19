using HealthClinic_tarde.Domains;

namespace HealthClinic_tarde.Interfaces
{
    public interface IMedicoRepository
    {
        void Cadastrar(Medico medico);

        void Deletar(Guid id, Medico medico);

        void Atualizar(Guid id, Medico medico);

        List<Medico> Listar();

        Medico BuscarPorId(Guid id);
    }
}
