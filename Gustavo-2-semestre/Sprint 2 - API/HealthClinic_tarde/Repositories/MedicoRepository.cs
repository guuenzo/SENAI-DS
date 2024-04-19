using HealthClinic_tarde.Domains;
using HealthClinic_tarde.Interfaces;
using webapi.event_.tarde.Contexts;

namespace HealthClinic_tarde.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        HealthContext ctx;

        public MedicoRepository()
        {
            ctx = new HealthContext();
        }

        public void Atualizar(Guid id, Medico medico)
        {
            Medico medicoBuscado = ctx.Medico.Find(id);

            if (medicoBuscado != null)
            {
                medicoBuscado.Expediente = medico.Expediente;

                ctx.SaveChanges();
            }
        }

        public Medico BuscarPorId(Guid id)
        {
            Medico medicoBuscado = ctx.Medico.Find(id);

            return medicoBuscado;
        }

        public void Cadastrar(Medico medico)
        {
            ctx.Medico.Add(medico);

            ctx.SaveChanges();
        }

        public void Deletar(Guid id, Medico medico)
        {
            Medico medicoBuscado = ctx.Medico.Find(id);

            if (medicoBuscado != null)
            {
                ctx.Medico.Remove(medicoBuscado);

                ctx.SaveChanges();
            }
        }

        public List<Medico> Listar()
        {
            return ctx.Medico.ToList();
        }
    }
}
