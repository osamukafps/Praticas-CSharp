using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PraticandoDesignPatterns.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticandoDesignPatterns.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaRepository pessoaRepository;

        public PessoaController(IPessoaRepository _pessoaRepository)
        {
            this.pessoaRepository = _pessoaRepository;
        }

        [HttpGet("pesquisar-todos")]
        public IEnumerable<Pessoa> ObterTodos()
        {
            return pessoaRepository.ObterTodos();
        }

        [HttpGet("pesquisar-pelo-cpf")]
        public IActionResult ObterPeloCpf(string cpf)
        {
            var pessoa = pessoaRepository.ObterPorCPF(cpf);

            if (pessoa == null)
                return NotFound();

            return Ok(pessoa);
        }

        [HttpGet("pesquisar-pelo-nome")]
        public IActionResult ObterPeloNome(string nome)
        {
            var pessoa = pessoaRepository.ObterPorNome(nome);

            if (pessoa == null)
                return NotFound();

            return Ok(pessoa);
        }

        [HttpGet("pesquisar-pelo-nascimento")]
        public IActionResult ObterPeloNascimento(DateTime data)
        {
            var pessoa = pessoaRepository.ObterPorNascimento(data);

            if (pessoa == null)
                return NotFound();

            return Ok(pessoa);
        }

        [HttpPost("cadastrar-nova-pessoa")]
        public IActionResult CadastrarNovo([FromBody] Pessoa pessoa)
        {
            pessoaRepository.Cadastrar(pessoa);

            return Ok(pessoa);
        }



    }
}
