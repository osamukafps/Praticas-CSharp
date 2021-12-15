using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEnum.Entities
{
    public class ContratoHorista
    {
        public DateTime Data { get; set; }
        public double ValorHora { get; set; }
        public int Horas { get; set; }

        public ContratoHorista()
        {

        }

        public ContratoHorista(DateTime data, double valor, int horas)
        {
            this.Data = data;
            this.ValorHora = valor;
            this.Horas = horas;
        }

        public double ValorTotal()
        {           
            return Horas * ValorHora;
        }
    }
}
