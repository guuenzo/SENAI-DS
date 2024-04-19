using Microsoft.EntityFrameworkCore;
using webapi.inlock_codefirst.Domains;

namespace webapi.inlock_codefirst.Context
{
    public class InLockContext : DbContext
    {
        /// <summary>
        /// Definicao das entidades do banco de dados
        /// </summary>

        public DbSet<TiposUsuario> TiposUsuario { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Estudio> Estudio { get; set; }

        public DbSet<Jogo> Jogo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE17-S14; Database=inlock_games_codefirst_tarde; User Id=sa; Pwd=Senai@134; TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
