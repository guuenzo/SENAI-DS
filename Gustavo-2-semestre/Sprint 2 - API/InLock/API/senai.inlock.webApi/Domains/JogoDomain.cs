using System.Globalization;

namespace senai.inlock.webApi.Domains
{
    public class JogoDomain
    {
        public int IdJogo { get; set; }

        public int IdEstudio { get; set; }
        public EstudioDomain estudio { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string DataLancamento { get; set; }

        public decimal Valor { get; set; }
    }
}
