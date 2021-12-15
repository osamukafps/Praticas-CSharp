using Microsoft.EntityFrameworkCore;
using PraticandoDesignPatterns.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PraticandoDesignPatterns.Infra.Repository.EF
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly PessoaContext dbContext;

        public PessoaRepository(PessoaContext dbContext) => this.dbContext = dbContext;
        public void Cadastrar(Pessoa pessoa)
        {
            dbContext.Pessoas.Add(pessoa);
            dbContext.SaveChanges();
        }
        public Pessoa ObterPorCPF(string cpf) => dbContext.Pessoas.SingleOrDefaultAsync().Result;
        public Pessoa ObterPorNascimento(DateTime nascimento) => dbContext.Pessoas.SingleOrDefaultAsync().Result;
        public Pessoa ObterPorNome(string nome) => dbContext.Pessoas.SingleOrDefaultAsync().Result;
        public IEnumerable<Pessoa> ObterTodos()
        {
            return dbContext.Pessoas.ToListAsync().Result;
        }
    }
}
