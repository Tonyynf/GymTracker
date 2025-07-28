using GymTracker.Models;

namespace GymTracker.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Treino> Treinos { get; set; }
        public DbSet<Exercicio> Exercicios{ get; set; }
    }
}