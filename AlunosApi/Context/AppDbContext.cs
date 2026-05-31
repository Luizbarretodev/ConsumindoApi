using AlunosApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AlunosApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno
                {
                    Id = 1,
                    Nome = "Maria da Penha",
                    Email = "mariapenha@gmail.com",
                    Idade = 23
                },
                new Aluno
                {
                    Id = 2,
                    Nome = "Manoel Bueno",
                    Email = "manoelbueno@gmail.com",
                    Idade = 22
                }
                );
        }
    }
}
