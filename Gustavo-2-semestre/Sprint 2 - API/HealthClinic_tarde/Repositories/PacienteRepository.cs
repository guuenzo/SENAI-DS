using HealthClinic_tarde.Domains;
using HealthClinic_tarde.Interfaces;
using webapi.event_.tarde.Contexts;

namespace HealthClinic_tarde.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly HealthContext ctx;

        public PacienteRepository()
        {
            ctx = new HealthContext();
        }

        public void Atualizar(Guid id, Paciente paciente)
        {
            Paciente novoPaciente = ctx.Paciente.Find(id);

            if(novoPaciente != null)
            {
                novoPaciente.Telefone = paciente.Telefone;
                novoPaciente.Endereco = paciente.Endereco;
                novoPaciente.RG = paciente.RG;
                novoPaciente.CPF = paciente.CPF;

                ctx.SaveChanges();
            }
        }

        public Paciente BuscarPorId(Guid id)
        {
            Paciente pacienteBuscado = ctx.Paciente.Find(id);

            return pacienteBuscado;
        }

        public void Cadastrar(Paciente paciente)
        {
            ctx.Paciente.Add(paciente);

            ctx.SaveChanges();
        }

        public void Deletar(Guid id, Paciente paciente)
        {
            Paciente pacienteBuscado = ctx.Paciente.Find(id);

            if(pacienteBuscado != null)
            {
                ctx.Remove(pacienteBuscado);

                ctx.SaveChanges();
            }
        }

        public List<Paciente> Listar()
        {
            return ctx.Paciente.ToList();
        }
    }
}
