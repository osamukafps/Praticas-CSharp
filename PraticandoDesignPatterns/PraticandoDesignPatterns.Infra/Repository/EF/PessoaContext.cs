using Microsoft.EntityFrameworkCore;
using PraticandoDesignPatterns.Domain;

namespace PraticandoDesignPatterns.Infra.Repository.EF
{
    public class PessoaContext : DbContext
    {
        public PessoaContext(DbContextOptions<PessoaContext> options)
              : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}

