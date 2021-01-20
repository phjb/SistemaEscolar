using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Data.Context
{
    public class EFApplicationContext: DbContext
    {
        private readonly IConfiguration _configuration;

        public EFApplicationContext(DbContextOptions<EFApplicationContext> options) : base(options)
        {
        }
        public EFApplicationContext(IConfiguration configuration, DbContextOptions<EFApplicationContext> options) : base(options)
        {
            _configuration = configuration;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EFApplicationContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        // Classes 
        public DbSet<AnoLetivo> AnoLetivo { get; set; }

        public DbSet<Cidade> Cidade { get; set; }

        public DbSet<Estado> Estado { get; set; }

        public DbSet<Endereco> Endereco { get; set; }

        public DbSet<Pessoa> Pessoa { get; set; }
    }
}
