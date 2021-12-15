using ExercicioEnum.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEnum.Entities
{
    class Trabalhador
    {
        public string Nome { get; set; }
        public NivelTrabalhador Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<ContratoHorista> Contratos { get; private set; } = new List<ContratoHorista>();

        public Trabalhador()
        {

        }

        public Trabalhador(string nome, NivelTrabalhador nivel, double salario, Departamento dept)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salario;
            Departamento = dept;
        }

        public void AdicionarContrato(ContratoHorista contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoverContrato(ContratoHorista contrato)
        {
            Contratos.Remove(contrato);
        }

        public double CalcularRenda(int mes, int ano)
        {
            double salario = SalarioBase;

            foreach (ContratoHorista contrato in Contratos)
            {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes)
                    salario += contrato.ValorTotal();
            }

            return salario;
        }
    }
}
