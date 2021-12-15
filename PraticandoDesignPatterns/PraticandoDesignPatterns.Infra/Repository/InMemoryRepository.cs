using PraticandoDesignPatterns.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PraticandoDesignPatterns.Infra.Repository
{
    public class InMemoryRepository : IPessoaRepository
    {
        private readonly IList<Pessoa> listaDePessoas = new List<Pessoa>();
        public void Cadastrar(Pessoa pessoa) => listaDePessoas.Add(pessoa);
        public Pessoa ObterPorCPF(string cpf) => listaDePessoas.SingleOrDefault(c => c.CPF == cpf);
        public Pessoa ObterPorNascimento(DateTime nascimento) => listaDePessoas.SingleOrDefault(c => c.DataDeNascimento.Date == nascimento.Date);
        public Pessoa ObterPorNome(string nome) => listaDePessoas.SingleOrDefault(c => c.Nome == nome);
        public IEnumerable<Pessoa> ObterTodos()
        {
            return listaDePessoas.ToList();
        }

       
    }
}
