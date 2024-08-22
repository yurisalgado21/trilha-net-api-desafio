using Microsoft.EntityFrameworkCore;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Context
{
    public class OrganizadorContext : DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {
            
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Database=Organizador;User=SA;Password=Organizador1234!;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}