using HealthClinic_tarde.Domains;

namespace HealthClinic_tarde.Interfaces
{
    public interface IPacienteRepository
    {
        void Cadastrar(Paciente paciente);

        void Deletar(Guid id, Paciente paciente);

        void Atualizar(Guid id, Paciente paciente);

        List<Paciente> Listar();

        Paciente BuscarPorId(Guid id);
    }
}
