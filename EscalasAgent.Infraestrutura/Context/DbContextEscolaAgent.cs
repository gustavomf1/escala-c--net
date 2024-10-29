using EscalasAgent.Core.Entities;
using Microsoft.EntityFrameworkCore;


namespace EscalasAgent.Infraestrutura.Context
{
    public class DbContextEscolaAgent : DbContext
    {
        public DbContextEscolaAgent()
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Pessoa> pessoas { get; set; }
        public DbSet<Equipe> equipes { get; set; }
        public DbSet<Escala> escalas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>(e =>
            {
                e.Property(p => p.Nome).HasMaxLength(150);

                e.HasOne(p => p.equipe)
                    .WithMany() // Deixa vazio para manter o relacionamento unidirecional
                    .HasForeignKey(p => p.IdEquipe)
                    .HasConstraintName("FK_pessoa_equipe")
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Equipe>(e =>
            {
                e.Property(p => p.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Escala>(e =>
            {
                e.Property(p => p.Titulo).HasMaxLength(100);
                e.Property(p => p.Descricao).HasMaxLength(200);
                e.HasOne(p => p.equipe).WithMany(p => p.escalas)
                    .HasForeignKey(e => e.IdEquipe).HasConstraintName("FK_escala_equipe")
                    .OnDelete(DeleteBehavior.Restrict);
            });

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);

            var stringConexao = @"Server=LAB10-10; DataBase=EscalaAgentes; integrated security=true; TrustServerCertificate=True;";

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(stringConexao);
            }
        }
    }
}
