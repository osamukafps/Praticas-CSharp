using System;
using System.Collections.Generic;
using System.Text;

namespace PraticaMemArrayListas
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public void SetSalario(double salario)
        {
            this.Salario = salario;
        }

        public void AumentarSalario(int id, double porcentagem)
        {
                Salario = ((porcentagem / 100) * Salario) + Salario;          
        }

        public override string ToString()
        {
            return "Employee: " + "ID: " + Id  + "\nName: " + Nome + "Salary: US$" + Salario; 
        }

    }
}
