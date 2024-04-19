using HealthClinic_tarde.Domains;

namespace HealthClinic_tarde.Interfaces
{
    public interface IClinicaRepository
    {
        void Cadastrar(Clinica clinica);

        void Atualizar(Guid id, Clinica clinica);

        Clinica BuscarPorId(Guid id);
    }
}
