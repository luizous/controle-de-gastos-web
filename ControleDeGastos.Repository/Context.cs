using ControleDeGastos.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ControleDeGastos.Repository
{
    public class Context : IdentityDbContext<UsuarioLogado>
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Recebimento> Recebimentos { get; set; }
        public DbSet<Cartao> Cartoes { get; set; }
        public DbSet<Lancamento> Lancamentos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Meta> Metas { get; set; }
        public DbSet<Poupanca> Poupancas { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    // configura apenas 1 propriedade
        //    modelBuilder.Entity<Lancamento>()
        //        .Property(e => e.DataLancamento)
        //        .HasColumnType("datetime2");
        //}
    }
}
