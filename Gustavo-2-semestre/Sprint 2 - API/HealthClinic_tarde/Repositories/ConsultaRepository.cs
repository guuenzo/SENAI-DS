using HealthClinic_tarde.Domains;
using HealthClinic_tarde.Interfaces;
using webapi.event_.tarde.Contexts;

namespace HealthClinic_tarde.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        private readonly HealthContext ctx;

        public ConsultaRepository()
        {
            ctx = new HealthContext();
        }

        public Consulta BuscarPorId(Guid id)
        {
            Consulta consultaBuscada = ctx.Consulta.Find(id);

            return consultaBuscada;
        }

        public void Cadastrar(Consulta consulta)
        {
            ctx.Consulta.Add(consulta);

            ctx.SaveChanges();
        }

        public void Deletar(Guid id, Consulta consulta)
        {
            Consulta consultaBuscada = ctx.Consulta.Find(id);

            if(consultaBuscada != null) 
            {
                ctx.Remove(consultaBuscada);

                ctx.SaveChanges();
            }
        }

        public List<Consulta> Listar()
        {
            return ctx.Consulta.ToList();
        }
    }
}
