using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEnum.Entities
{
    class Departamento
    {
        public string NomeDepartamento { get; set; }

        public Departamento()
        {

        }

        public Departamento(string nome)
        {
            this.NomeDepartamento = nome;
        }

    }
}
