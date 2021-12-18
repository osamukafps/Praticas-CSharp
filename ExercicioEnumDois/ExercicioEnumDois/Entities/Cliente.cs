using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEnumDois.Entities
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nome, string email, DateTime nascimento)
        {
            Nome = nome;
            Email = email;
            DataNascimento = nascimento;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Nome + $"({DataNascimento.ToString("dd/MM/yyyy")})");
            sb.AppendLine(Email);

            return sb.ToString();
        }

    }
}
