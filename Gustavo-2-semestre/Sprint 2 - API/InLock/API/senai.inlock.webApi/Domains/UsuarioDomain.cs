using System.Globalization;

namespace senai.inlock.webApi.Domains
{
    public class UsuarioDomain
    {
        public int IdUsuario { get; set; }

        public int IdTipoUsuario { get; set; }
        public TiposUsuarioDomain tiposUsuarioDomain { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }
    }
}
