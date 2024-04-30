using EntityFrameworkLib.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkLib.Context
{
    public class LibDbContext : DbContext
    {
        public LibDbContext() { }

        public LibDbContext(DbContextOptions<LibDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=FrameworkMVVM;User Id=postgres;Password=postgres;");
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}

