using System;
using System.Collections.Generic;
using System.Text;

namespace PraticandoDesignPatterns.Domain
{
    public interface IPessoaRepository
    {
        void Cadastrar(Pessoa pessoa);
        Pessoa ObterPorCPF(string cpf);
        Pessoa ObterPorNome(string nome);
        Pessoa ObterPorNascimento(DateTime nascimento);
        IEnumerable<Pessoa> ObterTodos();

    }
}
