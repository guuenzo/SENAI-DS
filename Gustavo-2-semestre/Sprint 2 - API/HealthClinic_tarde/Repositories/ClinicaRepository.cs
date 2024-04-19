using HealthClinic_tarde.Domains;
using HealthClinic_tarde.Interfaces;
using webapi.event_.tarde.Contexts;

namespace HealthClinic_tarde.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        private readonly HealthContext ctx;

        public ClinicaRepository()
        {
            ctx = new HealthContext();
        }

        public void Atualizar(Guid id, Clinica clinica)
        {
            Clinica novaClinica = ctx.Clinica.Find(id);

            if (novaClinica != null)
            {
                novaClinica.Nome= clinica.Nome;
                novaClinica.CNPJ= clinica.CNPJ;
                novaClinica.Endereco= clinica.Endereco;
                novaClinica.RazaoSocial= clinica.RazaoSocial;
                novaClinica.HoraAbertura= clinica.HoraAbertura;
                novaClinica.HoraFechamento= clinica.HoraFechamento;

                ctx.SaveChanges();
            }
        }

        public Clinica BuscarPorId(Guid id)
        {
            Clinica clinicaBuscada = ctx.Clinica.Find(id);

            return clinicaBuscada;
        }

        public void Cadastrar(Clinica clinica)
        {
            try
            {
                ctx.Clinica.Add(clinica);

                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
