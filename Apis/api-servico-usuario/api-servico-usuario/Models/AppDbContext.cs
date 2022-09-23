using Microsoft.EntityFrameworkCore;

namespace api_servico_usuario.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        { 
        }   
        // Criação das tabelas

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Passageiro> Passageiros { get; set; }
        public DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Passageiro)
                .WithOne(p => p.Usuario)
                .HasForeignKey<Passageiro>(u => u.IdUsuarioForeignKey);
        }
        
    }
}
